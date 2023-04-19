using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Activity
{
    public class swimming : Activity
    {
        public override string PerformActivity()
        {
            DateTime _currentTime = DateTime.Now;
            DateTime _futureTime = _currentTime.AddMinutes(this._workOutDuration);
            Console.Clear();

            Console.WriteLine("How far would you like to Run? please type answer in miles: ");
            string _distanceOfRun = Console.ReadLine();
            int numberDistance = int.Parse(_distanceOfRun);



            Console.WriteLine("Get Ready....");
            this.DisplayCountdown();

            while (DateTime.Now < _futureTime)
            {
                Console.WriteLine("> Begin your run....");

                this.DisplayCountdown();

                Console.WriteLine("> great job-5 mintues down...");

            
            }
            Console.WriteLine("");
            Console.WriteLine("Well Done!!");
            return string.Empty;
        }
    }
}