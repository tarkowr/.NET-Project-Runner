using NET_Project_Runner.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Project_Runner.Models
{
    public interface IRun
    {
        int Id { get; set; }
        string Name { get; set; }
        void Run (ConsoleView _view);
    }
}
