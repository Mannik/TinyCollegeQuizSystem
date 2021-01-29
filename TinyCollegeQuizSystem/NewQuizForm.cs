using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyCollegeQuizSystem
{
    public partial class NewQuizForm : Form
    {
       
        SaveFileDialog sfd = new SaveFileDialog();
        string fileName = "placeholder.txt";

        public NewQuizForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //use streamwrite to write to quiz file, create if does not exist.
            using (StreamWriter sw = File.AppendText(fileName))
            {
                //check if entry boxes are blank, save if not
                if (!((string.IsNullOrWhiteSpace(questionTextBox.Text)) || (string.IsNullOrWhiteSpace(option1TextBox.Text))
                    || (string.IsNullOrWhiteSpace(option2TextBox.Text)) || (string.IsNullOrWhiteSpace(option3TextBox.Text)) || (string.IsNullOrWhiteSpace(option4TextBox.Text))))
                {

                    //check if a key is selected.
                    if (!option1RadioButton.Checked && !option2RadioButton.Checked && !option3RadioButton.Checked && !option4RadioButton.Checked)
                    {

                        MessageBox.Show("You must select a Key");


                    }
                    else
                    {

                        //Save entries to file
                        sw.WriteLine(questionTextBox.Text);
                        sw.WriteLine(option1TextBox.Text);
                        sw.WriteLine(option2TextBox.Text);
                        sw.WriteLine(option3TextBox.Text);
                        sw.WriteLine(option4TextBox.Text);
                        //clear screen
                        ClearScreen();
                    }


                }

                //if 1 or all are blank, inform user that all fields must be entered.
                else
                {
                    MessageBox.Show("All fields must be entered.");
                }

            }
        }

        private void NewQuizForm_Load(object sender, EventArgs e)
        {
            
            sfd.InitialDirectory = @"C:\";
            sfd.RestoreDirectory = true;
            sfd.FileName = "*.txt";
            sfd.DefaultExt = "txt";
            sfd.Filter = "txt files (*txt) | *.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = sfd.OpenFile();
                fileStream.Close();
                fileName = sfd.FileName;
            }
           
        }
        private void ClearScreen()
        {
            questionTextBox.Clear();
            option1TextBox.Clear();
            option1RadioButton.Checked = false;
            option2TextBox.Clear();
            option2RadioButton.Checked = false;
            option3TextBox.Clear();
            option3RadioButton.Checked = false;
            option4TextBox.Clear();
            option4RadioButton.Checked = false;
            questionTextBox.Focus();
        }
    }
}
