using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyCollegeQuizSystem
{
   public class Quiz
    {
        private string question;
        private string answer;
        private string key;

        public string Question
        {
            get { return question; }
            set { question = value; }
        }
        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }
        public string Key
        {
            get { return key; }
            set { key = value; }
        }
        // Constructor
        public Quiz(string question, string answer, string key)
        {
            this.question = question;
            this.answer = answer;
            this.key = key;
        }
        // To String
        public override string ToString()
        {
            string str;
            str = string.Format($"Question: {Question}," +
                string.Format($"{Answer}, ") +
                $"{Key}");
            return base.ToString();
        }
    }
}
