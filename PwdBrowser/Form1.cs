using System;
using System.Collections;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace PwdBrowser
{
    public partial class LookUpForm : Form
    {
        private RichTextBox ListBox;
        private StreamWriter sw;
        private System.Timers.Timer timer = new System.Timers.Timer(300);

        private string line, tempString, fileContent, directories = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\LookUp\\directories.txt";
        private string[] lines1, lines2, filePaths, readPaths, query, lastQuery1, lastQuery2;
        private List<string> searchResult, result1, result2, result, file;

        private int matchCounter, content1, content2, interruptChecker = 0;

        private bool backslashFound, alreadyOrdered1 = false, alreadyOrdered2 = false, erased;

        Regex reg = new Regex(@"[^a-zA-Z0-9]");




        public LookUpForm()
        {
            InitializeComponent();



            this.ActiveControl = SearchBox;
            timer.AutoReset = false;
            timer.Elapsed += OnTimedEvent;


            filePaths = new string[2];

            if (!File.Exists(directories))
            {
                sw = File.CreateText(directories);
                sw.Close();

                InitializeField(1);
                InitializeField(2);
            }
            else
            {
                try
                {
                    readPaths = File.ReadAllLines(directories);

                    line = readPaths[0].Split("?")[0].Trim();

                    if (File.Exists(line))
                    {
                        filePaths[0] = line;
                        UsingBox1.Text = line.Split("\\")[line.Split("\\").Length - 1];
                        EditButton1.Enabled = true;
                        UsingCheckBox1.Enabled = true;
                        UsingCheckBox1.Checked = IsChecked(readPaths[0].Split("?")[1]);
                        lines1 = ReadParse(filePaths[0]);
                        lastQuery1 = null;
                    }
                    else if (line == "")
                    {
                        InitializeField(1);
                    }
                    else
                    {
                        InitializeField(1);
                        UsingBox1.Text = "";
                        AppendText(UsingBox1, "Unresolvable file dir", Color.DarkRed, false);
                    }

                    line = readPaths[1].Split("?")[0].Trim();

                    if (File.Exists(line))
                    {
                        filePaths[1] = line;
                        UsingBox2.Text = line.Split("\\")[line.Split("\\").Length - 1];
                        EditButton2.Enabled = true;
                        UsingCheckBox2.Enabled = true;
                        UsingCheckBox2.Checked = IsChecked(readPaths[1].Split("?")[1]);
                        lines2 = ReadParse(filePaths[1]);
                        lastQuery2 = null;

                        if (filePaths[0] == filePaths[1])
                        {
                            if (UsingCheckBox1.Checked)
                                InitializeField(2);
                            else
                                InitializeField(1);
                        }

                    }
                    else if (line == "")
                    {
                        InitializeField(2);
                    }
                    else
                    {
                        InitializeField(2);
                        UsingBox2.Text = "";
                        AppendText(UsingBox2, "Unresolvable file dir", Color.DarkRed, false);
                    }

                    switch (int.Parse(readPaths[2]) == 0 ? 0 : 1)
                    {
                        case 0:
                            OptionAlpha.Checked = true;
                            break;
                        case 1:
                        default:
                            OptionNone.Checked = true;
                            break;
                    }

                }
                catch
                {
                    sw = File.CreateText(directories);
                    sw.Close();

                    InitializeField(1);
                    InitializeField(2);

                    OptionNone.Checked = true;

                    ListBox.Text = "";
                    AppendText(ListBox, "\nError reading config file\n", Color.Red, false);
                }
            }
        }


        private void PwdForm_Load(object sender, EventArgs e)
        {

        }


        private void SelectButton1_Click(object sender, EventArgs e) //I should set that if the user loads the same file the search isn't reissued
        {
            UsingCheckBox1.Checked = false;
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            filePaths[0] = openFileDialog1.FileName;

            if (filePaths[0] == "")
            {
                InitializeField(1);
            }
            else
            {
                UsingBox1.Text = filePaths[0].Split("\\")[filePaths[0].Split("\\").Length - 1];
                UsingCheckBox1.Enabled = true;
                UsingCheckBox1.Checked = true;
                EditButton1.Enabled = true;

                if (filePaths[0] == filePaths[1])
                {
                    InitializeField(2);
                    lines1 = lines2;
                }
                else
                {
                    lines1 = ReadParse(filePaths[0]);
                }
                lastQuery1 = null;
            }
            interruptChecker++;
            TimerStart();
            this.ActiveControl = SearchBox;
        }
        private void SelectButton2_Click(object sender, EventArgs e) //I should set that if the user loads the same file the search isn't reissued
        {
            UsingCheckBox2.Checked = false;
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            filePaths[1] = openFileDialog1.FileName;

            if (filePaths[1] == "")
            {
                InitializeField(2);
            }
            else
            {
                UsingBox2.Text = filePaths[1].Split("\\")[filePaths[1].Split("\\").Length - 1];
                UsingCheckBox2.Enabled = true;
                UsingCheckBox2.Checked = true;
                EditButton2.Enabled = true;

                if (filePaths[1] == filePaths[0])
                {
                    InitializeField(1);
                    lines2 = lines1;
                }
                else
                {
                    lines2 = ReadParse(filePaths[1]);
                }
                lastQuery2 = null;
            }
            interruptChecker++;
            TimerStart();
            this.ActiveControl = SearchBox;
        }



        private void EditButton1_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", filePaths[0]).WaitForExit();
            lines1 = ReadParse(filePaths[0]);
            lastQuery1 = null;
            interruptChecker++;
            TimerStart();
            this.ActiveControl = SearchBox;
        }
        private void EditButton2_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", filePaths[1]).WaitForExit();
            lines2 = ReadParse(filePaths[1]);
            lastQuery2 = null;
            interruptChecker++;
            TimerStart();
            this.ActiveControl = SearchBox;
        }

        private void OptionAlpha_CheckedChanged(object sender, EventArgs e)
        {
            if (OptionAlpha.Checked)
            {
                interruptChecker++;
                alreadyOrdered1 = false;
                alreadyOrdered2 = false;
                TimerStart();
            }
            this.ActiveControl = SearchBox;
        }

        private void OptionNone_CheckedChanged(object sender, EventArgs e)
        {
            if (OptionAlpha.Checked)
            {
                interruptChecker++;
                alreadyOrdered1 = true;
                alreadyOrdered2 = true;
                TimerStart();
            }
            this.ActiveControl = SearchBox;
        }

        private void UsingCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            interruptChecker++;
            TimerStart();
            UsingBox1.Enabled = UsingCheckBox1.Checked;

            this.ActiveControl = SearchBox;
        }



        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            TimerStart();
        }

        private void UsingCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            interruptChecker++;
            TimerStart();
            UsingBox2.Enabled = UsingCheckBox2.Checked;

            this.ActiveControl = SearchBox;
        }


        private bool IsChecked(string s)
        {
            return s.Trim() == "True";
        }

        private void ListBox_TextChanged(object sender, EventArgs e)
        {

        }

        public static void AppendText(RichTextBox box, string text, Color color, bool bold)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            if (bold)
                box.SelectionFont = new Font(box.SelectionFont, FontStyle.Bold);

            box.AppendText(text);

            if (bold)
                box.SelectionFont = new Font(box.SelectionFont, FontStyle.Regular);

            box.SelectionColor = box.ForeColor;

        }

        public static void AppendResult(RichTextBox box, string text, Color baseColor, Color highlightColor)
        {
            string tempText = "";
            char[] chars = text.ToCharArray();
            bool isHighlighted = false, foundBefore = false;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '%')
                {
                    if (foundBefore)
                    {
                        tempText += chars[i];
                        foundBefore = false;
                    }
                    else
                    {
                        foundBefore = true;
                    }
                }
                else
                {
                    if (foundBefore)
                    {
                        AppendText(box, tempText, (isHighlighted ? highlightColor : baseColor), isHighlighted);
                        tempText = "";

                        isHighlighted = !isHighlighted;
                        foundBefore = false;
                    }
                    tempText += chars[i];
                }
            }

            if (tempText.Length != 0)
            {
                AppendText(box, tempText, (isHighlighted ? highlightColor : baseColor), isHighlighted);
            }

            tempText = box.Lines[box.Lines.Length - 1];


            box.SelectionFont = box.Font;
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = baseColor;


        }


        private List<string> SearchResults(string[] file, string[] query, bool orderRequested, int user)
        {
            searchResult = new List<string>();

            foreach (string s in file)
            {
                if (!s.StartsWith('#'))
                {
                    matchCounter = 0;
                    foreach (string word in query)
                    {
                        if (!s.ToLower().Contains(word.ToLower()))
                        {
                            matchCounter++;
                        }
                    }
                    if (matchCounter == 0)
                    {
                        searchResult.Add(s);
                    }
                }
            }

            if (orderRequested)
            {
                searchResult = searchResult.OrderBy(x => reg.Replace(x, string.Empty)).ToList();
                if (user == 1)
                    alreadyOrdered1 = true;
                else if (user == 2)
                    alreadyOrdered2 = true;
            }

            return searchResult;
        }

        private void InitializeField(int value)
        {
            switch (value)
            {
                case 1:
                    UsingBox1.Text = "";
                    AppendText(UsingBox1, "Select a File", Color.DarkGray, false);
                    UsingCheckBox1.Checked = false;
                    UsingCheckBox1.Enabled = false;
                    EditButton1.Enabled = false;
                    alreadyOrdered1 = false;
                    lastQuery1 = null;
                    break;
                case 2:
                    UsingBox2.Text = "";
                    AppendText(UsingBox2, "Select a File", Color.DarkGray, false);
                    UsingCheckBox2.Checked = false;
                    UsingCheckBox2.Enabled = false;
                    EditButton2.Enabled = false;
                    alreadyOrdered2 = false;
                    lastQuery2 = null;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("value");
                    break;
            }
        }

        private string[] GetDifference(string[] v1, string[] v2)
        {
            return v1.Except(v2).ToArray();
        }


        private int HaveEqualContent(string[] newQ, string[] oldQ) // 0: exact same content, 1: old included in new, 2: old not included in new
        {

            if (ReferenceEquals(newQ, oldQ))
                return 0;

            if (newQ == null || oldQ == null)
                return 2;

            if (newQ.Length < oldQ.Length)
                return 2;

            if (newQ.Intersect(oldQ, StringComparer.OrdinalIgnoreCase).ToArray().Length == oldQ.Length)
            {
                if (GetDifference(newQ, oldQ).Length == 0)
                    return 0;
                else
                    return 1;
            }

            return 2;
        }

        private string[] Distinct(string[] v1)
        {
            bool isToAdd = false;
            List<string> result = new List<string>();
            Array.Sort(v1, (x, y) => x.Length.CompareTo(y.Length));

            for (int i = 0; i < v1.Length; i++)
            {
                isToAdd = true;
                for (int j = i + 1; j < v1.Length; j++)
                {
                    if (v1[j].Contains(v1[i]))
                    {
                        isToAdd = false;
                        break;
                    }
                }
                if (isToAdd)
                {
                    result.Add(v1[i]);
                }
            }
            return result.ToArray();
        }


        private void UpdateBox()
        {
            erased = false;
            if (SearchBox.Text.Length > 1)
            {
                query = Distinct(SearchBox.Text.ToLower().Split(" ").Distinct().ToArray());

                content1 = HaveEqualContent(query, lastQuery1);
                content2 = HaveEqualContent(query, lastQuery2);

                if (content1 * (UsingCheckBox1.Checked ? 1 : 0) + content2 * (UsingCheckBox2.Checked ? 1 : 0) + interruptChecker != 0)
                {
                    ListBox.Text = ""; //I delete text only when an interrupt comes from any source (except for searchBox which is processed right above)
                    erased = true;
                }

                if (UsingCheckBox1.Checked)
                {
                    switch (content1)
                    {
                        case 0:
                            if (ListBox.Text == "")
                            {
                                if (!alreadyOrdered1)
                                {
                                    result1 = result1.OrderBy(x => reg.Replace(x, string.Empty)).ToList();
                                    alreadyOrdered1 = true;
                                }
                                foreach (string s in result1)
                                {
                                    AppendResult(ListBox, s + "\n", Color.Lime, Color.Red);
                                }
                            }
                            break;
                        case 1:
                            result1 = SearchResults(result1.ToArray(), GetDifference(query, lastQuery1), !alreadyOrdered1, 1);

                            foreach (string s in result1)
                            {
                                AppendResult(ListBox, s + "\n", Color.Lime, Color.Red);
                            }

                            break;
                        case 2:

                            alreadyOrdered1 = false;

                            result1 = SearchResults(lines1, query, OptionAlpha.Checked, 1);

                            foreach (string s in result1)
                            {
                                AppendResult(ListBox, s + "\n", Color.Lime, Color.Red);
                            }
                            break;
                    }
                    lastQuery1 = query;

                }

                if (UsingCheckBox2.Checked)
                {
                    switch (content2)
                    {
                        case 0:
                            if (erased)
                            {
                                if (!alreadyOrdered2) // se sono già in alfabetico e li tolgo, semplicemente non li ordina, quindi rimangono già ordinati com'erano
                                {
                                    result2 = result2.OrderBy(x => reg.Replace(x, string.Empty)).ToList();
                                    alreadyOrdered2 = true;
                                }
                                foreach (string s in result2)
                                {
                                    AppendResult(ListBox, s + "\n", Color.Lime, Color.Red);
                                }
                            }
                            break;
                        case 1:
                            result2 = SearchResults(result2.ToArray(), GetDifference(query, lastQuery2), !alreadyOrdered2, 2);

                            foreach (string s in result2)
                            {
                                AppendResult(ListBox, s + "\n", Color.Lime, Color.Red);
                            }

                            break;
                        case 2:

                            result2 = SearchResults(lines2, query, OptionAlpha.Checked, 2);

                            foreach (string s in result2)
                            {
                                AppendResult(ListBox, s + "\n", Color.Lime, Color.Red);
                            }
                            break;
                    }
                    lastQuery2 = query;
                }
            }
            else
            {
                ListBox.Text = "";
            }

            interruptChecker = 0;
        }


        private string[] ReadParse(string filePath)
        {
            file = File.ReadAllLines(filePath).ToList();
            result = new List<string>();

            backslashFound = false;
            tempString = "";
            int index;

            foreach (string s in file)
            {
                if (s.EndsWith("\\"))
                {
                    if (!backslashFound)
                    {
                        tempString += s.Substring(0, s.Length - 1) + "\n";
                        backslashFound = true;
                    }
                    else
                    {
                        tempString += "|   " + s.Substring(0, s.Length - 1) + "\n";
                    }
                }
                else
                {
                    if (backslashFound)
                    {
                        tempString += "|_  " + s + "\n";
                        result.Add(tempString);
                        backslashFound = false;
                        tempString = "";
                    }
                    else
                    {
                        result.Add(s);
                    }
                }
            }
            return result.ToArray();
        }


        public void TimerStart()
        {
            timer.Stop();
            timer.Start();
        }

        public void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke(() => UpdateBox());
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            fileContent = filePaths[0] + " ? " + UsingCheckBox1.Checked + "\n" + filePaths[1] + " ? " + UsingCheckBox2.Checked + "\n" + (OptionAlpha.Checked ? 0 : 1);
            File.WriteAllText(directories, fileContent);
        }

        private void UsingBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}