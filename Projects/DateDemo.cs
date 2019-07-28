using NET_Project_Runner.Models;
using NET_Project_Runner.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Project_Runner.Projects
{
    public class DateDemo : IRun
    {
        private int _id;
        private string _name;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Run(ConsoleView _view)
        {
            DateTime myBirthdate = DateTime.Parse("10/16/1999");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthdate);
            Console.WriteLine("My age in days: " + myAge.TotalDays.ToString());

            DateTime myValue = DateTime.Now;
            Console.WriteLine("Current Month: " + myValue.Month.ToString());

            DateTime myValue2 = DateTime.Now;
            Console.WriteLine("Three Hours ago: " + myValue2.AddHours(-3).ToShortTimeString());

            DateTime myValue3 = DateTime.Now;
            Console.WriteLine("Three Days into the future: " + myValue3.AddDays(3).ToShortDateString());

            DateTime myValue4 = DateTime.Now;
            Console.WriteLine("Date as a string: " + myValue4.ToString());

            Console.WriteLine();
        }
    }
}
