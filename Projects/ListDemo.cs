using NET_Project_Runner.Models;
using NET_Project_Runner.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Project_Runner
{
    class ListDemo : IRun
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
            List<string> myList = new List<string>();

            myList = GetList(_view);
            DisplayList(myList, _view);
        }

        private List<string> GetList(View _view)
        {
            string userResponse;
            var item = new List<string>();
            var selection = new ConsoleKeyInfo();
            int counter = 1;

            while (selection.Key != ConsoleKey.RightArrow)
            {
                Console.Clear();
                Console.CursorVisible = true;

                _view.Display($"Enter item {counter}: ");
                userResponse = Console.ReadLine();
                item.Add(userResponse);

                Console.CursorVisible = false;
                _view.Display("\nClick the right arrow to exit or any other key to add a new item.");
                selection = (ConsoleKeyInfo) _view.GetKey();

                counter++;
            }

            return item;
        }

        private static void DisplayList(List<string> item, View _view)
        {
            Console.Clear();

            _view.Display("Your List: \n");
            foreach (string p in item)
            {
                _view.Display(p);
            }

            _view.Display("");
        }
    }
}
