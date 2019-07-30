using NET_Project_Runner.Models;
using NET_Project_Runner.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Project_Runner.Projects
{
    public class FibonacciSequence : IRun
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
            var sb = new StringBuilder();

            int length = GetFibonacciLength(_view);
            ulong[] fibonacci = new ulong[length];
            fibonacci[0] = 1;
            fibonacci[1] = 1;

            for (int i = 2; i < length; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            fibonacci.ToList().ForEach(f => sb.Append(f.ToString() + ','));

            _view.Display(sb.ToString());
        }

        private int GetFibonacciLength(View _view)
        {
            int length;
            bool validInput = false;

            do
            {
                _view.Display("Enter the amount of fibonacci numbers to calculate:");
                Console.Write(">");

                if (int.TryParse(Console.ReadLine(), out length))
                {
                    validInput = true;
                }

                Console.Clear();
            }
            while (!validInput);

            return length;
        }
    }
}
