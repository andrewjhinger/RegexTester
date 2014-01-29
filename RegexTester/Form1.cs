using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void evaluateButton_Click(object sender, EventArgs e)
        {
                string input = inputTextBox.Text;
                string pattern = patternTextBox.Text;
                string replacePattern = replaceTextBox.Text;

                if (!string.IsNullOrEmpty(input))
                {
                    if (ignoreCheckBox.Checked == true)
                         {
                             try
                             {
                                 if (matchRadioButton.Checked == true)
                                 {
                                     MatchCollection mc = Regex.Matches(input, pattern, RegexOptions.None);
                                     foreach (Match m in mc)
                                     {
                                         resultListBox.Items.Add(m);
                                         Console.WriteLine(m);
                                     }
                                 }
                                 else
                                 {
                                         input = Regex.Replace(input, pattern, replacePattern, RegexOptions.None);
                                         resultListBox.Items.Add(input);
                                 }

                             }
                             catch (ArgumentException)
                             {
                                 errorLabel.Text = "parsing " + " '" + pattern + "' " + " - Unterminated [] set";
                                 errorLabel.ForeColor = System.Drawing.Color.Red;
                             }
                        }
                    else
                        {
                        try
                             {
                                 if (matchRadioButton.Checked == true)
                                 {
                                     MatchCollection mc = Regex.Matches(input, pattern, RegexOptions.IgnoreCase);
                                     foreach (Match m in mc)
                                     {
                                         resultListBox.Items.Add(m);
                                         Console.WriteLine(m);
                                     }
                                 }
                                 else
                                 {
                                         input = Regex.Replace(input, pattern, replacePattern, RegexOptions.IgnoreCase);
                                         resultListBox.Items.Add(input);
                                 }

                             }
                             catch (ArgumentException)
                             {
                                 errorLabel.Text = "parsing " + " '" + pattern + "' " + " - Unterminated [] set";
                                 errorLabel.ForeColor = System.Drawing.Color.Red;
                             }
                        }
                }

        }

        private void matchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (matchRadioButton.Checked == true)
            {
                //replaceRadioButton.Checked = false;
                replaceTextBox.Enabled = false;
            }
        }

        private void replaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (replaceRadioButton.Checked == true)
            {
                //matchRadioButton.Checked = true;
                replaceTextBox.Enabled = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
