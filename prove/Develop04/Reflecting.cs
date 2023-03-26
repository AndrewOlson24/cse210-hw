using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ActivityPortal
{
    public class Reflecting: Activity
    {

        public override string PerformActivity()
        {
            List<string> Question = new List<string>{};
            Question.Add("Think of a time when you stood up for someone else.");
            Question.Add("Think of a time when you did something really difficult.");
            Question.Add("Think of a time when you helped someone in need.");
            Question.Add("Think of a time when you did something truly selfless.");
        

        List<string> Reflect1 = new List<string>();
            Reflect1.Add("Why was this experience meaningful to you?");
            Reflect1.Add("Have you ever done anything like this before?");
            Reflect1.Add("How did you get started?");
            Reflect1.Add("How did you feel when it was complete?");
            Reflect1.Add("What made this time different than other times when you were not as successful?");
            Reflect1.Add("What is your favorite thing about this experience?");
            Reflect1.Add("What could you learn from this experience that applies to other situations?");
            Reflect1.Add("What did you learn about yourself through this experience?");
            Reflect1.Add("What did you learn about yourself through this experience?");

            DateTime _currentTime = DateTime.Now;
            DateTime _futureTime = _currentTime.AddSeconds(this._activtyDuration);

            Console.Clear();
            Console.WriteLine("Get Ready....");
            this.DisplayAnimation();


            
            

            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine("");
            Random rand = new Random();
            int index = rand.Next(Question.Count);
            string randomItem = Question[index];
            Console.WriteLine("-----" + randomItem + "-----");
            Console.WriteLine("");
            Console.WriteLine("When you have something in mind, press enter to contiune.");
            Console.ReadLine();
            Console.WriteLine("You may Begin in:");
            this.DisplayCountdown();
            int i = 0;

            while(DateTime.Now < _futureTime)
            {
                Console.Write("> " + Reflect1[i++] + " ");
                this.DisplayAnimation();
                Console.Write("\b \b");

            }

        Console.WriteLine("");
        Console.WriteLine("Well Done!!!");
        Console.WriteLine("");

            

        return string.Empty;
        }
        
    }
        


}