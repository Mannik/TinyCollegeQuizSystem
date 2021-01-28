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
        
        public NewQuizForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
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

        private void addButton_Click(object sender, EventArgs e)
        {
            
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

            }
           
        }
    }
}
