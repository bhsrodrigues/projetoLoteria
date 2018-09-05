using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game(15, 15, 18, 25);
            g.playGame();
            System.Threading.Thread.Sleep(5000);

        }
    }
}
