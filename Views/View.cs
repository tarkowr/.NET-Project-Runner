using NET_Project_Runner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Project_Runner.Views
{
    public abstract class View
    {
        public abstract void WaitForUser();
        public abstract void SetPosition(PositionModel positionModel);
        public abstract object GetKey();
        public abstract void Display(string msg);
        public abstract void ListProjects(List<IRun> projects, int selected);
    }
}
