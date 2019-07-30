using NET_Project_Runner.Models;
using NET_Project_Runner.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Project_Runner.Projects
{
    public class FactorialCalculator : IRun
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

            int number = GetNumber(_view);
            ulong total = 1;
            
            for (ulong i = 1; i <= (ulong) number; i++)
            {
                total *= i;
            }

            _view.Display($"Factorial of {number} = {total}");
        }

        private int GetNumber(View _view)
        {
            int num;
            bool validInput = false;

            do
            {
                _view.Display("Please provide an integer to the factorial calculator:");
                Console.Write(">");

                if (int.TryParse(Console.ReadLine(), out num))
                {
                    validInput = true;
                }

                Console.Clear();
            }
            while (!validInput);

            return num;
        }
    }
}
