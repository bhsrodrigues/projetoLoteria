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

        private int numberListToBet, totalNumbers;

        public Game(int numberListToBet, int min, int max, int totalNumbers)
        {
            this.numberListToBet = validateNumbersToBet(numberListToBet, min, max);
            game = new int[this.numberListToBet];
            this.totalNumbers = totalNumbers;
        }

        public int[] playGame()
        {

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

            return game;

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

        private int validateNumbersToBet(int numbersToBet, int min, int max)
        {
            if (numbersToBet < min)
            {
                return min;
            }
            else if (numbersToBet > max)
            {
                return max;
            }
            else
            {
                return numbersToBet;
            }
        }
    }
}
