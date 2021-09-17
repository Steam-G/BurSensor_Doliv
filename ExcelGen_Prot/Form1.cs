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



                #region Шапка отчета

                //Рисуем шапку отчета
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

                //Подготовка позиций для шапки
                _excelCells1 = (Excel.Range)oSheet.get_Range("A3", "B3").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("C3", "E3").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("A4", "B4").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("D4", "E4").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("F4", "J4").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("A5", "F5").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("G5", "M5").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("A6", "G6").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("H6", "M6").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("A7", "C7").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("G7", "M7").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("A8", "C8").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("F8", "G8").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("H8", "I8").Cells;
                _excelCells1.Merge(Type.Missing);

                CellHead(oSheet, 1, 3, "A3", "Месторождение:");
                CellHead(oSheet, 6, 3, "F3", "Куст №");
                CellHead(oSheet, 8, 3, "H3", "Скв. №");
                CellHead(oSheet, 10, 3, "J3", "Дата:");
                CellHead(oSheet, 1, 4, "A4", "Бригада №");
                CellHead(oSheet, 4, 4, "D4", "Бурильщики:");
                CellHead(oSheet, 1, 5, "A5", "Ответственные за заполнение листа долива:");
                CellHead(oSheet, 1, 6, "A6", "Ответственные за учет кол-ва поднятого/спущенного БИ:");
                CellHead(oSheet, 1, 7, "A7", "Забой скважины:");
                CellHead(oSheet, 5, 7, "E7", "Причина/Цель СПО:");
                CellHead(oSheet, 1, 8, "A8", "Плотность БР:");
                CellHead(oSheet, 6, 8, "F8", "Время начала СПО:");

                //Заполнение 
                CellHeadVal(oSheet, 3, 3, "C3", "E3", "#value#"); // Месторождение
                CellHeadVal(oSheet, 7, 3, "G3", "#value#"); // Куст №
                CellHeadVal(oSheet, 9, 3, "I3", "#value#"); // Скв. №
                CellHeadVal(oSheet, 11, 3, "K3", "#value#"); // Дата:
                CellHeadVal(oSheet, 3, 4, "C4", "#value#"); // Бригада №
                CellHeadVal(oSheet, 6, 4, "F4", "J4", "#value#");   // Бурильщики
                CellHeadVal(oSheet, 7, 5, "G5", "M5", "#value#");   // Ответственные за заполнение листа долива:
                CellHeadVal(oSheet, 8, 6, "H6", "M6", "#value#");   // Ответственные за учет кол-ва поднятого/спущенного БИ:
                CellHeadVal(oSheet, 4, 7, "D7", "#value#"); // Забой скважины: 
                CellHeadVal(oSheet, 7, 7, "G7", "M7", "#value#");   // Причина/Цель СПО:
                CellHeadVal(oSheet, 4, 8, "D8", "#value#"); // Плотность БР:
                CellHeadVal(oSheet, 8, 8, "H8", "I8", "#value#"); // Время начала СПО:

                #endregion

                #region Таблица отчета
                // Заготовка шапки таблицы
                _excelCells1 = PaintBorderAllLine(oSheet, "A10", "M11", Excel.XlBorderWeight.xlThin);
                _excelCells1 = PaintBorderOutLine(oSheet, "A10", "B11", Excel.XlBorderWeight.xlMedium);
                _excelCells1 = PaintBorderOutLine(oSheet, "C10", "D11", Excel.XlBorderWeight.xlMedium);
                _excelCells1 = PaintBorderOutLine(oSheet, "E10", "E11", Excel.XlBorderWeight.xlMedium);
                _excelCells1 = PaintBorderOutLine(oSheet, "F10", "F11", Excel.XlBorderWeight.xlMedium);
                _excelCells1 = PaintBorderOutLine(oSheet, "G10", "H11", Excel.XlBorderWeight.xlMedium);
                _excelCells1 = PaintBorderOutLine(oSheet, "I10", "J11", Excel.XlBorderWeight.xlMedium);
                _excelCells1 = PaintBorderOutLine(oSheet, "K10", "K11", Excel.XlBorderWeight.xlMedium);
                _excelCells1 = PaintBorderOutLine(oSheet, "L10", "M11", Excel.XlBorderWeight.xlMedium);

                //oSheet.UsedRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic);

                oSheet.Rows[10].RowHeight = 15.75;
                oSheet.Rows[11].RowHeight = 64.5;

                _excelCells1 = (Excel.Range)oSheet.get_Range("A10", "B11").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("C10", "D11").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("E10", "E11").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("F10", "F11").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("G10", "H10").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("I10", "J10").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("K10", "K11").Cells;
                _excelCells1.Merge(Type.Missing);
                _excelCells1 = (Excel.Range)oSheet.get_Range("L10", "M11").Cells;
                _excelCells1.Merge(Type.Missing);

                CellTableHead(oSheet, 1, 10, "A10", "Тип элемента КНБК\n(СБТ, ЛБТ, ТБТ, УБТ)");
                CellTableHead(oSheet, 3, 10, "C10", "Кол-во свечей");
                CellTableHead(oSheet, 5, 10, "E10", "Мера бур. инструмента, м");
                CellTableHead(oSheet, 6, 10, "F10", "Объем жидк. в доливной емк., м3");
                CellTableHead(oSheet, 7, 10, "G10", "Расчётный объём долива / вытеснения");
                CellTableHead(oSheet, 7, 11, "G11", "объем,       м3");
                CellTableHead(oSheet, 8, 11, "H11", "сумм. объем, м3");
                CellTableHead(oSheet, 9, 10, "I10", "Фактический объём долива / вытеснения");
                CellTableHead(oSheet, 9, 11, "I11", "объем,     м3");
                CellTableHead(oSheet, 10, 11, "J11", "сумм. объем, м3");
                CellTableHead(oSheet, 11, 10, "K10", "Суммарная нарастающая разница объема долива/вытеснения,м3");
                CellTableHead(oSheet, 12, 10, "L10", "Примечание (наличие/отсутствие сифона и т.д.)");

                string[,] testDatas = { 
                    {"кнбк","1","38.8","2.81","0.18", "0.18","0.17","0.17","-0.01","примечание"},
                    {"СБТ-89х9","1","38.8","2.81","0.18", "0.18","0.17","0.17","-0.01","примечание"},
                    {"УБТ 108","1","38.8","2.81","0.18", "0.18","0.17","0.17","-0.01","примечание"},
                    {"ЯС","1","38.8","2.81","0.18", "0.18","0.17","0.17","-0.01","примечание"},
                    {"СБТ-89х9","1","38.8","2.81","0.18", "0.18","0.17","0.17","-0.01","примечание"},
                };

                FillTable(oSheet, testDatas);

                #endregion

                #region Справочная информация отчета

                #endregion

                #region Подвал отчета

                #endregion

                ////Add table headers going cell by cell.
                //oSheet.Cells[2, 1] = "Тип элемента КНБК (СБТ, ЛБТ, ТБТ, УБТ)";
                //oSheet.Cells[2, 2] = "Last Name";
                //oSheet.Cells[2, 3] = "Full Name";
                //oSheet.Cells[2, 4] = "Salary";
            }
            catch { }
        }

        private void FillTable(Excel._Worksheet oSheet, string[,] testDatas)
        {
            int countRow = testDatas.GetLength(0);
            int countColumn = testDatas.GetLength(1);
            int[] columnPosition = {1,3,5,6,7,8,9,10,11,12 };
            string[,] columnMergePositionX1X2 = {
                {"A","B"},
                {"C","D"},
                {"E","E"},
                {"F","F"},
                {"G","G"},
                {"H","H"},
                {"I","I"},
                {"J","J"},
                {"K","K"},
                {"L","M"}
            };

            for (int k = 0; k < countRow; k++)
                for (int i = 0; i < countColumn; i++)
                {
                    string X1, X2;
                    X1 = columnMergePositionX1X2[i, 0] + (12 + k).ToString();
                    X2 = columnMergePositionX1X2[i, 1] + (12 + k).ToString();
                    Excel.Range _excelCellsData = (Excel.Range)oSheet.get_Range(X1, X2).Cells;
                    _excelCellsData.Merge(Type.Missing);
                    oSheet.Cells[12+k, columnPosition[i]] = testDatas[k, i];

                    var cl = oSheet.get_Range(X1);
                    cl.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    cl.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    cl.Font.Name = "Arial Cyr";
                    cl.Font.Size = 12;

                    if (i == 5 || i == 7 || i == 8)
                        cl.Font.Bold = true;
                    else cl.Font.Bold = false;

                    Microsoft.Office.Interop.Excel.XlBordersIndex BorderIndex;
                    BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft;
                    _excelCellsData.Borders[BorderIndex].Weight = Excel.XlBorderWeight.xlMedium;
                    _excelCellsData.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    _excelCellsData.Borders[BorderIndex].ColorIndex = 0;
                    BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom;
                    _excelCellsData.Borders[BorderIndex].Weight = Excel.XlBorderWeight.xlThin;
                    _excelCellsData.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    _excelCellsData.Borders[BorderIndex].ColorIndex = 0;
                    BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight;
                    _excelCellsData.Borders[BorderIndex].Weight = Excel.XlBorderWeight.xlMedium;
                    _excelCellsData.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    _excelCellsData.Borders[BorderIndex].ColorIndex = 0;

                    if (i==5 || i== 7)
                    {
                        BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft;
                        _excelCellsData.Borders[BorderIndex].Weight = Excel.XlBorderWeight.xlThin;
                        _excelCellsData.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        _excelCellsData.Borders[BorderIndex].ColorIndex = 0;
                    }
                }
            //throw new NotImplementedException();
        }

        private static Excel.Range PaintBorderAllLine(Excel._Worksheet oSheet, string XY1, string XY2, Microsoft.Office.Interop.Excel.XlBorderWeight borderWeight)
        {
            Excel.Range _excelCells1 = (Excel.Range)oSheet.get_Range(XY1, XY2).Cells;
            Microsoft.Office.Interop.Excel.XlBordersIndex BorderIndex;
            BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom;
            _excelCells1.Borders[BorderIndex].Weight = borderWeight;
            _excelCells1.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            _excelCells1.Borders[BorderIndex].ColorIndex = 0;
            BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop;
            _excelCells1.Borders[BorderIndex].Weight = borderWeight;
            _excelCells1.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            _excelCells1.Borders[BorderIndex].ColorIndex = 0;
            BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight;
            _excelCells1.Borders[BorderIndex].Weight = borderWeight;
            _excelCells1.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            _excelCells1.Borders[BorderIndex].ColorIndex = 0;
            BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft;
            _excelCells1.Borders[BorderIndex].Weight = borderWeight;
            _excelCells1.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            _excelCells1.Borders[BorderIndex].ColorIndex = 0;
            BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideHorizontal;
            _excelCells1.Borders[BorderIndex].Weight = borderWeight;
            _excelCells1.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            _excelCells1.Borders[BorderIndex].ColorIndex = 0;
            BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlInsideVertical;
            _excelCells1.Borders[BorderIndex].Weight = borderWeight;
            _excelCells1.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            _excelCells1.Borders[BorderIndex].ColorIndex = 0;
            return _excelCells1;
        }

        private static Excel.Range PaintBorderOutLine(Excel._Worksheet oSheet, string XY1, string XY2, Microsoft.Office.Interop.Excel.XlBorderWeight borderWeight)
        {
            Excel.Range _excelCells1 = (Excel.Range)oSheet.get_Range(XY1, XY2).Cells;
            Microsoft.Office.Interop.Excel.XlBordersIndex BorderIndex;
            BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom;
            _excelCells1.Borders[BorderIndex].Weight = borderWeight;
            _excelCells1.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            _excelCells1.Borders[BorderIndex].ColorIndex = 0;
            BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop;
            _excelCells1.Borders[BorderIndex].Weight = borderWeight;
            _excelCells1.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            _excelCells1.Borders[BorderIndex].ColorIndex = 0;
            BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight;
            _excelCells1.Borders[BorderIndex].Weight = borderWeight;
            _excelCells1.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            _excelCells1.Borders[BorderIndex].ColorIndex = 0;
            BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft;
            _excelCells1.Borders[BorderIndex].Weight = borderWeight;
            _excelCells1.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            _excelCells1.Borders[BorderIndex].ColorIndex = 0;

            return _excelCells1;
        }

        private static void CellHead(Excel._Worksheet oSheet, int X, int Y, string XY, string HeadName)
        {
            oSheet.Cells[Y, X] = HeadName;
            var cl = oSheet.get_Range(XY);
            cl.Font.Bold = true;
            cl.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            cl.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            cl.Font.Name = "Arial Cyr";
            cl.Font.Size = 12;
        }

        private static void CellHeadVal(Excel._Worksheet oSheet, int X, int Y, string XY1, string HeadName)
        {
            oSheet.Cells[Y, X] = HeadName;
            var cl = oSheet.get_Range(XY1);
            cl.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            cl.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            cl.Font.Name = "Arial Cyr";
            cl.Font.Size = 12;

            Microsoft.Office.Interop.Excel.XlBordersIndex BorderIndex;
            BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom;
            cl.Borders[BorderIndex].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
            cl.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            cl.Borders[BorderIndex].ColorIndex = 0;
        }

        private static void CellHeadVal(Excel._Worksheet oSheet, int X, int Y, string XY1, string XY2, string HeadName)
        {
            oSheet.Cells[Y, X] = HeadName;
            var cl = oSheet.get_Range(XY1, XY2);
            cl.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            cl.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            cl.Font.Name = "Arial Cyr";
            cl.Font.Size = 12;

            Microsoft.Office.Interop.Excel.XlBordersIndex BorderIndex;
            BorderIndex = Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom;
            cl.Borders[BorderIndex].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
            cl.Borders[BorderIndex].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            cl.Borders[BorderIndex].ColorIndex = 0;
        }

        private static void CellTableHead(Excel._Worksheet oSheet, int X, int Y, string XY, string HeadName)
        {
            oSheet.Cells[Y, X] = HeadName;
            var cl = oSheet.get_Range(XY);
            cl.Font.Bold = true;
            cl.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            cl.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            cl.Font.Name = "Arial Cyr";
            cl.Font.Size = 12;
            cl.WrapText = true;
        }
    }
}
