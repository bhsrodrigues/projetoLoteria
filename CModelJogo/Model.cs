using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace CModelJogo
{
    public class Model
    {

        public static string FileName;

        private static List<double>[] allGamesValues;

        internal static Excel.Application xlsapp;

        internal static Excel.Workbook wb;

        internal static Excel.Worksheet ws;
        
        public Model() {

            xlsapp = new Excel.Application();

            wb = xlsapp.Workbooks.Add();

            allGamesValues = new List<double>[7];
            
        }

        public void saveGame(List<int[]> gameList, string gameName)
        {
            if (gameName.Equals("Dupla-Sena"))
            {
                allGamesValues[1] = LotofacilModel.saveGameSheet(wb, ws, gameList, gameName);
            }
            if (gameName.Equals("Lotofácil")) {
                allGamesValues[2] = LotofacilModel.saveGameSheet(wb, ws, gameList, gameName);
            }
        }

        public static void saveValues()
        {
            frontsheet();

            lfFrontSheet();

            xlsapp.DisplayAlerts = false;

            FileName = String.Format(@"{0}\File{1}.xlsx", FileName, actualDate());
            wb.SaveAs(FileName, Excel.XlFileFormat.xlWorkbookDefault);


            wb.Close();

            xlsapp.Quit();

        }

        internal static void frontsheet()
        {
            ws = wb.Worksheets.Add();

            ws.Name = "Resumo";

            ws.Move(wb.Worksheets[1]);

            headerFrontSheet();

            totalFrontSheet();

        }

        internal static void headerFrontSheet()
        {
            ws.Cells[1, 1].EntireRow.Font.Bold = true;
            ws.Cells.EntireRow.HorizontalAlignment = 2;

            ws.Cells[1, 1].Value = "Jogo";

            ws.Cells[1, 2].Value = "Total de Jogos";

            ws.Cells[1, 3].Value = "Total Jogo";
        }

        internal static void fulfillGamePrizeInformation()
        {
            for(int count = 2; count <= 8; count++)
            {
                if (allGamesValues[count - 2] is null)
                {
                    ws.Cells[count, 2].Value = 0;
                    ws.Cells[count, 3].Value = "R$ 0,00";
                }
                else
                {
                    ws.Cells[count, 2].Value = (int)allGamesValues[count - 2][0];
                    ws.Cells[count, 3].Value = ((int)allGamesValues[count - 2][0] * allGamesValues[count - 2][1]).ToString();
                }
            }
        }

        internal static void lfFrontSheet()
        {
            ws.Cells[2, 1].Value = "Dia de Sorte";
            ws.Cells[3, 1].Value = "Dupla-Sena";
            //if (allGamesValues[1] is null){
            //    ws.Cells[3, 2].Value = 0;
            //    ws.Cells[3, 3].Value = "R$ 0,00";
            //}
            //else
            //{
            //    ws.Cells[3, 2].Value = (int)allGamesValues[1][0];
            //    ws.Cells[3, 3].Value = ((int)allGamesValues[1][0] * allGamesValues[1][1]).ToString();
            //}
            ws.Cells[4, 1].Value = "Lotofácil";
            //ws.Cells[4, 2].Value = (int) allGamesValues[2][0];
            //ws.Cells[4, 3].Value = ((int)allGamesValues[2][0] * allGamesValues[2][1]).ToString();
            //ws.Cells[4, 3].NumberFormat = "R$ #.###.###,00";
            ws.Cells[5, 1].Value = "Lotomania";
            ws.Cells[6, 1].Value = "Mega-Sena";
            ws.Cells[7, 1].Value = "Quina";
            ws.Cells[8, 1].Value = "Timemania";
            fulfillGamePrizeInformation();
        }
        
        internal static int totalFrontSheet()
        {
            return ws.UsedRange.Rows.Count;
        }


        internal static string actualDate()
        {
            string name;

            name = DateTime.Now.Year.ToString() + formatNumber(DateTime.Now.Month.ToString())
          + formatNumber(DateTime.Now.Day.ToString());

            return name;

        }

        internal static string formatNumber(string value)
        {
            return value.Length == 1 ? "0" + value : value;
        }

    }
}
