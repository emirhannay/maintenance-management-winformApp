namespace MaintenanceManagement.UserControls
{
    partial class UC_CompleteActiveFaultNotificationScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CompleteActiveFaultNotificationScreen));
            goBackButton = new Button();
            explanationTextBox = new RichTextBox();
            explanationLabel = new Label();
            beginDateLabel = new Label();
            beginDateTimePicker = new DateTimePicker();
            partUsedTextBox = new RichTextBox();
            partUsedLabel = new Label();
            endDateLabel = new Label();
            endDateTimePicker = new DateTimePicker();
            AddMaintenanceButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // goBackButton
            // 
            goBackButton.BackColor = Color.Red;
            goBackButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            goBackButton.ForeColor = SystemColors.ActiveCaptionText;
            goBackButton.Image = (Image)resources.GetObject("goBackButton.Image");
            goBackButton.ImageAlign = ContentAlignment.TopLeft;
            goBackButton.Location = new Point(374, 287);
            goBackButton.Name = "goBackButton";
            goBackButton.Padding = new Padding(5, 0, 5, 0);
            goBackButton.Size = new Size(120, 40);
            goBackButton.TabIndex = 29;
            goBackButton.Text = "Geri Dön";
            goBackButton.TextAlign = ContentAlignment.MiddleRight;
            goBackButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            goBackButton.UseVisualStyleBackColor = false;
            goBackButton.Click += GoBackButtonClick;
            // 
            // explanationTextBox
            // 
            explanationTextBox.Location = new Point(263, 175);
            explanationTextBox.Name = "explanationTextBox";
            explanationTextBox.Size = new Size(200, 47);
            explanationTextBox.TabIndex = 25;
            explanationTextBox.Text = "";
            explanationTextBox.TextChanged += ChangeEnabledSituationForAddMaintenanceButton;
            // 
            // explanationLabel
            // 
            explanationLabel.AutoSize = true;
            explanationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            explanationLabel.Location = new Point(168, 175);
            explanationLabel.Name = "explanationLabel";
            explanationLabel.Size = new Size(89, 21);
            explanationLabel.TabIndex = 24;
            explanationLabel.Text = "Açıklama :";
            // 
            // beginDateLabel
            // 
            beginDateLabel.AutoSize = true;
            beginDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            beginDateLabel.Location = new Point(168, 122);
            beginDateLabel.Name = "beginDateLabel";
            beginDateLabel.Size = new Size(138, 21);
            beginDateLabel.TabIndex = 23;
            beginDateLabel.Text = "Başlangıç Tarihi :";
            // 
            // beginDateTimePicker
            // 
            beginDateTimePicker.Format = DateTimePickerFormat.Custom;
            beginDateTimePicker.Location = new Point(312, 122);
            beginDateTimePicker.Name = "beginDateTimePicker";
            beginDateTimePicker.ShowUpDown = true;
            beginDateTimePicker.Size = new Size(200, 23);
            beginDateTimePicker.TabIndex = 22;
            beginDateTimePicker.ValueChanged += beginDatePicker_ValueChanged;
            // 
            // partUsedTextBox
            // 
            partUsedTextBox.Location = new Point(653, 173);
            partUsedTextBox.Name = "partUsedTextBox";
            partUsedTextBox.Size = new Size(200, 49);
            partUsedTextBox.TabIndex = 31;
            partUsedTextBox.Text = "";
            partUsedTextBox.TextChanged += ChangeEnabledSituationForAddMaintenanceButton;
            // 
            // partUsedLabel
            // 
            partUsedLabel.AutoSize = true;
            partUsedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            partUsedLabel.Location = new Point(489, 173);
            partUsedLabel.Name = "partUsedLabel";
            partUsedLabel.Size = new Size(162, 21);
            partUsedLabel.TabIndex = 30;
            partUsedLabel.Text = "Kullanılan Parçalar :";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            endDateLabel.Location = new Point(529, 121);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(98, 21);
            endDateLabel.TabIndex = 33;
            endDateLabel.Text = "Bitiş Tarihi :";
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Format = DateTimePickerFormat.Custom;
            endDateTimePicker.Location = new Point(633, 121);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.ShowUpDown = true;
            endDateTimePicker.Size = new Size(200, 23);
            endDateTimePicker.TabIndex = 32;
            endDateTimePicker.ValueChanged += endDatePicker_ValueChanged;
            // 
            // AddMaintenanceButton
            // 
            AddMaintenanceButton.BackColor = Color.Gray;
            AddMaintenanceButton.Enabled = false;
            AddMaintenanceButton.FlatAppearance.BorderSize = 0;
            AddMaintenanceButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddMaintenanceButton.ForeColor = SystemColors.ActiveCaptionText;
            AddMaintenanceButton.Image = (Image)resources.GetObject("AddMaintenanceButton.Image");
            AddMaintenanceButton.ImageAlign = ContentAlignment.BottomLeft;
            AddMaintenanceButton.Location = new Point(551, 287);
            AddMaintenanceButton.Name = "AddMaintenanceButton";
            AddMaintenanceButton.Padding = new Padding(5, 0, 5, 0);
            AddMaintenanceButton.Size = new Size(234, 40);
            AddMaintenanceButton.TabIndex = 36;
            AddMaintenanceButton.Text = "Tamamlandı Olarak İşaretle";
            AddMaintenanceButton.TextAlign = ContentAlignment.MiddleRight;
            AddMaintenanceButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddMaintenanceButton.UseVisualStyleBackColor = false;
            AddMaintenanceButton.Click += AddMaintenance;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(180, 196);
            label1.Name = "label1";
            label1.Size = new Size(53, 13);
            label1.TabIndex = 37;
            label1.Text = "*Zorunlu";
            // 
            // UC_CompleteActiveFaultNotificationScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(AddMaintenanceButton);
            Controls.Add(endDateLabel);
            Controls.Add(endDateTimePicker);
            Controls.Add(partUsedTextBox);
            Controls.Add(partUsedLabel);
            Controls.Add(goBackButton);
            Controls.Add(explanationTextBox);
            Controls.Add(explanationLabel);
            Controls.Add(beginDateLabel);
            Controls.Add(beginDateTimePicker);
            Name = "UC_CompleteActiveFaultNotificationScreen";
            Size = new Size(992, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button goBackButton;
        private RichTextBox explanationTextBox;
        private Label explanationLabel;
        private Label beginDateLabel;
        private DateTimePicker beginDateTimePicker;
        private RichTextBox partUsedTextBox;
        private Label partUsedLabel;
        private Label endDateLabel;
        private DateTimePicker endDateTimePicker;
        private Button AddMaintenanceButton;
        private Label label1;
    }
}
