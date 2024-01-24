namespace MaintenanceManagement.UserControls
{
    partial class UC_UpcomingMaintenances
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_UpcomingMaintenances));
            UpcomingMaintenancesDataGrid = new DataGridView();
            goBackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)UpcomingMaintenancesDataGrid).BeginInit();
            SuspendLayout();
            // 
            // UpcomingMaintenancesDataGrid
            // 
            UpcomingMaintenancesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            UpcomingMaintenancesDataGrid.BackgroundColor = Color.White;
            UpcomingMaintenancesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UpcomingMaintenancesDataGrid.GridColor = SystemColors.Control;
            UpcomingMaintenancesDataGrid.Location = new Point(19, 3);
            UpcomingMaintenancesDataGrid.Name = "UpcomingMaintenancesDataGrid";
            UpcomingMaintenancesDataGrid.RowTemplate.Height = 25;
            UpcomingMaintenancesDataGrid.Size = new Size(953, 443);
            UpcomingMaintenancesDataGrid.TabIndex = 5;
            // 
            // goBackButton
            // 
            goBackButton.BackColor = Color.Red;
            goBackButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            goBackButton.ForeColor = SystemColors.ActiveCaptionText;
            goBackButton.Image = (Image)resources.GetObject("goBackButton.Image");
            goBackButton.ImageAlign = ContentAlignment.TopLeft;
            goBackButton.Location = new Point(426, 452);
            goBackButton.Name = "goBackButton";
            goBackButton.Padding = new Padding(5, 0, 5, 0);
            goBackButton.Size = new Size(120, 40);
            goBackButton.TabIndex = 31;
            goBackButton.Text = "Geri Dön";
            goBackButton.TextAlign = ContentAlignment.MiddleRight;
            goBackButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            goBackButton.UseVisualStyleBackColor = false;
            goBackButton.Click += GoBackButtonClick;
            // 
            // UC_UpcomingMaintenances
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(goBackButton);
            Controls.Add(UpcomingMaintenancesDataGrid);
            Name = "UC_UpcomingMaintenances";
            Size = new Size(992, 500);
            ((System.ComponentModel.ISupportInitialize)UpcomingMaintenancesDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView UpcomingMaintenancesDataGrid;
        private Button goBackButton;
    }
}
