using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {

        int[] game;
        int number, totalNumbers;

        public Game(int number, int min, int max, int totalNumbers)
        {
            if (number < min)
            {
                this.number = min;
            }
            else if (number > max)
            {
                this.number = max;
            }
            else{
                this.number = number;
            }
            game = new int[this.number];
            this.totalNumbers = totalNumbers;
        }

        public void playGame()
        {
            
            int counter = 0;
            

            while (counter < number)
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
