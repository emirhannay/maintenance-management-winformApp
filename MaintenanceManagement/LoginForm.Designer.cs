namespace MaintenanceManagement
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            ımageList1 = new ImageList(components);
            label1 = new Label();
            button3 = new Button();
            panel2 = new Panel();
            panel7 = new Panel();
            logoPicture = new PictureBox();
            panel1 = new Panel();
            registerLabel = new Label();
            loginButton = new Button();
            panel4 = new Panel();
            passwordBoxPanel = new Panel();
            passwordIcon = new PictureBox();
            passwordLabel = new Label();
            passwordBox = new TextBox();
            bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            formIcon = new PictureBox();
            panel3 = new Panel();
            usernameUnderLabel = new Panel();
            usernameLabel = new Label();
            usernameBox = new TextBox();
            usernameIcon = new PictureBox();
            bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPicture).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)formIcon).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usernameIcon).BeginInit();
            bunifuCards1.SuspendLayout();
            SuspendLayout();
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageSize = new Size(16, 16);
            ımageList1.TransparentColor = Color.Transparent;
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1152, 41);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 70, 165);
            panel7.Controls.Add(logoPicture);
            panel7.Location = new Point(0, 41);
            panel7.Name = "panel7";
            panel7.Size = new Size(445, 547);
            panel7.TabIndex = 11;
            // 
            // logoPicture
            // 
            logoPicture.BackColor = Color.FromArgb(0, 70, 165);
            logoPicture.Image = (Image)resources.GetObject("logoPicture.Image");
            logoPicture.Location = new Point(108, 161);
            logoPicture.Name = "logoPicture";
            logoPicture.Size = new Size(200, 221);
            logoPicture.TabIndex = 0;
            logoPicture.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(registerLabel);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(formIcon);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(444, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 547);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Location = new Point(204, 330);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(162, 15);
            registerLabel.TabIndex = 9;
            registerLabel.Text = "Hesabınız yok mu? Kayıt olun";
            registerLabel.Click += openRegisterScreenClick;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.White;
            loginButton.BackgroundImageLayout = ImageLayout.None;
            loginButton.Enabled = false;
            loginButton.Location = new Point(387, 326);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 7;
            loginButton.Text = "Giriş Yap";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(passwordBoxPanel);
            panel4.Controls.Add(passwordIcon);
            panel4.Controls.Add(passwordLabel);
            panel4.Controls.Add(passwordBox);
            panel4.Controls.Add(bunifuCards3);
            panel4.Location = new Point(143, 277);
            panel4.Name = "panel4";
            panel4.Size = new Size(458, 43);
            panel4.TabIndex = 6;
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
            passwordIcon.Location = new Point(0, 5);
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
            passwordLabel.Location = new Point(39, 11);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(37, 16);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Şifre";
            passwordLabel.Click += label2_Click;
            // 
            // passwordBox
            // 
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Location = new Point(137, 11);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(290, 16);
            passwordBox.TabIndex = 2;
            passwordBox.TextChanged += passwordValueChanged;
            // 
            // bunifuCards3
            // 
            bunifuCards3.BackColor = SystemColors.Window;
            bunifuCards3.BorderRadius = 25;
            bunifuCards3.BottomSahddow = true;
            bunifuCards3.BottomShadow = true;
            bunifuCards3.color = SystemColors.Window;
            bunifuCards3.IndicatorColor = SystemColors.Window;
            bunifuCards3.LeftSahddow = false;
            bunifuCards3.LeftShadow = false;
            bunifuCards3.Location = new Point(129, 7);
            bunifuCards3.Name = "bunifuCards3";
            bunifuCards3.RightSahddow = true;
            bunifuCards3.RightShadow = true;
            bunifuCards3.ShadowDepth = 20;
            bunifuCards3.Size = new Size(306, 30);
            bunifuCards3.TabIndex = 12;
            // 
            // formIcon
            // 
            formIcon.Image = (Image)resources.GetObject("formIcon.Image");
            formIcon.Location = new Point(387, 161);
            formIcon.Name = "formIcon";
            formIcon.Size = new Size(50, 50);
            formIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            formIcon.TabIndex = 5;
            formIcon.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(usernameUnderLabel);
            panel3.Controls.Add(usernameLabel);
            panel3.Controls.Add(usernameBox);
            panel3.Controls.Add(usernameIcon);
            panel3.Controls.Add(bunifuCards1);
            panel3.Location = new Point(143, 217);
            panel3.Name = "panel3";
            panel3.Size = new Size(458, 43);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint_1;
            // 
            // usernameUnderLabel
            // 
            usernameUnderLabel.BackColor = Color.FromArgb(0, 70, 165);
            usernameUnderLabel.Location = new Point(137, 36);
            usernameUnderLabel.Name = "usernameUnderLabel";
            usernameUnderLabel.Size = new Size(290, 1);
            usernameUnderLabel.TabIndex = 2;
            usernameUnderLabel.Paint += usernameUnderLabel_Paint;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(39, 11);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(86, 16);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Kullanıcı Adı";
            // 
            // usernameBox
            // 
            usernameBox.BorderStyle = BorderStyle.None;
            usernameBox.Location = new Point(137, 11);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(290, 16);
            usernameBox.TabIndex = 2;
            usernameBox.TextChanged += usernameValueChanged;
            // 
            // usernameIcon
            // 
            usernameIcon.Image = (Image)resources.GetObject("usernameIcon.Image");
            usernameIcon.Location = new Point(3, 3);
            usernameIcon.Name = "usernameIcon";
            usernameIcon.Size = new Size(30, 30);
            usernameIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            usernameIcon.TabIndex = 0;
            usernameIcon.TabStop = false;
            // 
            // bunifuCards1
            // 
            bunifuCards1.BackColor = SystemColors.Window;
            bunifuCards1.BorderRadius = 25;
            bunifuCards1.BottomSahddow = true;
            bunifuCards1.BottomShadow = true;
            bunifuCards1.color = SystemColors.Window;
            bunifuCards1.Controls.Add(bunifuCards2);
            bunifuCards1.IndicatorColor = SystemColors.Window;
            bunifuCards1.LeftSahddow = false;
            bunifuCards1.LeftShadow = false;
            bunifuCards1.Location = new Point(129, 7);
            bunifuCards1.Name = "bunifuCards1";
            bunifuCards1.RightSahddow = true;
            bunifuCards1.RightShadow = true;
            bunifuCards1.ShadowDepth = 20;
            bunifuCards1.Size = new Size(306, 30);
            bunifuCards1.TabIndex = 10;
            // 
            // bunifuCards2
            // 
            bunifuCards2.BackColor = SystemColors.Window;
            bunifuCards2.BorderRadius = 25;
            bunifuCards2.BottomSahddow = true;
            bunifuCards2.BottomShadow = true;
            bunifuCards2.color = SystemColors.Window;
            bunifuCards2.IndicatorColor = SystemColors.Window;
            bunifuCards2.LeftSahddow = false;
            bunifuCards2.LeftShadow = false;
            bunifuCards2.Location = new Point(8, 8);
            bunifuCards2.Name = "bunifuCards2";
            bunifuCards2.RightSahddow = true;
            bunifuCards2.RightShadow = true;
            bunifuCards2.ShadowDepth = 20;
            bunifuCards2.Size = new Size(306, 30);
            bunifuCards2.TabIndex = 11;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 588);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPicture).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)formIcon).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usernameIcon).EndInit();
            bunifuCards1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ImageList ımageList1;
        private Label label1;
        private Button button3;
        private Panel panel2;
        private Panel panel7;
        private Panel panel1;
        private Panel panel3;
        private PictureBox usernameIcon;
        private PictureBox passwordIcon;
        private Label usernameLabel;
        private TextBox usernameBox;
        private Panel usernameUnderLabel;
        private PictureBox formIcon;
        private PictureBox logoPicture;
        private Button loginButton;
        private Panel panel4;
        private Panel passwordBoxPanel;
        private Label passwordLabel;
        private TextBox passwordBox;
        private Label registerLabel;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
    }
}