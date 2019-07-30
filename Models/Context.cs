using NET_Project_Runner.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Project_Runner.Models
{
    public class Context
    {
        private List<IRun> _project;
        private List<int> _ids;

        public List<int> Ids
        {   
            get { return _ids; }
            set { _ids = value; }
        }
        public List<IRun> Projects
        {
            get { return _project; }
            set { _project = value; }
        }

        public Context()
        {
            Ids = new List<int>() { 0 };

            Projects = new List<IRun>()
            {
                new GameTicks
                {
                    Id = HandleId(),
                    Name = "Game Ticks"
                },

                new ListDemo
                {
                    Id = HandleId(),
                    Name = "List Demo"
                },

                new DateDemo
                {
                    Id = HandleId(),
                    Name = "Date Demo"
                },

                new UnicodeDemo
                {
                    Id = HandleId(),
                    Name = "Unicode Demo"
                },

                new FibonacciSequence
                {
                    Id = HandleId(),
                    Name = "Fibonacci Sequence"
                },

                new FactorialCalculator
                {
                    Id = HandleId(),
                    Name = "Factorial Calculator"
                }
            };
        }

        private int HandleId()
        {
            Ids.Add(Ids.Last() + 1);
            return Ids.Last();
        }
    }
}
