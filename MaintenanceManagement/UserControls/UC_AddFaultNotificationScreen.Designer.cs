namespace MaintenanceManagement.UserControls
{
    partial class UC_AddFaultNotificationScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddFaultNotificationScreen));
            machineIdComboBox = new ComboBox();
            machineIdLabel = new Label();
            priorityLabel = new Label();
            priorityComboBox = new ComboBox();
            machineFaultTypeLabel = new Label();
            machineFaultTypeComboBox = new ComboBox();
            beginDateTimePicker = new DateTimePicker();
            beginDateLabel = new Label();
            explanationLabel = new Label();
            explanationTextBox = new RichTextBox();
            isStoppedCheckBoxLabel = new Label();
            isStoppedCheckBox = new CheckBox();
            button1 = new Button();
            FaultNotificationsMenuButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // machineIdComboBox
            // 
            machineIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            machineIdComboBox.FormattingEnabled = true;
            machineIdComboBox.Location = new Point(290, 55);
            machineIdComboBox.Name = "machineIdComboBox";
            machineIdComboBox.Size = new Size(121, 23);
            machineIdComboBox.TabIndex = 0;
            // 
            // machineIdLabel
            // 
            machineIdLabel.AutoSize = true;
            machineIdLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            machineIdLabel.Location = new Point(195, 53);
            machineIdLabel.Name = "machineIdLabel";
            machineIdLabel.Size = new Size(75, 21);
            machineIdLabel.TabIndex = 1;
            machineIdLabel.Text = "Makine :";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            priorityLabel.Location = new Point(195, 93);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(76, 21);
            priorityLabel.TabIndex = 3;
            priorityLabel.Text = "Öncelik :";
            // 
            // priorityComboBox
            // 
            priorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            priorityComboBox.FormattingEnabled = true;
            priorityComboBox.Location = new Point(290, 95);
            priorityComboBox.Name = "priorityComboBox";
            priorityComboBox.Size = new Size(121, 23);
            priorityComboBox.TabIndex = 2;
            // 
            // machineFaultTypeLabel
            // 
            machineFaultTypeLabel.AutoSize = true;
            machineFaultTypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            machineFaultTypeLabel.Location = new Point(195, 130);
            machineFaultTypeLabel.Name = "machineFaultTypeLabel";
            machineFaultTypeLabel.Size = new Size(94, 21);
            machineFaultTypeLabel.TabIndex = 5;
            machineFaultTypeLabel.Text = "Arıza  Tipi :";
            // 
            // machineFaultTypeComboBox
            // 
            machineFaultTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            machineFaultTypeComboBox.FormattingEnabled = true;
            machineFaultTypeComboBox.Location = new Point(290, 132);
            machineFaultTypeComboBox.Name = "machineFaultTypeComboBox";
            machineFaultTypeComboBox.Size = new Size(121, 23);
            machineFaultTypeComboBox.TabIndex = 4;
            // 
            // beginDateTimePicker
            // 
            beginDateTimePicker.Format = DateTimePickerFormat.Custom;
            beginDateTimePicker.Location = new Point(584, 50);
            beginDateTimePicker.Name = "beginDateTimePicker";
            beginDateTimePicker.ShowUpDown = true;
            beginDateTimePicker.Size = new Size(200, 23);
            beginDateTimePicker.TabIndex = 6;
            // 
            // beginDateLabel
            // 
            beginDateLabel.AutoSize = true;
            beginDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            beginDateLabel.Location = new Point(440, 50);
            beginDateLabel.Name = "beginDateLabel";
            beginDateLabel.Size = new Size(138, 21);
            beginDateLabel.TabIndex = 7;
            beginDateLabel.Text = "Başlangıç Tarihi :";
            // 
            // explanationLabel
            // 
            explanationLabel.AutoSize = true;
            explanationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            explanationLabel.Location = new Point(195, 175);
            explanationLabel.Name = "explanationLabel";
            explanationLabel.Size = new Size(89, 21);
            explanationLabel.TabIndex = 8;
            explanationLabel.Text = "Açıklama :";
            // 
            // explanationTextBox
            // 
            explanationTextBox.Location = new Point(290, 175);
            explanationTextBox.Name = "explanationTextBox";
            explanationTextBox.Size = new Size(200, 47);
            explanationTextBox.TabIndex = 9;
            explanationTextBox.Text = "";
            explanationTextBox.TextChanged += ChangeEnabledSituation;
            // 
            // isStoppedCheckBoxLabel
            // 
            isStoppedCheckBoxLabel.AutoSize = true;
            isStoppedCheckBoxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            isStoppedCheckBoxLabel.Location = new Point(440, 87);
            isStoppedCheckBoxLabel.Name = "isStoppedCheckBoxLabel";
            isStoppedCheckBoxLabel.Size = new Size(153, 21);
            isStoppedCheckBoxLabel.TabIndex = 10;
            isStoppedCheckBoxLabel.Text = "Makine durdu mu?";
            // 
            // isStoppedCheckBox
            // 
            isStoppedCheckBox.AutoSize = true;
            isStoppedCheckBox.Location = new Point(610, 94);
            isStoppedCheckBox.Name = "isStoppedCheckBox";
            isStoppedCheckBox.Size = new Size(15, 14);
            isStoppedCheckBox.TabIndex = 11;
            isStoppedCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(370, 271);
            button1.Name = "button1";
            button1.Padding = new Padding(5, 0, 5, 0);
            button1.Size = new Size(120, 40);
            button1.TabIndex = 15;
            button1.Text = "Geri Dön";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += GoBackButtonClick;
            // 
            // FaultNotificationsMenuButton
            // 
            FaultNotificationsMenuButton.BackColor = Color.Gray;
            FaultNotificationsMenuButton.Enabled = false;
            FaultNotificationsMenuButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FaultNotificationsMenuButton.ForeColor = SystemColors.ActiveCaptionText;
            FaultNotificationsMenuButton.Image = (Image)resources.GetObject("FaultNotificationsMenuButton.Image");
            FaultNotificationsMenuButton.ImageAlign = ContentAlignment.TopLeft;
            FaultNotificationsMenuButton.Location = new Point(541, 271);
            FaultNotificationsMenuButton.Name = "FaultNotificationsMenuButton";
            FaultNotificationsMenuButton.Padding = new Padding(5, 0, 5, 0);
            FaultNotificationsMenuButton.Size = new Size(120, 40);
            FaultNotificationsMenuButton.TabIndex = 14;
            FaultNotificationsMenuButton.Text = "Oluştur";
            FaultNotificationsMenuButton.TextAlign = ContentAlignment.MiddleRight;
            FaultNotificationsMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            FaultNotificationsMenuButton.UseVisualStyleBackColor = false;
            FaultNotificationsMenuButton.Click += CreateButtonClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(218, 196);
            label2.Name = "label2";
            label2.Size = new Size(53, 13);
            label2.TabIndex = 39;
            label2.Text = "*Zorunlu";
            // 
            // UC_AddFaultNotificationScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(FaultNotificationsMenuButton);
            Controls.Add(isStoppedCheckBox);
            Controls.Add(isStoppedCheckBoxLabel);
            Controls.Add(explanationTextBox);
            Controls.Add(explanationLabel);
            Controls.Add(beginDateLabel);
            Controls.Add(beginDateTimePicker);
            Controls.Add(machineFaultTypeLabel);
            Controls.Add(machineFaultTypeComboBox);
            Controls.Add(priorityLabel);
            Controls.Add(priorityComboBox);
            Controls.Add(machineIdLabel);
            Controls.Add(machineIdComboBox);
            Name = "UC_AddFaultNotificationScreen";
            Size = new Size(992, 500);
            Load += UC_AddFaultNotificationScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox machineIdComboBox;
        private Label machineIdLabel;
        private Label priorityLabel;
        private ComboBox priorityComboBox;
        private Label machineFaultTypeLabel;
        private ComboBox machineFaultTypeComboBox;
        private DateTimePicker beginDateTimePicker;
        private Label beginDateLabel;
        private Label explanationLabel;
        private RichTextBox explanationTextBox;
        private Label isStoppedCheckBoxLabel;
        private CheckBox isStoppedCheckBox;
        private Button button1;
        private Button FaultNotificationsMenuButton;
        private Label label2;
    }
}
