using DocumentFormat.OpenXml.Packaging;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aika
{
    public partial class InO : Form
    {
        public DateTime dt;
        public DateTime dts;

        public InO()
        {
            InitializeComponent();


            splitContainer1.IsSplitterFixed = true;

            Microsoft.Win32.SystemEvents.SessionSwitch += new Microsoft.Win32.SessionSwitchEventHandler(SystemEvents_SessionSwitch);

            STime.Text = DateTime.Now.ToString();
            In.Enabled = false;

            toolStripMenuItem1.Click += (s, o) => 
            { //maximize
                WindowState = FormWindowState.Maximized;
                ShowInTaskbar = true;
            };
            toolStripMenuItem2.Click += (s, o) => 
            { //exit
                if (MessageBox.Show("Do you really want to exit Aika?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    shortNotify.Visible = false;
                }
            };

            WindowState = FormWindowState.Maximized;
        }

        private void Out_Click(object sender, EventArgs e)
        {
            DateTime nower = DateTime.Now;
            Program.TimeLog.Add(new KeyValuePair<DateTime, DateTime>(nower, nower));
            dt = nower;

            DataTable doner = new DataTable();
            doner.Columns.Add("Out"); doner.Columns.Add("In"); doner.Columns.Add("Gap");

            foreach (KeyValuePair<DateTime, DateTime> kvp in Program.TimeLog)
            {
                TimeSpan st = kvp.Value - kvp.Key;

                doner.Rows.Add(kvp.Key.ToString(), kvp.Value.ToString(), st.ToString());
            }

            dataGridView1.DataSource = doner;

            ResizeDGW();

            In.Enabled = true;
            Out.Enabled = false;
        }

        private void In_Click(object sender, EventArgs e)
        {
            Program.TimeLog.RemoveAll(tl => tl.Key.Equals(dt));

            DateTime nower = DateTime.Now;

            Program.TimeLog.Add(new KeyValuePair<DateTime, DateTime>(dt, nower));
            TimeSpan ts = nower - dt;

            DataTable doner = new DataTable();
            doner.Columns.Add("Out"); doner.Columns.Add("In"); doner.Columns.Add("Gap");

            foreach (KeyValuePair<DateTime,DateTime> kvp in Program.TimeLog)
            {
                TimeSpan st = kvp.Value - kvp.Key;

                doner.Rows.Add(kvp.Key.ToString(), kvp.Value.ToString(), st.ToString());
            }

            dataGridView1.DataSource = doner;

            ResizeDGW();

            Out.Enabled = true;
            In.Enabled = false;
        }

        private void TT_Click(object sender, EventArgs e)
        {
            DateTime NowTime = DateTime.Now;
            DateTime StartTime = DateTime.Parse(STime.Text);
            TimeSpan GraceTime = NowTime - DateTime.Parse(STime.Text);

            foreach (KeyValuePair<DateTime, DateTime> kvp in Program.TimeLog)
            {
                TimeSpan st = kvp.Value - kvp.Key;

                GraceTime = GraceTime - st;
            }

            MessageBox.Show(GraceTime.ToString(), "Your Total In-Time: ", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void TTT_Click(object sender, EventArgs e)
        {
            TimeSpan GraceTime = new TimeSpan();

            foreach (KeyValuePair<DateTime, DateTime> kvp in Program.TimeLog)
            {
                TimeSpan st = kvp.Value - kvp.Key;
                GraceTime = GraceTime + st;
            }

            MessageBox.Show(GraceTime.ToString(), "Your Total Out-Time: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void SystemEvents_SessionSwitch(object sender, Microsoft.Win32.SessionSwitchEventArgs e)
        {
            if (e.Reason == SessionSwitchReason.SessionLock)
            {
                Out.PerformClick();
            }
            else if (e.Reason == SessionSwitchReason.SessionUnlock)
            {
                In.PerformClick();
            }
        }

        private void xl_Click(object sender, EventArgs e)
        {
            string localUser = Environment.UserName;
            string downloads = @"C:\Users\" + localUser + @"\Downloads\" + localUser + DateTime.Now.Ticks.ToString() + ".xlsx";

            DataSet ds = new DataSet();

            DataTable doner = new DataTable();
            doner.Columns.Add("Out"); doner.Columns.Add("In"); doner.Columns.Add("Gap");

            foreach (KeyValuePair<DateTime, DateTime> kvp in Program.TimeLog)
            {
                TimeSpan st = kvp.Value - kvp.Key;

                doner.Rows.Add(kvp.Key.ToString(), kvp.Value.ToString(), st.ToString());
            }

            ds.Tables.Add(doner);

            using (var workbook = SpreadsheetDocument.Create(downloads, DocumentFormat.OpenXml.SpreadsheetDocumentType.Workbook))
            {
                var workbookPart = workbook.AddWorkbookPart();

                workbook.WorkbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

                workbook.WorkbookPart.Workbook.Sheets = new DocumentFormat.OpenXml.Spreadsheet.Sheets();

                foreach (System.Data.DataTable table in ds.Tables)
                {

                    var sheetPart = workbook.WorkbookPart.AddNewPart<WorksheetPart>();
                    var sheetData = new DocumentFormat.OpenXml.Spreadsheet.SheetData();
                    sheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet(sheetData);

                    DocumentFormat.OpenXml.Spreadsheet.Sheets sheets = workbook.WorkbookPart.Workbook.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>();
                    string relationshipId = workbook.WorkbookPart.GetIdOfPart(sheetPart);

                    uint sheetId = 1;
                    if (sheets.Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Count() > 0)
                    {
                        sheetId =
                            sheets.Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Select(s => s.SheetId.Value).Max() + 1;
                    }

                    DocumentFormat.OpenXml.Spreadsheet.Sheet sheet = new DocumentFormat.OpenXml.Spreadsheet.Sheet() { Id = relationshipId, SheetId = sheetId, Name = table.TableName };
                    sheets.Append(sheet);

                    DocumentFormat.OpenXml.Spreadsheet.Row headerRow = new DocumentFormat.OpenXml.Spreadsheet.Row();

                    List<String> columns = new List<string>();
                    foreach (System.Data.DataColumn column in table.Columns)
                    {
                        columns.Add(column.ColumnName);

                        DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                        cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                        cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(column.ColumnName);
                        headerRow.AppendChild(cell);
                    }


                    sheetData.AppendChild(headerRow);

                    foreach (System.Data.DataRow dsrow in table.Rows)
                    {
                        DocumentFormat.OpenXml.Spreadsheet.Row newRow = new DocumentFormat.OpenXml.Spreadsheet.Row();
                        foreach (String col in columns)
                        {
                            DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                            cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                            cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(dsrow[col].ToString()); //
                            newRow.AppendChild(cell);
                        }

                        sheetData.AppendChild(newRow);
                    }

                }
            }

        }

        private void ResizeDGW()
        {
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //datagrid has calculated it's widths so we can store them
            for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            {
                //store autosized widths
                int colw = dataGridView1.Columns[i].Width;
                //remove autosizing
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //set width to calculated by autosize
                dataGridView1.Columns[i].Width = colw;
            }
        }

        private void Minimizing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
            shortNotify.Visible = true;
            shortNotify.ShowBalloonTip(1000, "Aika", "Aika is Monitoring ...!!!", ToolTipIcon.Info);
            ShowInTaskbar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TSC().Show();
        }
    }
}
