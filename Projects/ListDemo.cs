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

        public void Run(ConsoleView _view)
        {
            List<string> myList = new List<string>();

            myList = GetList(_view);
            DisplayList(myList);
        }

        private List<string> GetList(ConsoleView _view)
        {
            string userResponse;
            var item = new List<string>();
            var selection = new ConsoleKeyInfo();
            int counter = 1;

            while (selection.Key != ConsoleKey.RightArrow)
            {
                Console.Clear();
                Console.CursorVisible = true;

                Console.WriteLine($"Enter item {counter}: ");
                userResponse = Console.ReadLine();
                item.Add(userResponse);

                Console.CursorVisible = false;
                Console.WriteLine("\nClick the right arrow to exit or any other key to add a new item.");
                selection = _view.GetKey();

                counter++;
            }

            return item;
        }

        private static void DisplayList(List<string> item)
        {
            Console.Clear();

            Console.WriteLine("Your List: \n");
            foreach (string p in item)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
        }
    }
}
