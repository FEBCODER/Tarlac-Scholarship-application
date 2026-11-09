namespace scholarship_Application.Controls
{
    partial class MyApplicationsControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            lblHeading = new Label();
            lblSummary = new Label();
            pnlGridHost = new Panel();
            grid = new DataGridView();
            pnlGridHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Dock = DockStyle.Top;
            lblHeading.Font = new Font("Segoe UI Semibold", 13F);
            lblHeading.ForeColor = Color.FromArgb(24, 41, 74);
            lblHeading.Location = new Point(0, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Padding = new Padding(16, 6, 0, 3);
            lblHeading.Size = new Size(159, 34);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "My applications";
            // 
            // lblSummary
            // 
            lblSummary.Dock = DockStyle.Top;
            lblSummary.ForeColor = Color.FromArgb(105, 115, 130);
            lblSummary.Location = new Point(0, 34);
            lblSummary.Name = "lblSummary";
            lblSummary.Padding = new Padding(16, 3, 0, 0);
            lblSummary.Size = new Size(876, 22);
            lblSummary.TabIndex = 2;
            // 
            // pnlGridHost
            // 
            pnlGridHost.Controls.Add(grid);
            pnlGridHost.Dock = DockStyle.Fill;
            pnlGridHost.Location = new Point(0, 56);
            pnlGridHost.Margin = new Padding(3, 2, 3, 2);
            pnlGridHost.Name = "pnlGridHost";
            pnlGridHost.Padding = new Padding(1);
            pnlGridHost.Size = new Size(876, 364);
            pnlGridHost.TabIndex = 1;
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.Dock = DockStyle.Fill;
            grid.Location = new Point(1, 1);
            grid.Margin = new Padding(3, 2, 3, 2);
            grid.MultiSelect = false;
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new Size(874, 362);
            grid.TabIndex = 0;
            // 
            // MyApplicationsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 245, 249);
            Controls.Add(pnlGridHost);
            Controls.Add(lblSummary);
            Controls.Add(lblHeading);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MyApplicationsControl";
            Size = new Size(876, 420);
            pnlGridHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Panel pnlGridHost;
        private System.Windows.Forms.DataGridView grid;
    }
}
