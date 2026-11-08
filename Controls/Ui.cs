using System.Drawing;
using System.Windows.Forms;

namespace scholarship_Application.Controls
{
    public static class Ui
    {
        public static readonly Color Sidebar = Color.FromArgb(24, 41, 74);
        public static readonly Color SidebarHover = Color.FromArgb(40, 63, 108);
        public static readonly Color SidebarActive = Color.FromArgb(23, 93, 186);
        public static readonly Color Content = Color.FromArgb(243, 245, 249);
        public static readonly Color CardBack = Color.White;
        public static readonly Color TextMuted = Color.FromArgb(105, 115, 130);

        public static void Style(DataGridView grid)
        {
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Sidebar;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Sidebar;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.25F);
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            grid.ColumnHeadersHeight = 38;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            grid.DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(214, 229, 247);
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 35, 45);
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            grid.RowTemplate.Height = 32;
        }

        public static void TuneColumns(DataGridView grid)
        {
            foreach (DataGridViewColumn column in grid.Columns)
            {
                column.MinimumWidth = 60;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.HeaderText = column.DataPropertyName switch
                {
                    "StudentNumber" => "Student No.",
                    "FullName" => "Full name",
                    "ScholarshipType" => "Program",
                    "Gpa" => "GWA",
                    "AnnualIncome" => "Income / yr",
                    "Status" => "Status",
                    "SubmittedAt" => "Date",
                    _ => column.HeaderText,
                };
                if (column.DataPropertyName == "SubmittedAt")
                {
                    column.DefaultCellStyle.Format = "MMM d, yyyy";
                }
                if (column.DataPropertyName == "AnnualIncome")
                {
                    column.DefaultCellStyle.Format = "N0";
                }
                column.FillWeight = column.DataPropertyName switch
                {
                    "FullName" or "Email" => 150,
                    "StudentNumber" => 95,
                    "ScholarshipType" => 115,
                    "Gpa" => 60,
                    "AnnualIncome" => 110,
                    "Status" => 95,
                    "SubmittedAt" => 100,
                    _ => 100,
                };
            }
        }
    }
}
