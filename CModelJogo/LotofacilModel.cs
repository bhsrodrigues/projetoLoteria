using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace CModelJogo
{
    class LotofacilModel : GameModel
    {

        //protected static internal List<double> saveLotoFacil(Excel.Workbook wb,
        //    Excel.Worksheet ws, List<int[]> gameList, string gameName)
        //{
        //    ws = wb.Worksheets.Add();

        //    ws.Name = gameName;

        //    List<double> listInfoLotofacil = new List<double>() { gameList.Count, getGamePrize(gameList[0].Length) };

        //    fillHeaderGame(gameList[0].Length, ws);
            
        //    int row = 2;

        //    foreach (int[] item in gameList)
        //    {
        //        var column = 1;
        //        foreach (int value in item)
        //        {
        //            ws.Cells[row, column].Value = Convert.ToString(value);
        //            column++;
        //        }
        //        row++;
        //    }

        //    return listInfoLotofacil;
        //}

        //private static void fillHeaderGame(int numbersInGame, Excel.Worksheet ws)
        //{

        //    ws.Cells[1,1].EntireRow.Font.Bold = true;
        //    for (int count = 1; count <= numbersInGame; count++)
        //    {
        //        ws.Cells[1, count].ColumnWidth = 2.75;
        //        ws.Cells[1, count].Value = String.Format("N{0}", count);
        //    }
        //}

        //private static double getGamePrize(int numbersInGame)
        //{


        //    StreamReader sr = new StreamReader(@"..\\..\\..\\CModelJogo\\TabelaPreco.txt");
        //    int number = 0;
        //    while (sr.Peek() >= 0)
        //    {
        //        string[] itens = sr.ReadLine().Split(';');
        //        if (itens[1].Equals(numbersInGame.ToString()))
        //        {
        //            number = Convert.ToInt32(itens[2]);
        //            break;
        //        }
        //        Array.Clear(itens, 0, itens.Length);
        //    }

        //    return number * 0.01;
        //}

    }
}
