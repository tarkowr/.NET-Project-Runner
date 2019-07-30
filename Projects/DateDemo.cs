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

        public void Run(View _view)
        {
            DateTime myBirthdate = DateTime.Parse("10/16/1999");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthdate);
            _view.Display("My age in days: " + myAge.TotalDays.ToString());

            DateTime myValue = DateTime.Now;
            _view.Display("Current Month: " + myValue.Month.ToString());

            DateTime myValue2 = DateTime.Now;
            _view.Display("Three Hours ago: " + myValue2.AddHours(-3).ToShortTimeString());

            DateTime myValue3 = DateTime.Now;
            _view.Display("Three Days into the future: " + myValue3.AddDays(3).ToShortDateString());

            DateTime myValue4 = DateTime.Now;
            _view.Display("Date as a string: " + myValue4.ToString());

            _view.Display("");
        }
    }
}
