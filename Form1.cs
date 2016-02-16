using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScriptCompare.Properties;

namespace ScriptCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            searchOption.SelectedIndex = 1;
        }
        string leftFile = null;
        string rightFile = null;
        string rightNotes = null;

        string[] leftFileArray = null;
        string[] rightFileArray = null;
        string[] rightNotesArray = null;

        private void openbothBut_Click(object sender, EventArgs e)
        {
            //open both files dialog box
            LoadLeftFile();
            LoadRightFile();
            DefaultDisplay();
        }

        void LoadLeftFile()
        {
            leftFile = GetFile(true);
            if (!(leftFile == null))
            {
                leftFileName.Text = Path.GetFileName(leftFile);
                leftFileArray = GetFileArray(leftFile);
            }
        }

        void LoadRightFile()
        {
            rightFile = GetFile(false);
            if (!(rightFile == null))
            {
                rightFileName.Text = Path.GetFileName(rightFile);
                rightNotes = rightFile.Split('.')[0] + ".snot";
                rightFileArray = GetFileArray(rightFile);
                rightNotesArray = GetNotes(rightNotes, rightFileArray.Length);
                SetScriptLine(0);
            }
        }

        void DefaultDisplay()
        {
            if (scriptAreaNumber.Text == "")
            {
                scriptAreaNumber.Text = "0";
                SetScriptLine(0);
            }
            else
            {
                RefreshScriptLine();
            }
            try
            {
                ofTotalLabel.Text = "of " + leftFileArray.Length + " script lines.";
            }
            catch { }
        }

        void RefreshScriptLine()
        {
            try
            {
                SetScriptLine(int.Parse(scriptAreaNumber.Text));
            }
            catch { }
        }

        string[] GetFileArray(string file)
        {
            string[] f = File.ReadAllText(file).Split(new string[] { @"[e" }, StringSplitOptions.None);
            for (int c = 0; c < f.Length; c++)
            {
                f[c] = f[c].Replace("n1]", "[en1]").Replace("n2]", "[en2]");
            }
            return f;
        }

        string[] GetNotes(string file, int len)
        {
            string[] f = new string[len];
            if (File.Exists(file))
            {
                 f = File.ReadAllLines(file);
                 if (!(f.Length < len))
                 {
                     List<string> temp = f.ToList<string>();
                     f = new string[len];
                     for (int p = 0; p < len; p++)
                     {
                         f[p] = temp[p];
                     }
                 }
            }
            return f;
        }

        string GetFile(bool left)
        {
            string file = null;
            OpenFileDialog d = new OpenFileDialog();
            d.AutoUpgradeEnabled = true;
            d.DefaultExt = "txt";
            d.Filter = "Text Script Files (*.txt)|*.txt";
            d.Title = "Open " + ((left) ? "Left" : "Right") + "-Hand Side file";
            if (d.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                file = d.FileName;
            }
            return file;
        }

        private void scriptAreaNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //watch keypresses to see if the input is valid
            //if invalid, change background to red, otherwise, default bg
            if (char.IsNumber(e.KeyChar))
            {
                scriptAreaNumber.BackColor = Color.White;
                textUpdate.Enabled = false;
                textUpdate.Enabled = true;
            }
            else
            {
                scriptAreaNumber.BackColor = Color.LightCoral;
                e.Handled = true;
            }
        }

        int lastline = -1;
        void SetScriptLine(int line)
        {
            saveTemp();
            int ecount = 0;
            try
            {
                if (!(leftFileArray == null))
                {
                    if (line < leftFileArray.Length)
                    {
                        leftText.Text = leftFileArray[line];
                        lastline = line;
                    }
                }
            }
            catch { ecount++; }
            try
            {
                if (!(rightFileArray == null))
                {
                    if (line < rightFileArray.Length)
                    {
                        rightText.Text = rightFileArray[line];
                        lastline = line;
                    }
                    if (line < rightNotesArray.Length)
                    {
                        noteBox.Text = rightNotesArray[line]; 
                    }
                }
            }
            catch { ecount++; }

            if (ecount > 0)
            {
                scriptAreaNumber.BackColor = Color.LightCoral;
            }
            else
            {
                scriptAreaNumber.Text = line.ToString();
                scriptAreaNumber.BackColor = Color.White;
            }
        }

        private void saveTemp()
        {
            if (lastline > -1)
            {
                try
                {
                    leftFileArray[lastline] = CheckLineBreaks(leftText.Text);
                    rightFileArray[lastline] = CheckLineBreaks(rightText.Text);
                    rightNotesArray[lastline] = noteBox.Text;
                }
                catch { }
            }
        }

        private void firstBut_Click(object sender, EventArgs e)
        {
            //gotofirst script line
            //saveTemp();
            SetScriptLine(0);
            
        }

        private void prevBut_Click(object sender, EventArgs e)
        {
            //goto previous script line
            try 
            {
                //saveTemp();
                SetScriptLine(int.Parse(scriptAreaNumber.Text) -1);
            }
            catch {  }
        }

        private void nextBut_Click(object sender, EventArgs e)
        {
            //goto next script line
            try
            {
                //saveTemp();
                SetScriptLine(int.Parse(scriptAreaNumber.Text) + 1);
            }
            catch { }
        }

        private void lastBut_Click(object sender, EventArgs e)
        {
            //goto last script line
            //saveTemp();
            SetScriptLine(leftFileArray.Length);
        }

        private void leftSaveBut_Click(object sender, EventArgs e)
        {
            SaveFile(true, leftFile);
        }

        private void leftSaveAsBut_Click(object sender, EventArgs e)
        {
            saveTemp();
            //save left text as...
            SaveAs(true);
        }

        private void leftOpenBut_Click(object sender, EventArgs e)
        {
            //open left text
            LoadLeftFile();
            DefaultDisplay();
        }

        private void rightSaveBut_Click(object sender, EventArgs e)
        {
            saveTemp();
            //save right text
            SaveFile(false, rightFile);
        }

        private void rightSaveAsBut_Click(object sender, EventArgs e)
        {
            saveTemp();
            //save right text as
            SaveAs(false);
        }

        private void SaveAs(bool left)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.AutoUpgradeEnabled = true;
            d.DefaultExt = "txt";
            d.Filter = "Text Script Files (*.txt)|*.txt";
            d.Title = "Save " + ((left) ? "Left" : "Right") + "-Hand Side Script As...";
            if (d.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                SaveFile(left, d.FileName);
            }
        }

        private void SaveFile(bool left, string file)
        {
            string final = "";
            if (left)
            {
                if (!(leftFileArray == null))
                {
                    foreach (string s in leftFileArray)
                    {
                        final += s;
                    }
                }
            }
            else
            {
                if (!(rightFileArray == null))
                {
                    foreach (string s in rightFileArray)
                    {
                        final += s;
                    }
                }
            }
            if (!(file == null))
            {
                File.WriteAllText(file, final);
            }
            if (!left)
            {
                final = "";
                if (!(rightNotesArray==null))
                {
                    foreach (string s in rightNotesArray)
                    {
                        final += s + "\r\n";
                    }
                    File.WriteAllText(file.Split('.')[0] + ".snot", final);
                }
            }
        }

        private void rightOpenBut_Click(object sender, EventArgs e)
        {
            //open right text
            LoadRightFile();
            DefaultDisplay();
        }

        private void textUpdate_Tick(object sender, EventArgs e)
        {
            RefreshScriptLine();
            textUpdate.Enabled = false;
        }

        private void characterTimer_Tick(object sender, EventArgs e)
        {
            leftChar.Text = CheckChar(leftText.Text) + " Characters";
            rightChar.Text = CheckChar(rightText.Text) + " Characters";
            
        }

        string CheckChar(string text)
        {
            int totaltext = text.Length;
            int totalcontrol = 0;
            int totalextrachars = 0;
            Match m = Regex.Match(text, @"\[([^\]]*)\]");
            for (int c = 1; c < m.Groups.Count; c++)
            {
                totalcontrol += m.Groups[c].Value.Length + 2; 
                if (m.Groups[c].Value.Contains('$'))
                {//has a hex value
                    int sStart = m.Groups[c].Value.IndexOf('$');

                    totalextrachars += (m.Groups[c].Value.Substring(sStart).Length / 2);
                }
                totalextrachars += (m.Groups[c].Length > 0) ? 1 : 0;
            }
            return ((totaltext - totalcontrol) + totalextrachars).ToString();
        }

        int leftNumber = 0;
        int rightNumber = 0;
        void goNextMatch()
        {
            if (searchOption.SelectedIndex == 0)
            {
                if (leftMatch.Count > 0)
                {
                    if (leftNumber == leftMatch.Count-1)
                    {
                        leftNumber = 0;
                    }
                    else
                    {
                        leftNumber++;
                    }
                    SetScriptLine(leftMatch[leftNumber]);
                }
                else
                {
                    //no match message
                }
            }
            else
            {
                if (rightMatch.Count > 0)
                {
                    if (rightNumber == rightMatch.Count-1)
                    {
                        rightNumber = 0;
                    }
                    else
                    {
                        rightNumber++;
                    }
                    SetScriptLine(rightMatch[rightNumber]);
                }
                else
                {
                    //no match message
                }
            }
        }

        string lastsearch = "";
        List<int> leftMatch = new List<int>();
        List<int> rightMatch = new List<int>();
        private void searchTimer_Tick(object sender, EventArgs e)
        {
            if (!(searchBox.Text == lastsearch))
            {
                lastsearch = searchBox.Text;
                leftMatch.Clear();
                rightMatch.Clear();

                if (searchOption.SelectedIndex == 0)
                {
                    if (!(leftFileArray== null))
                    {
                        for (int l = 0; l < leftFileArray.Length; l++)
                        {
                            if (leftFileArray[l].ToLower().Contains(lastsearch.ToLower()))
                            {
                                leftMatch.Add(l);
                            }
                        }
                        if (leftMatch.Count > 0)
                        {
                            leftNumber = -1;
                            goNextMatch();
                        }
                    }
                }
                else
                {
                    if (!(rightFileArray == null))
                    {
                        for (int r = 0; r < rightFileArray.Length; r++)
                        {
                            if (rightFileArray[r].ToLower().Contains(lastsearch.ToLower()))
                            {
                                rightMatch.Add(r);
                            }
                        }
                        if (rightMatch.Count > 0)
                        {
                            rightNumber = -1;
                            goNextMatch();
                        }
                    }
                }
            }
            //searchBox.Text
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                goNextMatch();
                e.Handled = true;
            }
        }
        Preview pForm = new Preview();
        VWFPreview vwfPForm = new VWFPreview();
        private void Form1_Load(object sender, EventArgs e)
        {
            //pForm.Show(this);
            //System.Threading.Thread.Sleep(3000);
            vwfPForm.Show(this);
        }

        int delaycount = 0;
        int lastdelay = 0;
        private void prevTimer_Tick(object sender, EventArgs e)
        {
            //pForm.SetText(rightText.Text);
            string originalText = rightText.Text;
            string newText = vwfPForm.SetText(rightText.Text);
            if (delaycount == lastdelay)
            {
                //make sure the text hasn't changed between preview generation time and now, not blank,
                //and has actually been modified by the preview generation routine
                if (originalText == rightText.Text && !(newText == "") && !(newText == rightText.Text))
                {
                    //DialogResult.Yes == MessageBox.Show("Apply Preview text ? \r\n" + newText, "Preview Generation Modified Text", MessageBoxButtons.YesNo)
                    applyWrap(newText);
                }
            }
            else
            {
                lastdelay++;
                if (delaycount == lastdelay)
                {
                    if (originalText == rightText.Text && !(newText == ""))
                    {
                        applyWrap(newText);
                    }
                }
            }
        }

        private void applyWrap(string text)
        {
            if (Settings.Default.EnableAutoWrapping)
            {
                int caret = rightText.SelectionStart;
                rightText.Text = text;
                rightText.SelectionStart = caret;
            }
        }

        private void noteBox_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for (int line = 0; line < rightFileArray.Length; line++)
            {
                rightFileArray[line] = CheckLineBreaks(rightFileArray[line]);
            }
        }

        string CheckLineBreaks(string theline)
        {
            string finalLine = "";
            string[] l_l = theline.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            for (int subl = 0; subl < l_l.Length; subl++)
            {
                string s_l = l_l[subl];
                if ((subl == 1 && l_l.Length > subl + 1) || !(s_l == ""))
                {
                    s_l = RemoveLineCodes(s_l);
                    switch (subl)
                    {
                        case 0://should only be line seperator control code
                            break;
                        case 1://no linebreak control codes
                            s_l = "\r\n" + s_l;
                            break;
                        case 2:
                            s_l = "\r\n[nl2]" + s_l;
                            break;
                        case 3:
                            s_l = "\r\n[nl3]" + s_l;
                            break;
                        default:
                            s_l = "\r\n[scl]" + s_l;
                            break;
                    }
                }
                finalLine += s_l;
            }
            return finalLine;
        }

        string RemoveLineCodes(string instring)
        {
            return instring.Replace("[nl2]", "").Replace("[nl3]", "").Replace("[scl]", "");
        }

        private void rightText_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void rightText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                delaycount += 2;
                if (delaycount > 10000)
                {
                    delaycount = 2;
                    lastdelay = 0;
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int caret = rightText.SelectionStart;
            string start = rightText.Text.Substring(0,caret).Replace("\r\n", " ");
            string end = rightText.Text.Substring(caret).Replace("\r\n", " ");
            caret = start.Length;
            string merge = (start + end).Replace("[en1] ", "[en1]\r\n").Replace("[en2] ", "[en2]\r\n");
            rightText.Text = RemoveLineCodes(merge);
            rightText.SelectionStart = caret;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Form frm = new Configuration();
            frm.ShowDialog(this);
        }



    }
}
