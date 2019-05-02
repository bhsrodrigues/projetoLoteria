using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CModelJogo
{
    public class Model
    {

        public static string fileName { get; set; }

        private static List<double>[] allGamesValues;

        internal static Excel.Application xlsapp;

        internal static Excel.Workbook wb;

        internal static Excel.Worksheet ws;
        
        public Model() {

            xlsapp = new Excel.Application();

            wb = xlsapp.Workbooks.Add();

            allGamesValues = new List<double>[7];
            
        }

        public void SaveGame(List<int[]> gameList, string gameName)
        {
            if (gameName.Equals("DiaDeSorte"))
            {
                allGamesValues[0] = new DiaDeSorteModel().SaveGameSheet(wb, ws, gameList, gameName);
            }
            if (gameName.Equals("Dupla-Sena"))
            {
                allGamesValues[1] = new DuplaSenaModel().SaveGameSheet(wb, ws, gameList, gameName);
            }
            if (gameName.Equals("Lotofacil"))
            {
                allGamesValues[2] = new LotofacilModel().SaveGameSheet(wb, ws, gameList, gameName);
            }
            if (gameName.Equals("Lotomania"))
            {
                allGamesValues[3] = new LotomaniaModel().SaveGameSheet(wb, ws, gameList, gameName);
            }
            if (gameName.Equals("Mega-Sena"))
            {
                allGamesValues[4] = new MegaSenaModel().SaveGameSheet(wb, ws, gameList, gameName);
            }
            if (gameName.Equals("Quina"))
            {
                allGamesValues[5] = new QuinaModel().SaveGameSheet(wb, ws, gameList, gameName);
            }
            if (gameName.Equals("Timemania"))
            {
                allGamesValues[6] = new TimemaniaModel().SaveGameSheet(wb, ws, gameList, gameName);
            }
        }

        public void SaveValues()
        {
            Frontsheet();

            GameInfoFrontSheet();

            xlsapp.DisplayAlerts = false;

            fileName = String.Format(@"{0}\Game{1}.xlsx", fileName, ActualDate());

            try
            {
                wb.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookDefault);

                wb.Close();

                xlsapp.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível gerar o arquivo. Tente novamente mais tarde");

                wb.Close();

                xlsapp.Quit();

            }
            
        }

        internal static void Frontsheet()
        {
            ws = wb.Worksheets.Add();

            ws.Name = "Resumo";

            ws.Move(wb.Worksheets[1]);

            HeaderFrontSheet();

            TotalFrontSheet();

        }

        internal static void HeaderFrontSheet()
        {
            ws.Cells[1, 1].EntireRow.Font.Bold = true;
            ws.Cells.EntireRow.HorizontalAlignment = 2;

            ws.Cells[1, 1].Value = "Jogo";

            ws.Cells[1, 2].Value = "Total de Jogos";

            ws.Cells[1, 3].Value = "Total Jogo";
        }

        internal static void FulfillGamePrizeInformation()
        {
            for(int count = 2; count <= 8; count++)
            {
                if (allGamesValues[count - 2] is null)
                {
                    ws.Cells[count, 2].Value = 0;
                    ws.Cells[count, 3].Value = "R$0,00";
                }
                else
                {
                    ws.Cells[count, 2].Value = (int)allGamesValues[count - 2][0];
                    ws.Cells[count, 3].Value = ((int)allGamesValues[count - 2][0] * allGamesValues[count - 2][1]);
                    ws.Cells[count, 3].NumberFormat = "R$#.###.###,00";
                }
            }
        }

        internal static void GameInfoFrontSheet()
        {
            ws.Cells[2, 1].Value = "Dia de Sorte";
            ws.Cells[3, 1].Value = "Dupla-Sena";
            ws.Cells[4, 1].Value = "Lotofácil";
            ws.Cells[5, 1].Value = "Lotomania";
            ws.Cells[6, 1].Value = "Mega-Sena";
            ws.Cells[7, 1].Value = "Quina";
            ws.Cells[8, 1].Value = "Timemania";
            FulfillGamePrizeInformation();
        }
        
        internal static int TotalFrontSheet()
        {
            return ws.UsedRange.Rows.Count;
        }


        internal static string ActualDate()
        {
            string Name;

            Name = DateTime.Now.Year.ToString() + 
                FormatNumber(DateTime.Now.Month.ToString()) + 
                FormatNumber(DateTime.Now.Day.ToString()) + 
                FormatNumber(DateTime.Now.Hour.ToString()) + 
                FormatNumber(DateTime.Now.Minute.ToString()) + 
                FormatNumber(DateTime.Now.Second.ToString());

            return Name;

        }

        internal static string FormatNumber(string value)
        {
            return value.Length == 1 ? "0" + value : value;
        }

    }
}
