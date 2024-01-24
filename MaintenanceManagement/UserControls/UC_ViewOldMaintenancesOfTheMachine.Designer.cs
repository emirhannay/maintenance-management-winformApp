namespace MaintenanceManagement.UserControls
{
    partial class UC_ViewOldMaintenancesOfTheMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ViewOldMaintenancesOfTheMachine));
            completedMaintenancesGrid = new DataGridView();
            partUsedLabel = new Label();
            dateLabel = new Label();
            goBackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)completedMaintenancesGrid).BeginInit();
            SuspendLayout();
            // 
            // completedMaintenancesGrid
            // 
            completedMaintenancesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            completedMaintenancesGrid.BackgroundColor = Color.White;
            completedMaintenancesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            completedMaintenancesGrid.GridColor = SystemColors.Control;
            completedMaintenancesGrid.Location = new Point(18, 40);
            completedMaintenancesGrid.Name = "completedMaintenancesGrid";
            completedMaintenancesGrid.RowTemplate.Height = 25;
            completedMaintenancesGrid.Size = new Size(953, 411);
            completedMaintenancesGrid.TabIndex = 5;
            // 
            // partUsedLabel
            // 
            partUsedLabel.AutoSize = true;
            partUsedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            partUsedLabel.Location = new Point(375, 9);
            partUsedLabel.Name = "partUsedLabel";
            partUsedLabel.Size = new Size(111, 21);
            partUsedLabel.TabIndex = 31;
            partUsedLabel.Text = "Tarih Aralığı :";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateLabel.Location = new Point(492, 14);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(89, 15);
            dateLabel.TabIndex = 32;
            dateLabel.Text = "NameInfoLabel";
            // 
            // goBackButton
            // 
            goBackButton.BackColor = Color.Red;
            goBackButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            goBackButton.ForeColor = SystemColors.ActiveCaptionText;
            goBackButton.Image = (Image)resources.GetObject("goBackButton.Image");
            goBackButton.ImageAlign = ContentAlignment.TopLeft;
            goBackButton.Location = new Point(413, 457);
            goBackButton.Name = "goBackButton";
            goBackButton.Padding = new Padding(5, 0, 5, 0);
            goBackButton.Size = new Size(120, 40);
            goBackButton.TabIndex = 33;
            goBackButton.Text = "Geri Dön";
            goBackButton.TextAlign = ContentAlignment.MiddleRight;
            goBackButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            goBackButton.UseVisualStyleBackColor = false;
            goBackButton.Click += GoBackButtonClick;
            // 
            // UC_ViewOldMaintenancesOfTheMachine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(goBackButton);
            Controls.Add(dateLabel);
            Controls.Add(partUsedLabel);
            Controls.Add(completedMaintenancesGrid);
            Name = "UC_ViewOldMaintenancesOfTheMachine";
            Size = new Size(992, 500);
            ((System.ComponentModel.ISupportInitialize)completedMaintenancesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView completedMaintenancesGrid;
        private Label partUsedLabel;
        private Label dateLabel;
        private Button goBackButton;
    }
}
