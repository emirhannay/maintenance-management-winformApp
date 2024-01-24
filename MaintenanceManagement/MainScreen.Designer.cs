namespace MaintenanceManagement
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel2 = new Panel();
            button3 = new Button();
            label2 = new Label();
            panel3 = new Panel();
            MaintenanceMenuButton = new Button();
            FaultNotificationsMenuButton = new Button();
            faultNotificationMenuButton = new Button();
            panel4 = new Panel();
            menuLabel = new Label();
            panel5 = new Panel();
            mainLabel = new Label();
            mainPanel = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1152, 41);
            panel2.TabIndex = 14;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Dock = DockStyle.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1112, 0);
            button3.Name = "button3";
            button3.Size = new Size(40, 41);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = false;
            button3.Click += closeAppClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(130, 132, 133);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(114, 14);
            label2.TabIndex = 8;
            label2.Text = "DTC Technologies";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(50, 52, 77);
            panel3.Controls.Add(MaintenanceMenuButton);
            panel3.Controls.Add(FaultNotificationsMenuButton);
            panel3.Controls.Add(faultNotificationMenuButton);
            panel3.Location = new Point(-2, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(162, 499);
            panel3.TabIndex = 15;
            // 
            // MaintenanceMenuButton
            // 
            MaintenanceMenuButton.Dock = DockStyle.Top;
            MaintenanceMenuButton.FlatAppearance.BorderSize = 0;
            MaintenanceMenuButton.FlatStyle = FlatStyle.Flat;
            MaintenanceMenuButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaintenanceMenuButton.ForeColor = SystemColors.ButtonFace;
            MaintenanceMenuButton.Image = (Image)resources.GetObject("MaintenanceMenuButton.Image");
            MaintenanceMenuButton.ImageAlign = ContentAlignment.BottomLeft;
            MaintenanceMenuButton.Location = new Point(0, 80);
            MaintenanceMenuButton.Name = "MaintenanceMenuButton";
            MaintenanceMenuButton.Padding = new Padding(5, 0, 5, 0);
            MaintenanceMenuButton.Size = new Size(162, 40);
            MaintenanceMenuButton.TabIndex = 3;
            MaintenanceMenuButton.Text = "Maintenance";
            MaintenanceMenuButton.TextAlign = ContentAlignment.MiddleRight;
            MaintenanceMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            MaintenanceMenuButton.UseVisualStyleBackColor = true;
            MaintenanceMenuButton.Click += AddUC_MaintenanceMainScreen;
            // 
            // FaultNotificationsMenuButton
            // 
            FaultNotificationsMenuButton.Dock = DockStyle.Top;
            FaultNotificationsMenuButton.FlatAppearance.BorderSize = 0;
            FaultNotificationsMenuButton.FlatStyle = FlatStyle.Flat;
            FaultNotificationsMenuButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FaultNotificationsMenuButton.ForeColor = SystemColors.ButtonFace;
            FaultNotificationsMenuButton.Image = (Image)resources.GetObject("FaultNotificationsMenuButton.Image");
            FaultNotificationsMenuButton.ImageAlign = ContentAlignment.BottomLeft;
            FaultNotificationsMenuButton.Location = new Point(0, 40);
            FaultNotificationsMenuButton.Name = "FaultNotificationsMenuButton";
            FaultNotificationsMenuButton.Padding = new Padding(5, 0, 5, 0);
            FaultNotificationsMenuButton.Size = new Size(162, 40);
            FaultNotificationsMenuButton.TabIndex = 2;
            FaultNotificationsMenuButton.Text = "All Machine Faults";
            FaultNotificationsMenuButton.TextAlign = ContentAlignment.MiddleRight;
            FaultNotificationsMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            FaultNotificationsMenuButton.UseVisualStyleBackColor = true;
            FaultNotificationsMenuButton.Visible = false;
            FaultNotificationsMenuButton.Click += AddUC_AllFaultNotificationsScreen;
            // 
            // faultNotificationMenuButton
            // 
            faultNotificationMenuButton.Dock = DockStyle.Top;
            faultNotificationMenuButton.FlatAppearance.BorderSize = 0;
            faultNotificationMenuButton.FlatStyle = FlatStyle.Flat;
            faultNotificationMenuButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            faultNotificationMenuButton.ForeColor = SystemColors.ButtonFace;
            faultNotificationMenuButton.Image = (Image)resources.GetObject("faultNotificationMenuButton.Image");
            faultNotificationMenuButton.ImageAlign = ContentAlignment.BottomLeft;
            faultNotificationMenuButton.Location = new Point(0, 0);
            faultNotificationMenuButton.Name = "faultNotificationMenuButton";
            faultNotificationMenuButton.Padding = new Padding(5, 0, 5, 0);
            faultNotificationMenuButton.Size = new Size(162, 40);
            faultNotificationMenuButton.TabIndex = 1;
            faultNotificationMenuButton.Text = "Main Menu";
            faultNotificationMenuButton.TextAlign = ContentAlignment.MiddleRight;
            faultNotificationMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            faultNotificationMenuButton.UseVisualStyleBackColor = true;
            faultNotificationMenuButton.Click += MainMenuButtonClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(39, 38, 60);
            panel4.Controls.Add(menuLabel);
            panel4.Location = new Point(0, 41);
            panel4.Name = "panel4";
            panel4.Size = new Size(162, 50);
            panel4.TabIndex = 18;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuLabel.ForeColor = SystemColors.ButtonFace;
            menuLabel.Location = new Point(49, 16);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(45, 17);
            menuLabel.TabIndex = 0;
            menuLabel.Text = "Menü";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 135, 137);
            panel5.Controls.Add(mainLabel);
            panel5.Location = new Point(160, 41);
            panel5.Name = "panel5";
            panel5.Size = new Size(992, 50);
            panel5.TabIndex = 19;
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            mainLabel.Location = new Point(418, 12);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(66, 26);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "Home";
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.Location = new Point(160, 88);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(992, 500);
            mainPanel.TabIndex = 20;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 588);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainScreen";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Button button3;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Label menuLabel;
        private Button faultNotificationButton;
        private Button button4;
        private Button faultNotificationMenuButton;
        private Panel panel5;
        private Button FaultNotificationsMenuButton;
        private Panel mainPanel;
        private Button MaintenanceMenuButton;
        private Label mainLabel;
    }
}