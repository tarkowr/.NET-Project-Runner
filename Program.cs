using NET_Project_Runner.Models;
using NET_Project_Runner.Views;
using NET_Project_Runner.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Project_Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            new Controller(new Context(), new ConsoleView()).ProjectMenu();
        }
    }
}
