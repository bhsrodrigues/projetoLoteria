using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {
        public int[] game;
        public List<int[]> allGames;

        private int numberListToBet, totalNumbers;
        
        public void playGame(int numberListToBet, int min, int max, int totalNumbers,
            int totalGames)
        {

            game = new int[this.numberListToBet];
            this.totalNumbers = totalNumbers;

            Array.Clear(game,0, numberListToBet);

            int counter = 0;
            
            while (counter < numberListToBet)
            {
                var newNumber = getNumber();
                if (!existNumberOnGame(newNumber))
                {
                    game[counter] = newNumber;
                    counter++;
                }
            }

            Array.Sort(game);

            var mensagem = "";

            foreach(int t in game)
            {
                mensagem += String.Format("{0};",t);
            }

            Console.WriteLine(mensagem);

            //return game;

        }

        public int[] getGame(int numberListToBet, int min, int max, int totalNumbers,
            int totalGames)
        {

            int[] tempGame;

            return 
        }

        private bool existNumberOnGame(int playedNumber)
        {
            foreach(int position in game)
            {
                if (position == playedNumber) return true;
            }
            return false;
        }

        private int getNumber()
        {
            Random rdn = new Random();
            int tempNumber = 0;
            bool foundNumber = false;
            while (!foundNumber)
            {
                tempNumber = rdn.Next(1,totalNumbers+1);
                if (tempNumber >= 1) foundNumber = true;
            }
            return tempNumber;
        }

    }
}
