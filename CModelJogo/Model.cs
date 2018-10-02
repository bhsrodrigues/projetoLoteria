using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace CModelJogo
{
    public class Model
    {

        public static string FileName;

        private static List<double>[] allGamesValues;

        private Excel.Application xlsapp;

        private Excel.Workbook wb;

        private Excel.Worksheet ws;
        
        public Model() {

            xlsapp = new Excel.Application();

            wb = xlsapp.Workbooks.Add();

            allGamesValues = new List<double>[7];
            
        }

        public void saveGame(List<int[]> gameList, string gameName)
        {
            if (gameName.Equals("Lotofacil")) {
                allGamesValues[3] = LotofacilModel.saveLotoFacil(wb, ws, gameList);
            }
        }

        public void saveValues()
        {

            //if (gameName.Equals("Lotofacil"))
            //{
            //    saveLotoFacil(gameList);
            //}

            frontsheet();

            lfFrontSheet();

            xlsapp.DisplayAlerts = false;

            FileName = String.Format(@"{0}\File{1}.xlsx", FileName, actualDate());
            wb.SaveAs(FileName, Excel.XlFileFormat.xlWorkbookDefault);


            wb.Close();

            xlsapp.Quit();

        }

        public void frontsheet()
        {
            ws = wb.Worksheets.Add();

            ws.Name = "Resumo";

            ws.Move(wb.Worksheets[1]);

            headerFrontSheet();

            totalFrontSheet();

        }

        private void headerFrontSheet()
        {
            ws.Cells[1, 1].EntireRow.Font.Bold = true;
            ws.Cells.EntireRow.HorizontalAlignment = 2;

            ws.Cells[1, 1].Value = "Jogo";

            ws.Cells[1, 2].Value = "Total de Jogos";

            ws.Cells[1, 3].Value = "Total Jogo";
        }

        private void lfFrontSheet()
        {
            ws.Cells[2, 1].Value = "Dia de Sorte";
            ws.Cells[3, 1].Value = "Dupla-Sena";
            ws.Cells[4, 1].Value = "Lotofácil";
            ws.Cells[4, 2].Value = (int) allGamesValues[3][0];
            ws.Cells[4, 3].Value = ((int)allGamesValues[3][0] * allGamesValues[3][1]).ToString();
            ws.Cells[4, 3].NumberFormat = "R$ #.###.###,00";
            ws.Cells[5, 1].Value = "Lotomania";
            ws.Cells[6, 1].Value = "Mega-Sena";
            ws.Cells[7, 1].Value = "Quina";
            ws.Cells[8, 1].Value = "Timemania";
            ws.Cells[2, 1].Value = "Lotofácil";
            //ws.Cells[2, 2].Value = lotofacil[0];
            //ws.Cells[2, 3].Value = lotofacil[0] * lotofacil[1];
            //ws.Cells[2, 3].NumberFormat = "R$ #.###,##";
        }
        
        private int totalFrontSheet()
        {
            return ws.UsedRange.Rows.Count;
        }


        private string actualDate()
        {
            string name;

            name = DateTime.Now.Year.ToString() + formatNumber(DateTime.Now.Month.ToString())
          + formatNumber(DateTime.Now.Day.ToString());

            return name;

        }

        private string formatNumber(string value)
        {
            return value.Length == 1 ? "0" + value : value;
        }

    }
}
