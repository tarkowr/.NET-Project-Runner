using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Project_Runner.Models
{
    public enum CurrentScreen
    {
        MainMenu,
        Project
    }

    public class Status
    {
        private static CurrentScreen _current;

        public static CurrentScreen Current
        {
            get { return _current; }
            set { _current = value; }
        }
    }

}
