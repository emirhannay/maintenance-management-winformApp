namespace MaintenanceManagement.UserControls
{
    partial class UC_MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MainScreen));
            UserInformationMainPanel = new Bunifu.Framework.UI.BunifuCards();
            RoleInfoLabel = new Label();
            NameInfoLabel = new Label();
            UserRoleLabel = new Label();
            UserPictureBox = new PictureBox();
            NameLabel = new Label();
            UserInformationPanelLabel = new Label();
            CreateFaultNotificationButton = new Button();
            activeFaultNotificationsGrid = new DataGridView();
            panel1 = new Panel();
            gridHeader = new Panel();
            label1 = new Label();
            DeleteFaultNotificationButton = new Button();
            CompleteActiveFaultNotificationButton = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            UserInformationMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activeFaultNotificationsGrid).BeginInit();
            panel1.SuspendLayout();
            gridHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UserInformationMainPanel
            // 
            UserInformationMainPanel.BackColor = Color.WhiteSmoke;
            UserInformationMainPanel.BorderRadius = 30;
            UserInformationMainPanel.BottomSahddow = true;
            UserInformationMainPanel.BottomShadow = true;
            UserInformationMainPanel.color = Color.WhiteSmoke;
            UserInformationMainPanel.Controls.Add(RoleInfoLabel);
            UserInformationMainPanel.Controls.Add(NameInfoLabel);
            UserInformationMainPanel.Controls.Add(UserRoleLabel);
            UserInformationMainPanel.Controls.Add(UserPictureBox);
            UserInformationMainPanel.Controls.Add(NameLabel);
            UserInformationMainPanel.Controls.Add(UserInformationPanelLabel);
            UserInformationMainPanel.IndicatorColor = Color.WhiteSmoke;
            UserInformationMainPanel.LeftSahddow = false;
            UserInformationMainPanel.LeftShadow = false;
            UserInformationMainPanel.Location = new Point(797, 3);
            UserInformationMainPanel.Name = "UserInformationMainPanel";
            UserInformationMainPanel.RightSahddow = true;
            UserInformationMainPanel.RightShadow = true;
            UserInformationMainPanel.ShadowDepth = 30;
            UserInformationMainPanel.Size = new Size(176, 158);
            UserInformationMainPanel.TabIndex = 1;
            // 
            // RoleInfoLabel
            // 
            RoleInfoLabel.AutoSize = true;
            RoleInfoLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RoleInfoLabel.Location = new Point(62, 107);
            RoleInfoLabel.Name = "RoleInfoLabel";
            RoleInfoLabel.Size = new Size(80, 15);
            RoleInfoLabel.TabIndex = 6;
            RoleInfoLabel.Text = "RoleInfoLabel";
            // 
            // NameInfoLabel
            // 
            NameInfoLabel.AutoSize = true;
            NameInfoLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NameInfoLabel.Location = new Point(62, 71);
            NameInfoLabel.Name = "NameInfoLabel";
            NameInfoLabel.Size = new Size(89, 15);
            NameInfoLabel.TabIndex = 5;
            NameInfoLabel.Text = "NameInfoLabel";
            // 
            // UserRoleLabel
            // 
            UserRoleLabel.AutoSize = true;
            UserRoleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UserRoleLabel.Location = new Point(10, 107);
            UserRoleLabel.Name = "UserRoleLabel";
            UserRoleLabel.Size = new Size(34, 15);
            UserRoleLabel.TabIndex = 4;
            UserRoleLabel.Text = "Rol  :";
            // 
            // UserPictureBox
            // 
            UserPictureBox.Image = (Image)resources.GetObject("UserPictureBox.Image");
            UserPictureBox.Location = new Point(8, 6);
            UserPictureBox.Name = "UserPictureBox";
            UserPictureBox.Size = new Size(40, 40);
            UserPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UserPictureBox.TabIndex = 3;
            UserPictureBox.TabStop = false;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(10, 71);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(31, 15);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Ad  :";
            // 
            // UserInformationPanelLabel
            // 
            UserInformationPanelLabel.AutoSize = true;
            UserInformationPanelLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserInformationPanelLabel.Location = new Point(54, 21);
            UserInformationPanelLabel.Name = "UserInformationPanelLabel";
            UserInformationPanelLabel.Size = new Size(103, 17);
            UserInformationPanelLabel.TabIndex = 1;
            UserInformationPanelLabel.Text = "Kullanıcı Bilgisi";
            // 
            // CreateFaultNotificationButton
            // 
            CreateFaultNotificationButton.BackColor = Color.FromArgb(76, 180, 80);
            CreateFaultNotificationButton.FlatAppearance.BorderSize = 0;
            CreateFaultNotificationButton.FlatStyle = FlatStyle.Flat;
            CreateFaultNotificationButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CreateFaultNotificationButton.ForeColor = SystemColors.ActiveCaptionText;
            CreateFaultNotificationButton.Image = (Image)resources.GetObject("CreateFaultNotificationButton.Image");
            CreateFaultNotificationButton.ImageAlign = ContentAlignment.BottomLeft;
            CreateFaultNotificationButton.Location = new Point(557, 407);
            CreateFaultNotificationButton.Name = "CreateFaultNotificationButton";
            CreateFaultNotificationButton.Padding = new Padding(5, 0, 5, 0);
            CreateFaultNotificationButton.Size = new Size(205, 40);
            CreateFaultNotificationButton.TabIndex = 6;
            CreateFaultNotificationButton.Text = "Arıza Bildirimi Oluştur";
            CreateFaultNotificationButton.TextAlign = ContentAlignment.MiddleRight;
            CreateFaultNotificationButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CreateFaultNotificationButton.UseVisualStyleBackColor = false;
            CreateFaultNotificationButton.Click += CreateFaultNotificationClick;
            // 
            // activeFaultNotificationsGrid
            // 
            activeFaultNotificationsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            activeFaultNotificationsGrid.BackgroundColor = Color.White;
            activeFaultNotificationsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            activeFaultNotificationsGrid.GridColor = SystemColors.Control;
            activeFaultNotificationsGrid.Location = new Point(0, 64);
            activeFaultNotificationsGrid.Name = "activeFaultNotificationsGrid";
            activeFaultNotificationsGrid.RowTemplate.Height = 25;
            activeFaultNotificationsGrid.Size = new Size(774, 334);
            activeFaultNotificationsGrid.TabIndex = 2;
            activeFaultNotificationsGrid.CellContentClick += activeFaultNotificationsGrid_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(gridHeader);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 66);
            panel1.TabIndex = 3;
            // 
            // gridHeader
            // 
            gridHeader.BorderStyle = BorderStyle.FixedSingle;
            gridHeader.Controls.Add(label1);
            gridHeader.Location = new Point(0, -2);
            gridHeader.Name = "gridHeader";
            gridHeader.Size = new Size(774, 66);
            gridHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(300, 23);
            label1.Name = "label1";
            label1.Size = new Size(241, 21);
            label1.TabIndex = 0;
            label1.Text = "Aktif Makina Arıza Bildirimleri";
            // 
            // DeleteFaultNotificationButton
            // 
            DeleteFaultNotificationButton.BackColor = Color.FromArgb(235, 52, 66);
            DeleteFaultNotificationButton.FlatAppearance.BorderSize = 0;
            DeleteFaultNotificationButton.FlatStyle = FlatStyle.Flat;
            DeleteFaultNotificationButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteFaultNotificationButton.ForeColor = SystemColors.ActiveCaptionText;
            DeleteFaultNotificationButton.Image = (Image)resources.GetObject("DeleteFaultNotificationButton.Image");
            DeleteFaultNotificationButton.ImageAlign = ContentAlignment.BottomLeft;
            DeleteFaultNotificationButton.Location = new Point(292, 407);
            DeleteFaultNotificationButton.Name = "DeleteFaultNotificationButton";
            DeleteFaultNotificationButton.Padding = new Padding(5, 0, 5, 0);
            DeleteFaultNotificationButton.Size = new Size(232, 40);
            DeleteFaultNotificationButton.TabIndex = 7;
            DeleteFaultNotificationButton.Text = "Seçilen Arıza Bildirimini Sil";
            DeleteFaultNotificationButton.TextAlign = ContentAlignment.MiddleRight;
            DeleteFaultNotificationButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteFaultNotificationButton.UseVisualStyleBackColor = false;
            DeleteFaultNotificationButton.Click += DeleteFaultNotificationButton_Click;
            // 
            // CompleteActiveFaultNotificationButton
            // 
            CompleteActiveFaultNotificationButton.BackColor = Color.FromArgb(76, 180, 80);
            CompleteActiveFaultNotificationButton.FlatAppearance.BorderSize = 0;
            CompleteActiveFaultNotificationButton.FlatStyle = FlatStyle.Flat;
            CompleteActiveFaultNotificationButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CompleteActiveFaultNotificationButton.ForeColor = SystemColors.ActiveCaptionText;
            CompleteActiveFaultNotificationButton.Image = (Image)resources.GetObject("CompleteActiveFaultNotificationButton.Image");
            CompleteActiveFaultNotificationButton.ImageAlign = ContentAlignment.BottomLeft;
            CompleteActiveFaultNotificationButton.Location = new Point(557, 407);
            CompleteActiveFaultNotificationButton.Name = "CompleteActiveFaultNotificationButton";
            CompleteActiveFaultNotificationButton.Padding = new Padding(5, 0, 5, 0);
            CompleteActiveFaultNotificationButton.Size = new Size(234, 40);
            CompleteActiveFaultNotificationButton.TabIndex = 8;
            CompleteActiveFaultNotificationButton.Text = "Tamamlandı Olarak İşaretle";
            CompleteActiveFaultNotificationButton.TextAlign = ContentAlignment.MiddleRight;
            CompleteActiveFaultNotificationButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CompleteActiveFaultNotificationButton.UseVisualStyleBackColor = false;
            CompleteActiveFaultNotificationButton.Visible = false;
            CompleteActiveFaultNotificationButton.Click += AddUC_CompleteActiveFaultNotificationScreen;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(854, 471);
            label4.Name = "label4";
            label4.Size = new Size(109, 13);
            label4.TabIndex = 79;
            label4.Text = "almak için tıklayınız.";
            label4.Click += ShowMessageBox;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(851, 407);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 78;
            pictureBox1.TabStop = false;
            pictureBox1.Click += ShowMessageBox;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(848, 458);
            label2.Name = "label2";
            label2.Size = new Size(123, 13);
            label2.TabIndex = 77;
            label2.Text = "*Arayüz hakkında bilgi";
            label2.Click += ShowMessageBox;
            // 
            // UC_MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(CompleteActiveFaultNotificationButton);
            Controls.Add(DeleteFaultNotificationButton);
            Controls.Add(panel1);
            Controls.Add(activeFaultNotificationsGrid);
            Controls.Add(UserInformationMainPanel);
            Controls.Add(CreateFaultNotificationButton);
            Name = "UC_MainScreen";
            Size = new Size(992, 500);
            UserInformationMainPanel.ResumeLayout(false);
            UserInformationMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)activeFaultNotificationsGrid).EndInit();
            panel1.ResumeLayout(false);
            gridHeader.ResumeLayout(false);
            gridHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards UserInformationMainPanel;
        private Label RoleInfoLabel;
        private Label NameInfoLabel;
        private Label UserRoleLabel;
        private PictureBox UserPictureBox;
        private Label NameLabel;
        private Label UserInformationPanelLabel;
        private DataGridView activeFaultNotificationsGrid;
        private Panel panel1;
        private Panel gridHeader;
        private Label label1;
        private Button CreateFaultNotificationButton;
        private Button DeleteFaultNotificationButton;
        private Button CompleteActiveFaultNotificationButton;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
