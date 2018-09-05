using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoLoteria
{
    class Program
    {
        static void Main(string[] args)
        {

            //int totalGames = Convert.ToInt16(Console.ReadLine());

            Game g = new Game(15,15,18,25);
            g.playGame();
            System.Threading.Thread.Sleep(5000);

        }
    }

    
}
