namespace MaintenanceManagement.UserControls
{
    partial class UC_SelectMaintenanceScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SelectMaintenanceScreen));
            selectMaintenanceGrid = new DataGridView();
            selectMaintenanceButton = new Button();
            goBackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)selectMaintenanceGrid).BeginInit();
            SuspendLayout();
            // 
            // selectMaintenanceGrid
            // 
            selectMaintenanceGrid.BackgroundColor = SystemColors.ButtonFace;
            selectMaintenanceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectMaintenanceGrid.Location = new Point(0, 0);
            selectMaintenanceGrid.Name = "selectMaintenanceGrid";
            selectMaintenanceGrid.RowTemplate.Height = 25;
            selectMaintenanceGrid.Size = new Size(992, 369);
            selectMaintenanceGrid.TabIndex = 0;
            // 
            // selectMaintenanceButton
            // 
            selectMaintenanceButton.BackColor = Color.FromArgb(76, 180, 80);
            selectMaintenanceButton.FlatAppearance.BorderSize = 0;
            selectMaintenanceButton.FlatStyle = FlatStyle.Flat;
            selectMaintenanceButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            selectMaintenanceButton.ForeColor = SystemColors.ActiveCaptionText;
            selectMaintenanceButton.Image = (Image)resources.GetObject("selectMaintenanceButton.Image");
            selectMaintenanceButton.ImageAlign = ContentAlignment.BottomLeft;
            selectMaintenanceButton.Location = new Point(605, 404);
            selectMaintenanceButton.Name = "selectMaintenanceButton";
            selectMaintenanceButton.Padding = new Padding(5, 0, 5, 0);
            selectMaintenanceButton.Size = new Size(131, 40);
            selectMaintenanceButton.TabIndex = 9;
            selectMaintenanceButton.Text = "Bakımı Seç";
            selectMaintenanceButton.TextAlign = ContentAlignment.MiddleRight;
            selectMaintenanceButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            selectMaintenanceButton.UseVisualStyleBackColor = false;
            selectMaintenanceButton.Click += AddUC_CompleteEditMaintenanceScreen;
            // 
            // goBackButton
            // 
            goBackButton.BackColor = Color.Red;
            goBackButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            goBackButton.ForeColor = SystemColors.ActiveCaptionText;
            goBackButton.Image = (Image)resources.GetObject("goBackButton.Image");
            goBackButton.ImageAlign = ContentAlignment.TopLeft;
            goBackButton.Location = new Point(408, 404);
            goBackButton.Name = "goBackButton";
            goBackButton.Padding = new Padding(5, 0, 5, 0);
            goBackButton.Size = new Size(120, 40);
            goBackButton.TabIndex = 30;
            goBackButton.Text = "Geri Dön";
            goBackButton.TextAlign = ContentAlignment.MiddleRight;
            goBackButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            goBackButton.UseVisualStyleBackColor = false;
            goBackButton.Click += GoBackButtonClick;
            // 
            // UC_SelectMaintenanceScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(goBackButton);
            Controls.Add(selectMaintenanceButton);
            Controls.Add(selectMaintenanceGrid);
            Name = "UC_SelectMaintenanceScreen";
            Size = new Size(992, 500);
            ((System.ComponentModel.ISupportInitialize)selectMaintenanceGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView selectMaintenanceGrid;
        private Button selectMaintenanceButton;
        private Button goBackButton;
    }
}
