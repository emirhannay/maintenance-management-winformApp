namespace MaintenanceManagement
{
    partial class RegisterScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterScreen));
            panel7 = new Panel();
            logoPicture = new PictureBox();
            panel2 = new Panel();
            button3 = new Button();
            label1 = new Label();
            formIcon = new PictureBox();
            panel1 = new Panel();
            panel12 = new Panel();
            MaintenanceTypePanel = new Panel();
            maintenanceTypeComboBox = new ComboBox();
            panel11 = new Panel();
            maintenanceTypePicBox = new PictureBox();
            maintenanceTypeLabel = new Label();
            registerButton = new Button();
            goBackPictureBox = new PictureBox();
            panel8 = new Panel();
            typeComboBox = new ComboBox();
            panel9 = new Panel();
            pictureBox2 = new PictureBox();
            TypeLabel = new Label();
            panel5 = new Panel();
            usernameMessageBox = new PictureBox();
            panel6 = new Panel();
            usernameLabel = new Label();
            usernameBox = new TextBox();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            passwordMessageBox = new PictureBox();
            passwordBoxPanel = new Panel();
            passwordIcon = new PictureBox();
            passwordLabel = new Label();
            passwordBox = new TextBox();
            panel3 = new Panel();
            usernameUnderLabel = new Panel();
            nameLabel = new Label();
            nameBox = new TextBox();
            usernameIcon = new PictureBox();
            notifyIcon1 = new NotifyIcon(components);
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPicture).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)formIcon).BeginInit();
            panel1.SuspendLayout();
            panel12.SuspendLayout();
            MaintenanceTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maintenanceTypePicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goBackPictureBox).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usernameMessageBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordMessageBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usernameIcon).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 70, 165);
            panel7.Controls.Add(logoPicture);
            panel7.Location = new Point(0, 41);
            panel7.Name = "panel7";
            panel7.Size = new Size(445, 547);
            panel7.TabIndex = 12;
            // 
            // logoPicture
            // 
            logoPicture.BackColor = Color.FromArgb(0, 70, 165);
            logoPicture.Image = (Image)resources.GetObject("logoPicture.Image");
            logoPicture.Location = new Point(104, 164);
            logoPicture.Name = "logoPicture";
            logoPicture.Size = new Size(200, 200);
            logoPicture.TabIndex = 0;
            logoPicture.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1152, 41);
            panel2.TabIndex = 13;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(130, 132, 133);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 14);
            label1.TabIndex = 8;
            label1.Text = "DTC Technologies";
            // 
            // formIcon
            // 
            formIcon.Image = (Image)resources.GetObject("formIcon.Image");
            formIcon.Location = new Point(387, 100);
            formIcon.Name = "formIcon";
            formIcon.Size = new Size(50, 50);
            formIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            formIcon.TabIndex = 9;
            formIcon.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(goBackPictureBox);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(formIcon);
            panel1.Location = new Point(443, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 547);
            panel1.TabIndex = 14;
            // 
            // panel12
            // 
            panel12.Controls.Add(MaintenanceTypePanel);
            panel12.Controls.Add(registerButton);
            panel12.Location = new Point(143, 346);
            panel12.Name = "panel12";
            panel12.Size = new Size(458, 92);
            panel12.TabIndex = 14;
            // 
            // MaintenanceTypePanel
            // 
            MaintenanceTypePanel.Controls.Add(maintenanceTypeComboBox);
            MaintenanceTypePanel.Controls.Add(panel11);
            MaintenanceTypePanel.Controls.Add(maintenanceTypePicBox);
            MaintenanceTypePanel.Controls.Add(maintenanceTypeLabel);
            MaintenanceTypePanel.Dock = DockStyle.Top;
            MaintenanceTypePanel.Location = new Point(0, 0);
            MaintenanceTypePanel.Name = "MaintenanceTypePanel";
            MaintenanceTypePanel.Size = new Size(458, 43);
            MaintenanceTypePanel.TabIndex = 13;
            // 
            // maintenanceTypeComboBox
            // 
            maintenanceTypeComboBox.FormattingEnabled = true;
            maintenanceTypeComboBox.Location = new Point(137, 11);
            maintenanceTypeComboBox.Name = "maintenanceTypeComboBox";
            maintenanceTypeComboBox.Size = new Size(290, 23);
            maintenanceTypeComboBox.TabIndex = 12;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(0, 70, 165);
            panel11.Location = new Point(137, 36);
            panel11.Name = "panel11";
            panel11.Size = new Size(290, 1);
            panel11.TabIndex = 2;
            // 
            // maintenanceTypePicBox
            // 
            maintenanceTypePicBox.Image = (Image)resources.GetObject("maintenanceTypePicBox.Image");
            maintenanceTypePicBox.Location = new Point(0, 7);
            maintenanceTypePicBox.Name = "maintenanceTypePicBox";
            maintenanceTypePicBox.Size = new Size(30, 30);
            maintenanceTypePicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            maintenanceTypePicBox.TabIndex = 0;
            maintenanceTypePicBox.TabStop = false;
            // 
            // maintenanceTypeLabel
            // 
            maintenanceTypeLabel.AutoSize = true;
            maintenanceTypeLabel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            maintenanceTypeLabel.Location = new Point(39, 13);
            maintenanceTypeLabel.Name = "maintenanceTypeLabel";
            maintenanceTypeLabel.Size = new Size(84, 16);
            maintenanceTypeLabel.TabIndex = 3;
            maintenanceTypeLabel.Text = "Bakımcı Tipi";
            // 
            // registerButton
            // 
            registerButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            registerButton.BackColor = Color.White;
            registerButton.BackgroundImageLayout = ImageLayout.None;
            registerButton.Enabled = false;
            registerButton.Location = new Point(255, 49);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(75, 23);
            registerButton.TabIndex = 12;
            registerButton.Text = "Kayıt Ol";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerClick;
            // 
            // goBackPictureBox
            // 
            goBackPictureBox.BackColor = Color.AliceBlue;
            goBackPictureBox.Image = (Image)resources.GetObject("goBackPictureBox.Image");
            goBackPictureBox.Location = new Point(8, 6);
            goBackPictureBox.Name = "goBackPictureBox";
            goBackPictureBox.Size = new Size(40, 40);
            goBackPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            goBackPictureBox.TabIndex = 11;
            goBackPictureBox.TabStop = false;
            goBackPictureBox.Click += goBackClick;
            // 
            // panel8
            // 
            panel8.Controls.Add(typeComboBox);
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(pictureBox2);
            panel8.Controls.Add(TypeLabel);
            panel8.Location = new Point(143, 303);
            panel8.Name = "panel8";
            panel8.Size = new Size(458, 43);
            panel8.TabIndex = 8;
            // 
            // typeComboBox
            // 
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Location = new Point(137, 11);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(290, 23);
            typeComboBox.TabIndex = 12;
            typeComboBox.SelectedIndexChanged += typeComboBox_SelectedIndexChanged;
            typeComboBox.ValueMemberChanged += typeComboBox_SelectedIndexChanged;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(0, 70, 165);
            panel9.Location = new Point(137, 36);
            panel9.Name = "panel9";
            panel9.Size = new Size(290, 1);
            panel9.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TypeLabel.Location = new Point(39, 13);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(89, 16);
            TypeLabel.TabIndex = 3;
            TypeLabel.Text = "Kullanıcı Tipi";
            // 
            // panel5
            // 
            panel5.Controls.Add(usernameMessageBox);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(usernameLabel);
            panel5.Controls.Add(usernameBox);
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new Point(143, 205);
            panel5.Name = "panel5";
            panel5.Size = new Size(458, 43);
            panel5.TabIndex = 11;
            // 
            // usernameMessageBox
            // 
            usernameMessageBox.Image = (Image)resources.GetObject("usernameMessageBox.Image");
            usernameMessageBox.Location = new Point(427, 3);
            usernameMessageBox.Name = "usernameMessageBox";
            usernameMessageBox.Size = new Size(32, 32);
            usernameMessageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            usernameMessageBox.TabIndex = 16;
            usernameMessageBox.TabStop = false;
            usernameMessageBox.Click += usernameMessageBox_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 70, 165);
            panel6.Location = new Point(137, 36);
            panel6.Name = "panel6";
            panel6.Size = new Size(290, 1);
            panel6.TabIndex = 2;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(39, 13);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(86, 16);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Kullanıcı Adı";
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(137, 11);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(290, 23);
            usernameBox.TabIndex = 2;
            usernameBox.TextChanged += EnableRegisterButtonAccordingToUserFormInput;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(passwordMessageBox);
            panel4.Controls.Add(passwordBoxPanel);
            panel4.Controls.Add(passwordIcon);
            panel4.Controls.Add(passwordLabel);
            panel4.Controls.Add(passwordBox);
            panel4.Location = new Point(143, 254);
            panel4.Name = "panel4";
            panel4.Size = new Size(458, 43);
            panel4.TabIndex = 7;
            // 
            // passwordMessageBox
            // 
            passwordMessageBox.Image = (Image)resources.GetObject("passwordMessageBox.Image");
            passwordMessageBox.Location = new Point(427, 5);
            passwordMessageBox.Name = "passwordMessageBox";
            passwordMessageBox.Size = new Size(32, 32);
            passwordMessageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordMessageBox.TabIndex = 17;
            passwordMessageBox.TabStop = false;
            passwordMessageBox.Click += passwordMessageBox_Click;
            // 
            // passwordBoxPanel
            // 
            passwordBoxPanel.BackColor = Color.FromArgb(0, 70, 165);
            passwordBoxPanel.Location = new Point(137, 36);
            passwordBoxPanel.Name = "passwordBoxPanel";
            passwordBoxPanel.Size = new Size(290, 1);
            passwordBoxPanel.TabIndex = 2;
            // 
            // passwordIcon
            // 
            passwordIcon.Image = (Image)resources.GetObject("passwordIcon.Image");
            passwordIcon.Location = new Point(0, 7);
            passwordIcon.Name = "passwordIcon";
            passwordIcon.Size = new Size(30, 30);
            passwordIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordIcon.TabIndex = 0;
            passwordIcon.TabStop = false;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(39, 13);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(37, 16);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Şifre";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(137, 11);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(290, 23);
            passwordBox.TabIndex = 2;
            passwordBox.TextChanged += EnableRegisterButtonAccordingToUserFormInput;
            // 
            // panel3
            // 
            panel3.Controls.Add(usernameUnderLabel);
            panel3.Controls.Add(nameLabel);
            panel3.Controls.Add(nameBox);
            panel3.Controls.Add(usernameIcon);
            panel3.Location = new Point(143, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(458, 43);
            panel3.TabIndex = 10;
            // 
            // usernameUnderLabel
            // 
            usernameUnderLabel.BackColor = Color.FromArgb(0, 70, 165);
            usernameUnderLabel.Location = new Point(137, 36);
            usernameUnderLabel.Name = "usernameUnderLabel";
            usernameUnderLabel.Size = new Size(290, 1);
            usernameUnderLabel.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(39, 13);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(65, 16);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Ad Soyad";
            nameLabel.Click += usernameLabel_Click;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(137, 11);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(290, 23);
            nameBox.TabIndex = 2;
            nameBox.TextChanged += EnableRegisterButtonAccordingToUserFormInput;
            // 
            // usernameIcon
            // 
            usernameIcon.Image = (Image)resources.GetObject("usernameIcon.Image");
            usernameIcon.Location = new Point(3, 5);
            usernameIcon.Name = "usernameIcon";
            usernameIcon.Size = new Size(30, 30);
            usernameIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            usernameIcon.TabIndex = 0;
            usernameIcon.TabStop = false;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // RegisterScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1152, 588);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterScreen";
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPicture).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)formIcon).EndInit();
            panel1.ResumeLayout(false);
            panel12.ResumeLayout(false);
            MaintenanceTypePanel.ResumeLayout(false);
            MaintenanceTypePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maintenanceTypePicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)goBackPictureBox).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usernameMessageBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordMessageBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usernameIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private PictureBox logoPicture;
        private Panel panel2;
        private Button button3;
        private Label label1;
        private PictureBox formIcon;
        private Panel panel1;
        private Panel panel3;
        private Panel usernameUnderLabel;
        private Label nameLabel;
        private TextBox nameBox;
        private PictureBox usernameIcon;
        private Panel panel4;
        private Panel passwordBoxPanel;
        private PictureBox passwordIcon;
        private Label passwordLabel;
        private TextBox passwordBox;
        private Panel panel5;
        private Panel panel6;
        private Label usernameLabel;
        private TextBox usernameBox;
        private PictureBox pictureBox1;
        private Panel panel8;
        private Panel panel9;
        private PictureBox pictureBox2;
        private Label TypeLabel;
        private ComboBox typeComboBox;
        private Button registerButton;
        private PictureBox goBackPictureBox;
        private Panel panel12;
        private Panel MaintenanceTypePanel;
        private ComboBox maintenanceTypeComboBox;
        private Panel panel11;
        private PictureBox maintenanceTypePicBox;
        private Label maintenanceTypeLabel;
        private NotifyIcon notifyIcon1;
        private PictureBox usernameMessageBox;
        private PictureBox passwordMessageBox;
    }
}