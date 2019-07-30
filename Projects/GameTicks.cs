using NET_Project_Runner.Models;
using NET_Project_Runner.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace NET_Project_Runner.Projects
{
    class GameTicks : IRun
    {
        static int gameTick = 1;
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
            Timer gameTick = new Timer(1000);

            gameTick.Elapsed += GameTickTimer_Elapsed;

            gameTick.Start();
        }

        private static void GameTickTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Timer timer = (Timer)sender;
            TimeSpan gameTime = TimeSpan.FromSeconds(gameTick);

            if (Status.Current == CurrentScreen.MainMenu)
            {
                gameTick = 1;
                timer.Stop();
                timer.Dispose();
            }
            else
            {
                Console.WriteLine("Real Time: {0:hh:mm:ss:fff}", e.SignalTime);
                Console.WriteLine("Game Ticks: {0}", gameTick++);
                Console.WriteLine("Game Time: {0}", gameTime);
            }
        }
    }
}
