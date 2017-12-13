using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace ProductManager.Helper
{

    public class ExcelHelper {

        public static Application ReadFromExcelFile(string filePath) {
            try {
                var missing = System.Reflection.Missing.Value;
                var excel = new Application {
                    Visible = false,
                    UserControl = true
                };

                // 以只读的形式打开EXCEL文件
               excel.Application.Workbooks.Open(filePath, missing, false, missing, missing, missing,
                    missing, missing, missing, true, missing, missing, missing, missing, missing);
                //取得第一个工作薄
                //Worksheet ws = (Worksheet)wb.Worksheets.get_Item(sheetIndex);
                return excel;
            }
            catch (Exception e) {
                throw e;
            }
        }

        public static void CloseExcel(Application excel) {
            excel.ActiveWorkbook.Close();
            excel.DisplayAlerts = false;
            excel.Quit();
            KillExcel.Kill(new IntPtr(excel.Hwnd));
        }

        public class KillExcel {

            [DllImport("User32.dll", CharSet = CharSet.Auto)]
            public static extern int GetWindowThreadProcessId(IntPtr hwnd, out int id);

            /// <summary>
            /// 强制关闭当前Excel进程
            /// </summary>
            public static void Kill(IntPtr intPtr) {
                try {
                    var ps = Process.GetProcesses();
                    int excelId;
                    GetWindowThreadProcessId(intPtr, out excelId); //得到本进程唯一标志k
                    foreach (var p in ps) {
                        if (!p.ProcessName.ToLower().Equals("excel")) {
                            continue;
                        }
                        if (p.Id == excelId) {
                            p.Kill();
                        }
                    }
                }
                catch {
                    //不做任何处理
                }
            }
        }
    }
}