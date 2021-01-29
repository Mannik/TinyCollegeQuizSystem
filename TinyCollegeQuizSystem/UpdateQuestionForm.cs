using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TinyCollegeQuizSystem
{
    public partial class UpdateQuestionForm : Form
    {
        List<Problem> Problems = new List<Problem>();
        string filePath = string.Empty;
        public UpdateQuestionForm()
        {
            InitializeComponent();
        }

        private void UpdateQuestionForm_Load(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string question;
                        //while next line read is not null, line = question
                        while ((question = reader.ReadLine()) != null)
                        {
                            string option1 = reader.ReadLine(); //next read line = option1
                            string option2 = reader.ReadLine(); //next read line = option2
                            string option3 = reader.ReadLine(); //next read line = option3
                            string option4 = reader.ReadLine(); //next read line = option4
                            int key = int.Parse(reader.ReadLine()); //parse 6th line in loop as key

                            //create new Problem
                            Problem p = new Problem(question, option1, option2, option3, option4, key);
                            //add to student list
                            Problems.Add(p);
                            //add to student list box
                            updateQuestionsListBox.Items.Add(p);
                        }
                    }
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
