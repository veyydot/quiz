using System;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Question q = new Question();
            q.text = "Wie was de uitvinder van adnan?";
            q.answer = "God";
            q.display();
            q.ReadAnswer();

            string s =  q.uAnswer;
            Console.WriteLine("You antwoord is:" + s);
            Console.WriteLine(q.checkAnswer(s));
            Console.ReadLine();

            Question q2 = new Question();
            q2.text = "Wie van deze mensen is gay? Selecteer A,B,C,D";
            Console.WriteLine("A:Colin");
            Console.WriteLine("B:Tom");
            Console.WriteLine("C:Abdel");
            Console.WriteLine("D:Sugar Lee Whooper");

            q2.answer = "B";
            q2.display();
            q2.ReadAnswer();
            string s2 = q2.answer;
            Console.WriteLine("You antwoord is:" + s2);
            Console.WriteLine(q2.checkAnswer(s2));
            Console.ReadLine();


        }
    }
}
