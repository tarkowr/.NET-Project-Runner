using NET_Project_Runner.Models;
using NET_Project_Runner.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Project_Runner.Projects
{
    public class UnicodeDemo : IRun
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
            Console.Clear();

            var numbers = new List<int>();
            var rand = new Random();

            int numberOfRandoms = GetNumberofRandoms();

            for (int i = 0; i < numberOfRandoms; i++)
            {
                numbers.Add(RandomNumber(rand));
            }

            DrawBoxes(numbers);
        }

        private static int RandomNumber(Random rand)
        {
            return rand.Next(1, 100);
        }

        private static int GetNumberofRandoms()
        {
            int numberOfRandoms;
            bool validInput = false;

            do
            {
                Console.WriteLine("Enter a number between 1 and 300 (inclusive):");
                Console.Write(">");

                if (int.TryParse(Console.ReadLine(), out numberOfRandoms))
                {
                    if (numberOfRandoms > 0 && numberOfRandoms <= 300)
                    {
                        validInput = true;
                    }
                }

                Console.Clear();
            }
            while (!validInput);

            return numberOfRandoms;
        }

        private static void DrawBoxes(List<int> numbers)
        {
            Console.ResetColor();
            Console.Clear();

            char ulCorner = '\u2554';
            char llCorner = '\u255A';
            char urCorner = '\u2557';
            char lrCorner = '\u255D';
            char v = '\u2551';
            char h = '\u2550';

            int cursorPosX = 5;
            int cursorPosY = 2;
            int lineHeight = 3;
            int column = 0;
            int numberPerRow = (int)Math.Round((double)Console.WindowWidth / 8, 1);
            int widthMultiplier = 7;

            Console.CursorVisible = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % numberPerRow == 0 && i != 0)
                {
                    cursorPosY += lineHeight;
                    column = 0;
                }

                Console.SetCursorPosition(cursorPosX + column * widthMultiplier, cursorPosY);
                Console.Write($"{ulCorner}{h}{h}{h}{h}{urCorner}");
                Console.SetCursorPosition(cursorPosX + column * widthMultiplier, cursorPosY + 1);

                if (numbers[i] >= 10)
                {
                    Console.Write($"{v} {numbers[i]} {v}");
                }
                else
                {
                    Console.Write($"{v} 0{numbers[i]} {v}");

                }

                Console.SetCursorPosition(cursorPosX + column * widthMultiplier, cursorPosY + 2);
                Console.Write($"{llCorner}{h}{h}{h}{h}{lrCorner}");

                column++;
            }
        }
    }
}
