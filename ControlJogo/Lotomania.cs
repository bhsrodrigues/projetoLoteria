using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlJogo
{
    public class Lotomania : Game
    {

        public List<int[]> playGame(int numberListToBet, int min, int max, int totalNumbers,
            int totalGames, string gameName, bool betMirror)
        {
            allGames = new List<int[]>();

            for (int startGame = 0; startGame < totalGames; startGame++)
            {
                game = new int[numberListToBet];

                this.totalNumbers = totalNumbers;

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

                allGames.Add(game);
                
                if (betMirror)
                {
                    allGames.Add(getUnusedNumbers(game));
                }
            }

            return allGames;
        }


        private int[] getUnusedNumbers(int[] oldGame)
        {

            int[] newGame = new int[50];
            bool found = false;
            int position = 0;

            for (int x = 0; x < 100; x++)
            {
                foreach(int item in oldGame)
                {
                    if(item == x)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found && position < 50) {
                    newGame[position] = x;
                    position++;
                }
                found = false;
            }

            Array.Sort(newGame);

            return newGame;
        }

        protected override int getNumber()
        {
            Random rdn = new Random();
            int tempNumber = 0;
            bool foundNumber = false;
            while (!foundNumber)
            {
                tempNumber = rdn.Next(1, totalNumbers + 1);
                if (tempNumber >= 1) foundNumber = true;
            }

            return tempNumber == 100 ? 0 : tempNumber;
        }

    }
}
