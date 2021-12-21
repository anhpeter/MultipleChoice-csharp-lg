using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuTextbox;
using FluentValidation.Results;
using MultipleChoiceApp.Common.UtilForms;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp.Common.Helpers
{
    class FormHelper
    {
        public static void MakeFullScreen(Form frm)
        {
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Top = 0;
            frm.Left = 0;
            frm.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 8);
        }

        public static void notify(String msg)
        {
            Alert alert = new Alert(msg);
            alert.ShowDialog();
        }
        public static void showErrorMsg(String msg, String title = "!")
        {
            frm_error_msg errorForm = new frm_error_msg(title, msg);
            errorForm.ShowDialog();
        }
        public static void showValidatorError(List<ValidationFailure> errorList)
        {
            String[] errArr = errorList.Select(v => $"• {v.ErrorMessage}").ToArray();
            String msg = string.Join("\r\n", errArr);
            frm_error_msg errorForm = new frm_error_msg("Validation", msg);
            errorForm.ShowDialog();
        }
        public static DialogResult showDeleteConfirm()
        {
            return MessageBox.Show(Msg.DELETE_CONFIRM, "Confirmation", MessageBoxButtons.YesNo);
        }
        public static async Task<bool> getIdle(BunifuTextBox txb)
        {
            string txt = txb.Text;
            await Task.Delay(500);
            return txt == txb.Text;
        }
        public static void replaceForm(Form currentFrm, Form newFrm)
        {
            currentFrm.Visible = false;
            newFrm.ShowDialog();
            currentFrm.Close();
        }

        public static bool toExcel(BunifuDataGridView gv, String fileName, String worksheetName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                setWorksheetDataGridview(gv, worksheet);
                worksheet.Name = worksheetName;
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                return true;
            }
            catch (Exception ex)
            {
                Util.log(ex.Message);
                return false;
            }
        }
        public static bool toExcel(List<Dictionary<String, String>> diclist, String fileName, String worksheetName)
        {
            if (diclist.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excel;
                Microsoft.Office.Interop.Excel.Workbook workbook;
                Microsoft.Office.Interop.Excel.Worksheet worksheet;
                try
                {
                    String[] headers = diclist[0].Keys.ToArray();
                    excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = false;
                    excel.DisplayAlerts = false;

                    workbook = excel.Workbooks.Add(Type.Missing);
                    worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                    for (int i = 0; i < headers.Length; i++)
                    {
                        worksheet.Cells[1, i + 1] = headers[i];
                    }

                    for (int i = 0; i < diclist.Count; i++)
                    {
                        for (int j = 0; j < headers.Length; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = diclist[i][headers[j]];
                        }
                    }
                    worksheet.Name = worksheetName;
                    workbook.SaveAs(fileName);
                    workbook.Close();
                    excel.Quit();
                    return true;
                }
                catch (Exception ex)
                {
                    Util.log(ex.Message);
                    return false;
                }
            }
            return false;
        }
        public static void setWorksheetDataGridview(BunifuDataGridView gv, Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            // export header
            for (int i = 0; i < gv.ColumnCount; i++)
            {
                worksheet.Cells[1, i + 1] = gv.Columns[i].HeaderText;
            }

            for (int i = 0; i < gv.RowCount; i++)
            {
                for (int j = 0; j < gv.ColumnCount; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = gv.Rows[i].Cells[j].Value.ToString().Trim();
                }
            }
        }

        public static List<Dictionary<String, String>> readEx(String fileName)
        {
            List<Dictionary<String, String>> dicList = new List<Dictionary<string, string>>();
            try
            {

                List<String> headers = new List<string>();
                using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(fileName)))
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];
                    for (int i = worksheet.Dimension.Start.Column; i <= worksheet.Dimension.End.Column; i++)
                    {
                        object header = worksheet.Cells[1, i].Value;
                        if (header != null)
                        {
                            headers.Add(header.ToString().Trim());
                        }
                    }
                    for (int i = worksheet.Dimension.Start.Row + 1; i <= worksheet.Dimension.End.Row; i++)
                    {
                        Dictionary<String, String> dic = new Dictionary<string, string>();
                        for (int j = 1; j <= headers.Count; j++)
                        {
                            object value = worksheet.Cells[i, j].Value;
                            if (value != null) dic.Add(headers[j - 1], value.ToString().Trim());
                        }
                        dicList.Add(dic);
                    }
                }
            }
            catch (Exception ex)
            {
                Util.log(ex.Message);
                return null;
            }
            return dicList;
        }
        public static void setFormSizeRatioOfScreen(Form form,  Double ratio)
        {
            Rectangle screen = Screen.FromControl(form).Bounds;
            int width = Convert.ToInt32(screen.Width * ratio);
            int height = Convert.ToInt32(screen.Height * ratio);
            form.Size = new Size(width, height);

        }

    }
}
