using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Activity
{
    class Program
    {
        MainMenu _mainMenu = new MainMenu();
        static byte _byChoice = 0;
        static bool _bQuit = false;

        // The main program
        static void Main(string[] args)
        {
            ActivityOperations _activityOps = new ActivityOperations();
            int _sessionTime = 0;
            string _nameOfActivity = "";
            while (!_bQuit)
            {
                MainMenu.DisplayMenu();
                _byChoice = Convert.ToByte(Console.ReadLine());

                switch (_byChoice)
                {
                    case 1:
                        Running _workOutActivity = new Running();
                        

                        _workOutActivity._workOutName = "Running";
                         _workOutActivity._workOutDescription = "Running is such a great way to stay in shape!!!!";
                         _workOutActivity._workOutDuration = _activityOps.PresentActivity( _workOutActivity);
                        _sessionTime =  _workOutActivity._workOutDuration;
                        _nameOfActivity =  _workOutActivity._workOutName;

                        _workOutActivity.PerformActivity();

                        Console.Write("");

                        break;
                    case 2:
                        Cycling _cyclingActivity = new Cycling();
                        
                        
                        _cyclingActivity._workOutName = "Reflecting Activity";
                        _cyclingActivity._workOutDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                        _cyclingActivity._workOutDuration = _activityOps.PresentActivity(_cyclingActivity);
                        _sessionTime = _cyclingActivity._workOutDuration;
                        _nameOfActivity = _cyclingActivity._workOutName;

                        _cyclingActivity.PerformActivity();
                        
                        Console.Write("");

                        break;
                    case 3:
                        swimming _swimmingActivity = new swimming();
                        

                        _swimmingActivity._workOutName = "Listing Activity";
                        _swimmingActivity._workOutDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                        _swimmingActivity._workOutDuration = _activityOps.PresentActivity(_swimmingActivity);
                        _sessionTime = _swimmingActivity._workOutDuration;
                        _nameOfActivity = _swimmingActivity._workOutName;

                        _swimmingActivity.PerformActivity();

                        Console.Write("");

                        break;
                    case 4:
                        _bQuit = true;
                        break;
                    default:
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("*** Invalid selection - please try again. ***");
                        Console.WriteLine("---------------------------------------------\n");
                        break;
                }
            
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("You have completed " + _sessionTime + " seconds of the " + _nameOfActivity + "!" );
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("-------------THANKS-FOR-PLAYING--------------");
                Console.WriteLine("---------------------------------------------");
            }
        }
    }

    // The base class for this project
    public abstract class Activity
    {
        public string _workOutName;
        public string _workOutDescription;
        public int _workOutDuration;

        public abstract string PerformActivity();

        public void DisplayAnimation()
        {
            Console.Write("|");
            Thread.Sleep(1000);
            Console.Write("\b/");   // Replace it with the - character
            Thread.Sleep(1000);
            Console.Write("\b-");
            Thread.Sleep(1000);
            Console.Write("\b\\");   // Erase the + character
            Thread.Sleep(1000);
            Console.Write("\b|");
            Thread.Sleep(1000);
            Console.WriteLine("\b \b");
        }

        public void DisplayCountdown()
        {
            for (int x = 5; x>= 1; x--)
            {
                Console.Write(x.ToString());
                Thread.Sleep(60000);
                Console.Write("\b");

            }

            Console.WriteLine("\b \b");

        }
     }

    // Menu class
    public class MainMenu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("WElcome to the Fitess app");
            Console.WriteLine("Pick your option on what to track durring this session");
            Console.WriteLine("Menu options:");
            Console.WriteLine("\t1. Running");
            Console.WriteLine("\t2. Stationary Bicycles");
            Console.WriteLine("\t3. Swimming in the lap pool");
            Console.WriteLine("\t4. Quit");
        }
    }

    public class ActivityOperations
    {
        public int PresentActivity(Activity _currentActivity)
        {
            Console.WriteLine("Welcome to the "+_currentActivity._workOutName + ".");
            Console.WriteLine();
            Console.WriteLine(_currentActivity._workOutDescription);
            Console.WriteLine();
            Console.WriteLine("How long in minutes would you like for your session?");
            int _minutesActivity = Convert.ToInt32(Console.ReadLine());
            return _minutesActivity;
        }
    }

    public class MathOperations
    {
        public double CalculateSwimSpeedMPH(double _swimmingLaps)
        {
            return _swimmingLaps * 50 / 1000 * 0.62;
        }

        public double CalculateSpeed(double _speed)
        {
            return _speed = (PresentActivity._distanceOfRun / _minutesActivity) * 60;
        }

        public int _Pace = 0;




    }
}