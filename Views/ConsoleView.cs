using NET_Project_Runner.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NET_Project_Runner.Views
{
    public class ConsoleView : View
    {
        public override void WaitForUser()
        {
            Console.ReadKey();
        }

        public override void SetPosition(PositionModel positionModel)
        {
            Console.SetCursorPosition(positionModel.x, positionModel.y);
        }

        public override void Display(string msg)
        {
            Console.WriteLine(msg);
        }

        public override object GetKey()
        {
            var i = new ConsoleKeyInfo();
            i = Console.ReadKey(true);
            return i;
        }

        public override void ListProjects(List<IRun> projects, int selected)
        {
            int ind = 1;

            Console.Clear();
            Console.CursorVisible = false;

            Console.WriteLine("Select a Project or Exit: \n");

            foreach(var proj in projects)
            {
                if(proj.Id == selected)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine($"\t{ind}. {proj.Name}");

                Console.ForegroundColor = ConsoleColor.Gray;
                ind++;
            }

            if (selected > projects.Count())
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\t{ind}. Exit");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.WriteLine($"\t{ind}. Exit");
            }
        }
    }
}
