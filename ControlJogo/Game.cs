using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CModelJogo;

namespace ConsoleApp1
{
    public class Game
    {
        public int[] game;
        protected List<int[]> allGames;

        protected int totalNumbers;
        
        public virtual List<int[]> PlayGame(int numberListToBet, int min, int max, int totalNumbers,
            int totalGames, string gameName)
        {
            allGames = new List<int[]>();

            for (int startGame = 0; startGame < totalGames; startGame++)
            {
                game = new int[numberListToBet];

                this.totalNumbers = totalNumbers;

                int counter = 0;

                while (counter < numberListToBet)
                {
                    var newNumber = GetNumber();
                    if (!ExistNumberOnGame(newNumber))
                    {
                        game[counter] = newNumber;
                        counter++;
                    }
                }

                Array.Sort(game);

                allGames.Add(game);
            }

            return allGames;

            //Model mdl = new Model();
            //mdl.saveGame(allGames, gameName);
        }
        

        protected bool ExistNumberOnGame(int playedNumber)
        {
            foreach(int position in game)
            {
                if (position == playedNumber) return true;
            }
            return false;
        }

        protected virtual int GetNumber()
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
