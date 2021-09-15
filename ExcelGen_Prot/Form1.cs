using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;


namespace ExcelGen_Prot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateExeleDoc();
        }

        private void GenerateExeleDoc()
        {
            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;

            try
            {
                //Start Excel and get Application object.
                oXL = new Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;

                //Ширина столбцов
                oSheet.Columns[1].ColumnWidth = 7.14;
                oSheet.Columns[2].ColumnWidth = 10.86;
                oSheet.Columns[3].ColumnWidth = 5;
                oSheet.Columns[4].ColumnWidth = 7.43;
                oSheet.Columns[5].ColumnWidth = 11.71;
                oSheet.Columns[6].ColumnWidth = 15;
                oSheet.Columns[7].ColumnWidth = 12.71;
                oSheet.Columns[8].ColumnWidth = 11.29;
                oSheet.Columns[9].ColumnWidth = 12.14;
                oSheet.Columns[10].ColumnWidth = 10.14;
                oSheet.Columns[11].ColumnWidth = 19.86;
                oSheet.Columns[12].ColumnWidth = 9.29;
                oSheet.Columns[13].ColumnWidth = 9.57;


                // Выделяем диапазон ячеек от H1 до K1         
                Excel.Range _excelCells1 = (Excel.Range)oSheet.get_Range("A1", "M1").Cells;
                // Производим объединение
                _excelCells1.Merge(Type.Missing);

                oSheet.Cells[1, 1] = "Лист контроля долива / вытеснения (ЗБС)";
                oSheet.get_Range("A1", "M1").Font.Bold = true;
                oSheet.get_Range("A1", "M1").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oSheet.get_Range("A1", "M1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oSheet.get_Range("A1", "M1").Font.Name = "Arial Cyr";
                oSheet.get_Range("A1", "M1").Font.Size = 20;

                //Add table headers going cell by cell.
                oSheet.Cells[2, 1] = "Тип элемента КНБК (СБТ, ЛБТ, ТБТ, УБТ)";
                oSheet.Cells[2, 2] = "Last Name";
                oSheet.Cells[2, 3] = "Full Name";
                oSheet.Cells[2, 4] = "Salary";
            }
            catch { }
        }
    }
}
