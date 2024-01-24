namespace MaintenanceManagement.UserControls
{
    partial class UC_MaintenanceMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MaintenanceMainScreen));
            upcomingMaintenanceButton = new Button();
            pastMaintenanceButton = new Button();
            pastMachineFaultButton = new Button();
            newMaintenanceButton = new Button();
            completeMaintenanceButton = new Button();
            SuspendLayout();
            // 
            // upcomingMaintenanceButton
            // 
            upcomingMaintenanceButton.BackColor = Color.FromArgb(197, 255, 248);
            upcomingMaintenanceButton.FlatStyle = FlatStyle.Flat;
            upcomingMaintenanceButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            upcomingMaintenanceButton.ForeColor = Color.Black;
            upcomingMaintenanceButton.Image = (Image)resources.GetObject("upcomingMaintenanceButton.Image");
            upcomingMaintenanceButton.ImageAlign = ContentAlignment.BottomLeft;
            upcomingMaintenanceButton.Location = new Point(363, 108);
            upcomingMaintenanceButton.Name = "upcomingMaintenanceButton";
            upcomingMaintenanceButton.Padding = new Padding(5, 0, 5, 0);
            upcomingMaintenanceButton.Size = new Size(267, 45);
            upcomingMaintenanceButton.TabIndex = 2;
            upcomingMaintenanceButton.Text = "Yaklaşan Bakımlar";
            upcomingMaintenanceButton.TextAlign = ContentAlignment.MiddleRight;
            upcomingMaintenanceButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            upcomingMaintenanceButton.UseVisualStyleBackColor = false;
            upcomingMaintenanceButton.Click += AddUC_UpcomingMaintenanceScreen;
            // 
            // pastMaintenanceButton
            // 
            pastMaintenanceButton.BackColor = Color.FromArgb(150, 239, 255);
            pastMaintenanceButton.FlatStyle = FlatStyle.Flat;
            pastMaintenanceButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pastMaintenanceButton.ForeColor = Color.Black;
            pastMaintenanceButton.Image = (Image)resources.GetObject("pastMaintenanceButton.Image");
            pastMaintenanceButton.ImageAlign = ContentAlignment.BottomLeft;
            pastMaintenanceButton.Location = new Point(363, 214);
            pastMaintenanceButton.Name = "pastMaintenanceButton";
            pastMaintenanceButton.Padding = new Padding(5, 0, 5, 0);
            pastMaintenanceButton.Size = new Size(267, 45);
            pastMaintenanceButton.TabIndex = 3;
            pastMaintenanceButton.Text = "Makinaların Geçmişe Dönük Bakımları";
            pastMaintenanceButton.TextAlign = ContentAlignment.MiddleRight;
            pastMaintenanceButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            pastMaintenanceButton.UseVisualStyleBackColor = false;
            pastMaintenanceButton.Click += AddUC_SelectMachineForViewOldMaintenancesScreen;
            // 
            // pastMachineFaultButton
            // 
            pastMachineFaultButton.BackColor = Color.Lavender;
            pastMachineFaultButton.FlatStyle = FlatStyle.Flat;
            pastMachineFaultButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pastMachineFaultButton.ForeColor = Color.Black;
            pastMachineFaultButton.Image = (Image)resources.GetObject("pastMachineFaultButton.Image");
            pastMachineFaultButton.ImageAlign = ContentAlignment.BottomLeft;
            pastMachineFaultButton.Location = new Point(363, 268);
            pastMachineFaultButton.Name = "pastMachineFaultButton";
            pastMachineFaultButton.Padding = new Padding(5, 0, 5, 0);
            pastMachineFaultButton.Size = new Size(267, 45);
            pastMachineFaultButton.TabIndex = 4;
            pastMachineFaultButton.Text = "Makinaların Geçmişe Dönük Arızaları";
            pastMachineFaultButton.TextAlign = ContentAlignment.MiddleRight;
            pastMachineFaultButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            pastMachineFaultButton.UseVisualStyleBackColor = false;
            pastMachineFaultButton.Click += AddUC_SelectMachineForViewOldMachineFaultsScreen;
            // 
            // newMaintenanceButton
            // 
            newMaintenanceButton.BackColor = Color.Snow;
            newMaintenanceButton.FlatStyle = FlatStyle.Flat;
            newMaintenanceButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            newMaintenanceButton.ForeColor = Color.Black;
            newMaintenanceButton.Image = (Image)resources.GetObject("newMaintenanceButton.Image");
            newMaintenanceButton.ImageAlign = ContentAlignment.BottomLeft;
            newMaintenanceButton.Location = new Point(363, 53);
            newMaintenanceButton.Name = "newMaintenanceButton";
            newMaintenanceButton.Padding = new Padding(5, 0, 5, 0);
            newMaintenanceButton.Size = new Size(267, 45);
            newMaintenanceButton.TabIndex = 5;
            newMaintenanceButton.Text = "Yeni Bakım Oluştur";
            newMaintenanceButton.TextAlign = ContentAlignment.MiddleRight;
            newMaintenanceButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            newMaintenanceButton.UseVisualStyleBackColor = false;
            newMaintenanceButton.Click += AddUC_AddMaintenanceScreen;
            // 
            // completeMaintenanceButton
            // 
            completeMaintenanceButton.BackColor = Color.FromArgb(192, 255, 192);
            completeMaintenanceButton.FlatStyle = FlatStyle.Flat;
            completeMaintenanceButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            completeMaintenanceButton.ForeColor = Color.Black;
            completeMaintenanceButton.Image = (Image)resources.GetObject("completeMaintenanceButton.Image");
            completeMaintenanceButton.ImageAlign = ContentAlignment.BottomLeft;
            completeMaintenanceButton.Location = new Point(363, 162);
            completeMaintenanceButton.Name = "completeMaintenanceButton";
            completeMaintenanceButton.Padding = new Padding(5, 0, 5, 0);
            completeMaintenanceButton.Size = new Size(267, 45);
            completeMaintenanceButton.TabIndex = 6;
            completeMaintenanceButton.Text = "Bakımı Tamamla / Değiştir";
            completeMaintenanceButton.TextAlign = ContentAlignment.MiddleRight;
            completeMaintenanceButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            completeMaintenanceButton.UseVisualStyleBackColor = false;
            completeMaintenanceButton.Click += AddUC_SelectMaintenanceScreen;
            // 
            // UC_MaintenanceMainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(completeMaintenanceButton);
            Controls.Add(newMaintenanceButton);
            Controls.Add(pastMachineFaultButton);
            Controls.Add(pastMaintenanceButton);
            Controls.Add(upcomingMaintenanceButton);
            Name = "UC_MaintenanceMainScreen";
            Size = new Size(992, 500);
            Load += UC_MaintenanceMainScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button upcomingMaintenanceButton;
        private Button pastMaintenanceButton;
        private Button pastMachineFaultButton;
        private Button newMaintenanceButton;
        private Button completeMaintenanceButton;
    }
}
