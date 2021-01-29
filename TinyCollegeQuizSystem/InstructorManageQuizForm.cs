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
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        public InstructorManageQuizForm()
        {
            InitializeComponent();
        }

        void newQuizButton_Click(object sender, EventArgs e)
        {
            NewQuizForm quizForm = new NewQuizForm();
            quizForm.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateQuestionForm updateForm = new UpdateQuestionForm();
            updateForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
