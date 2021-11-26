using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treelvy
{
    class excel
    {
        public static void DataTableToExcel(DataTable dtResult, string sheetName)
        {
            string path = @".\temp\" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx";
            FileInfo file = new FileInfo(path);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pack = new ExcelPackage(file))
            {
                ExcelWorksheet w = pack.Workbook.Worksheets[sheetName];
                if (w != null && w.Name.Equals(sheetName)) //判断是否存在该sheet表，存在则删除
                    pack.Workbook.Worksheets.Delete(w);
                ExcelWorksheet ws = pack.Workbook.Worksheets.Add(sheetName);
                ws.Cells["A1"].LoadFromDataTable(dtResult, true); //第二个参数设置为true则显示datable表头
                if (sheetName == "人员流动")
                    ws.Columns[5].Style.Numberformat.Format = "yyyy-mm-dd";
                else if(sheetName=="当前人员情况")
                    ws.Columns[2].Style.Numberformat.Format = "yyyy-mm-dd";
                else if(sheetName == "通过记录")
                    ws.Columns[3].Style.Numberformat.Format = "yyyy-mm-dd hh:mm:ss";
                ws.Cells[ws.Dimension.Address].AutoFitColumns();
                pack.Save();
            }
        }
    }
}
