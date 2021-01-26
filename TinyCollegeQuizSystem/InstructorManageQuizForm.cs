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
    public partial class InstructorManageQuizForm : Form
    {
        public InstructorManageQuizForm()
        {
            InitializeComponent();
        }

        private void newQuizButton_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if((myStream = saveFileDialog.OpenFile()) != null)
                {
                    myStream.Close();
                    NewQuizForm quizForm = new NewQuizForm();
                    quizForm.ShowDialog();
                }
            }
        }
    }
}
