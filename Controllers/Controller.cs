using NET_Project_Runner.Models;
using NET_Project_Runner.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Project_Runner.Controllers
{
    public class Controller
    {
        private ConsoleView _view;
        private Context _context;

        public Controller(Context context, ConsoleView view)
        {
            _context = context;
            _view = view;
        }

        public void ProjectMenu()
        {
            int index = 0;

            while (index < _context.Projects.Count())
            {
                Status.Current = CurrentScreen.MainMenu;
                index = GetProject();

                if (index < _context.Projects.Count())
                {
                    Console.Clear();

                    var proj = _context.Projects.ElementAt(index);
                    Status.Current = CurrentScreen.Project;
                    proj.Run(_view);

                    Console.WriteLine("\n\nPress any key to continue.\n");
                    _view.WaitForKey();
                }
            }
        }

        private int GetProject()
        {
            int selected = 1;
            var key = new ConsoleKeyInfo();

            _view.ListProjects(_context.Projects, selected);

            while (key.Key != ConsoleKey.Enter)
            {
                key = _view.GetKey();

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        selected -= 1;
                        break;
                    case ConsoleKey.DownArrow:
                        selected += 1;
                        break;
                    default:
                        break;
                }

                if (selected < 1)
                {
                    selected = _context.Projects.Count() + 1;
                }

                if (selected > _context.Projects.Count() + 1)
                {
                    selected = 1;
                }

                _view.ListProjects(_context.Projects, selected);
            }

            return selected - 1;
        }
    }
}
