using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace CModelJogo
{
    public class Model
    {

        List<double> lotofacil;

        public Excel.Application xlsapp;

        public Excel.Workbook wb;

        public Excel.Worksheet ws;
        
        public Model() {

            xlsapp = new Excel.Application();

            wb = xlsapp.Workbooks.Add();
            
        }

        public void saveLotoFacil(List<int[]> gameList)
        {
            ws = wb.Worksheets.Add();

            ws.Name = "Lotofacil";

            lotofacil = new List<double>() { gameList.Count, 2.00};
            

            int row = 1;

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
        }

        public void saveValues()
        {

            frontsheet();

            lfFrontSheet();

            string fileName = String.Format(@"C:\Users\bhrodrigues\Desktop\File{0}.xlsx", actualDate());

            wb.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookDefault);

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
            ws.Cells[2, 1].Value = "Lotofácil";
            ws.Cells[2, 2].Value = lotofacil[0];
            ws.Cells[2, 3].Value = lotofacil[0] * lotofacil[1];
        }
        
        private void totalFrontSheet()
        {
            foreach(int count in ws.UsedRange)
            {
                Console.WriteLine(ws.Cells[count,1]);
            }
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
