using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace CModelJogo
{
    public class GameModel
    {
        private static StreamReader sr;
        public GameModel()
        {
            sr = new StreamReader(@"..\\..\\..\\CModelJogo\\TabelaPreco.txt", Encoding.UTF8);
        }

        protected internal List<double> saveGameSheet(Excel.Workbook wb,
    Excel.Worksheet ws, List<int[]> gameList, string gameName)
        {
            ws = wb.Worksheets.Add();

            ws.Name = gameName;

            List<double> listInfoGame = new List<double>() { gameList.Count, getGamePrize(gameList[0].Length, gameName) };

            fillHeaderGame(gameList[0].Length, ws);

            int row = 2;

            foreach (int[] item in gameList)
            {
                var column = 1;
                foreach (int value in item)
                {
                    ws.Cells[row, column].Value = Convert.ToString(value);
                    column++;
                }
                row++;
            }

            return listInfoGame;
        }

        private void fillHeaderGame(int numbersInGame, Excel.Worksheet ws)
        {

            ws.Cells[1, 1].EntireRow.Font.Bold = true;
            for (int count = 1; count <= numbersInGame; count++)
            {
                ws.Cells[1, count].ColumnWidth = 2.75;
                ws.Cells[1, count].Value = String.Format("N{0}", count);
            }
        }

        private double getGamePrize(int numbersInGame, string gameName)
        {
            int number = 0;
            while (sr.Peek() >= 0)
            {
                string[] itens = sr.ReadLine().Split(';');
                if (itens[1].Equals(numbersInGame.ToString()) && 
                    itens[0].Equals(gameName.ToUpper()))
                {
                    number = Convert.ToInt32(itens[2]);
                    break;
                }
                Array.Clear(itens, 0, itens.Length);
            }
            
            return number * 0.01;
        }


        public List<int> getNumbers(string gameName)
        {

            List<int> list = new List<int>();

            while(sr.Peek() >= 0)
            {
                string[] itens = sr.ReadLine().Split(';');
                if (gameName.ToUpper().Equals(itens[0].Trim()))
                {
                    list.Add(Convert.ToInt16(itens[1]));
                }
                Array.Clear(itens,0,itens.Length);
                
            }

            return list;

        }
    }
}
