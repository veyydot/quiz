using System;
using System.Collections.Generic;
using System.Text;

namespace quiz
{
    class Question
    {
       public string text{ get; set; }
       public string answer{ get; set; }
       public string uAnswer{ get; set; }

        public Question()
        {
            text = "";
            answer = "";
        }
        public Boolean checkAnswer(String response)
        {
            return response.Equals(answer);
        }
        public void display()
        {
            Console.WriteLine(this.text);
        }
        public void ReadAnswer()
        {
             uAnswer = Console.ReadLine();
        }
    }
}
