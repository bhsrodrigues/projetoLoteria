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

        public Excel.Application xlsapp;

        public Excel.Workbook wb;

        public Excel.Worksheet ws;

        private string fileName;

        public Model() {

            xlsapp = new Excel.Application();

            wb = xlsapp.Workbooks.Add();

            ws = wb.Worksheets.Add();

            ws.Name = "Teste";

            string fileName = String.Format(@"C:\Users\bhrodrigues\Desktop\File{0}.xlsx", actualDate());

            wb.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookDefault);

            wb.Close();
        }

        public void writeValues()
        {

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
