namespace MaintenanceManagement.UserControls
{
    partial class UC_CompleteMaintenanceScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CompleteMaintenanceScreen));
            button1 = new Button();
            createButton = new Button();
            machineLabel = new Label();
            maintenanceTypeLabel = new Label();
            explanationTextBox = new RichTextBox();
            explanationLabel = new Label();
            plannedDateLabel = new Label();
            plannedDateTimePicker = new DateTimePicker();
            partUsedTextBox = new RichTextBox();
            label3 = new Label();
            maintenanceIdLabel = new Label();
            endDateLabel = new Label();
            endDatePicker = new DateTimePicker();
            maintIdComboBox = new ComboBox();
            machineComboBox = new ComboBox();
            maintenanceTypeComboBox = new ComboBox();
            isMaintenanceCompleted = new CheckBox();
            isMaintenanceCompletedLabel = new Label();
            label5 = new Label();
            endDatePanel = new Panel();
            label1 = new Label();
            isMaintenanceStarted = new CheckBox();
            isMaintenanceStartedPanel = new Panel();
            label6 = new Label();
            label7 = new Label();
            beginDatePickerrr = new DateTimePicker();
            label8 = new Label();
            endDatePanel.SuspendLayout();
            isMaintenanceStartedPanel.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(332, 415);
            button1.Name = "button1";
            button1.Padding = new Padding(5, 0, 5, 0);
            button1.Size = new Size(120, 40);
            button1.TabIndex = 63;
            button1.Text = "Geri Dön";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += GoBackButtonClick;
            // 
            // createButton
            // 
            createButton.BackColor = Color.FromArgb(76, 200, 80);
            createButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            createButton.ForeColor = SystemColors.ActiveCaptionText;
            createButton.Image = (Image)resources.GetObject("createButton.Image");
            createButton.ImageAlign = ContentAlignment.TopLeft;
            createButton.Location = new Point(479, 415);
            createButton.Name = "createButton";
            createButton.Padding = new Padding(5, 0, 5, 0);
            createButton.Size = new Size(185, 40);
            createButton.TabIndex = 62;
            createButton.Text = "Tamamla / Değiştir";
            createButton.TextAlign = ContentAlignment.MiddleRight;
            createButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += CompleteMaintenance;
            // 
            // machineLabel
            // 
            machineLabel.AutoSize = true;
            machineLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            machineLabel.Location = new Point(188, 80);
            machineLabel.Name = "machineLabel";
            machineLabel.Size = new Size(75, 21);
            machineLabel.TabIndex = 61;
            machineLabel.Text = "Makine :";
            // 
            // maintenanceTypeLabel
            // 
            maintenanceTypeLabel.AutoSize = true;
            maintenanceTypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            maintenanceTypeLabel.Location = new Point(178, 117);
            maintenanceTypeLabel.Name = "maintenanceTypeLabel";
            maintenanceTypeLabel.Size = new Size(99, 21);
            maintenanceTypeLabel.TabIndex = 59;
            maintenanceTypeLabel.Text = "Bakım Tipi :";
            // 
            // explanationTextBox
            // 
            explanationTextBox.Location = new Point(600, 144);
            explanationTextBox.Name = "explanationTextBox";
            explanationTextBox.Size = new Size(219, 80);
            explanationTextBox.TabIndex = 56;
            explanationTextBox.Text = "";
            // 
            // explanationLabel
            // 
            explanationLabel.AutoSize = true;
            explanationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            explanationLabel.Location = new Point(505, 142);
            explanationLabel.Name = "explanationLabel";
            explanationLabel.Size = new Size(89, 21);
            explanationLabel.TabIndex = 55;
            explanationLabel.Text = "Açıklama :";
            // 
            // plannedDateLabel
            // 
            plannedDateLabel.AutoSize = true;
            plannedDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            plannedDateLabel.Location = new Point(140, 153);
            plannedDateLabel.Name = "plannedDateLabel";
            plannedDateLabel.Size = new Size(137, 21);
            plannedDateLabel.TabIndex = 54;
            plannedDateLabel.Text = "Planlanan Tarih :";
            // 
            // plannedDateTimePicker
            // 
            plannedDateTimePicker.Format = DateTimePickerFormat.Custom;
            plannedDateTimePicker.Location = new Point(283, 153);
            plannedDateTimePicker.Name = "plannedDateTimePicker";
            plannedDateTimePicker.ShowUpDown = true;
            plannedDateTimePicker.Size = new Size(200, 23);
            plannedDateTimePicker.TabIndex = 53;
            // 
            // partUsedTextBox
            // 
            partUsedTextBox.Location = new Point(600, 40);
            partUsedTextBox.Name = "partUsedTextBox";
            partUsedTextBox.Size = new Size(219, 80);
            partUsedTextBox.TabIndex = 65;
            partUsedTextBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(432, 40);
            label3.Name = "label3";
            label3.Size = new Size(162, 21);
            label3.TabIndex = 64;
            label3.Text = "Kullanılan Parçalar :";
            // 
            // maintenanceIdLabel
            // 
            maintenanceIdLabel.AutoSize = true;
            maintenanceIdLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            maintenanceIdLabel.Location = new Point(178, 44);
            maintenanceIdLabel.Name = "maintenanceIdLabel";
            maintenanceIdLabel.Size = new Size(85, 21);
            maintenanceIdLabel.TabIndex = 67;
            maintenanceIdLabel.Text = "Bakım Id :";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            endDateLabel.Location = new Point(3, 25);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(150, 21);
            endDateLabel.TabIndex = 72;
            endDateLabel.Text = "Bakım Bitiş Tarihi :";
            // 
            // endDatePicker
            // 
            endDatePicker.Format = DateTimePickerFormat.Custom;
            endDatePicker.Location = new Point(159, 24);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.ShowUpDown = true;
            endDatePicker.Size = new Size(200, 23);
            endDatePicker.TabIndex = 71;
            endDatePicker.ValueChanged += endDatePicker_ValueChanged;
            // 
            // maintIdComboBox
            // 
            maintIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            maintIdComboBox.FormattingEnabled = true;
            maintIdComboBox.Location = new Point(283, 42);
            maintIdComboBox.Name = "maintIdComboBox";
            maintIdComboBox.Size = new Size(121, 23);
            maintIdComboBox.TabIndex = 73;
            // 
            // machineComboBox
            // 
            machineComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            machineComboBox.FormattingEnabled = true;
            machineComboBox.Location = new Point(283, 78);
            machineComboBox.Name = "machineComboBox";
            machineComboBox.Size = new Size(121, 23);
            machineComboBox.TabIndex = 77;
            // 
            // maintenanceTypeComboBox
            // 
            maintenanceTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            maintenanceTypeComboBox.FormattingEnabled = true;
            maintenanceTypeComboBox.Location = new Point(283, 115);
            maintenanceTypeComboBox.Name = "maintenanceTypeComboBox";
            maintenanceTypeComboBox.Size = new Size(121, 23);
            maintenanceTypeComboBox.TabIndex = 78;
            // 
            // isMaintenanceCompleted
            // 
            isMaintenanceCompleted.AutoSize = true;
            isMaintenanceCompleted.Location = new Point(341, 330);
            isMaintenanceCompleted.Name = "isMaintenanceCompleted";
            isMaintenanceCompleted.Size = new Size(15, 14);
            isMaintenanceCompleted.TabIndex = 79;
            isMaintenanceCompleted.UseVisualStyleBackColor = true;
            isMaintenanceCompleted.CheckedChanged += IsMaintenanceCompleted_CheckedChanged;
            // 
            // isMaintenanceCompletedLabel
            // 
            isMaintenanceCompletedLabel.AutoSize = true;
            isMaintenanceCompletedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            isMaintenanceCompletedLabel.Location = new Point(140, 324);
            isMaintenanceCompletedLabel.Name = "isMaintenanceCompletedLabel";
            isMaintenanceCompletedLabel.Size = new Size(186, 21);
            isMaintenanceCompletedLabel.TabIndex = 80;
            isMaintenanceCompletedLabel.Text = "Bakım tamamlandı mı?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(75, 50);
            label5.Name = "label5";
            label5.Size = new Size(234, 13);
            label5.TabIndex = 81;
            label5.Text = "*Bakım tamamlandıysa bitiş tarihi girilmelidir";
            // 
            // endDatePanel
            // 
            endDatePanel.Controls.Add(endDateLabel);
            endDatePanel.Controls.Add(label5);
            endDatePanel.Controls.Add(endDatePicker);
            endDatePanel.Location = new Point(463, 298);
            endDatePanel.Name = "endDatePanel";
            endDatePanel.Size = new Size(356, 100);
            endDatePanel.TabIndex = 82;
            endDatePanel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(140, 242);
            label1.Name = "label1";
            label1.Size = new Size(167, 21);
            label1.TabIndex = 84;
            label1.Text = "Bakıma başlandı mı?";
            // 
            // isMaintenanceStarted
            // 
            isMaintenanceStarted.AutoSize = true;
            isMaintenanceStarted.Location = new Point(341, 248);
            isMaintenanceStarted.Name = "isMaintenanceStarted";
            isMaintenanceStarted.Size = new Size(15, 14);
            isMaintenanceStarted.TabIndex = 83;
            isMaintenanceStarted.UseVisualStyleBackColor = true;
            isMaintenanceStarted.CheckedChanged += IsMaintenanceStarted_CheckedChanged;
            // 
            // isMaintenanceStartedPanel
            // 
            isMaintenanceStartedPanel.Controls.Add(label6);
            isMaintenanceStartedPanel.Controls.Add(label7);
            isMaintenanceStartedPanel.Controls.Add(beginDatePickerrr);
            isMaintenanceStartedPanel.Location = new Point(422, 216);
            isMaintenanceStartedPanel.Name = "isMaintenanceStartedPanel";
            isMaintenanceStartedPanel.Size = new Size(400, 76);
            isMaintenanceStartedPanel.TabIndex = 83;
            isMaintenanceStartedPanel.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(4, 24);
            label6.Name = "label6";
            label6.Size = new Size(190, 21);
            label6.TabIndex = 72;
            label6.Text = "Bakım Başlangıç Tarihi :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(116, 50);
            label7.Name = "label7";
            label7.Size = new Size(251, 13);
            label7.TabIndex = 81;
            label7.Text = "*Bakıma başlandıysa başlangıç tarihi girilmelidir";
            // 
            // beginDatePickerrr
            // 
            beginDatePickerrr.Format = DateTimePickerFormat.Custom;
            beginDatePickerrr.Location = new Point(200, 24);
            beginDatePickerrr.Name = "beginDatePickerrr";
            beginDatePickerrr.ShowUpDown = true;
            beginDatePickerrr.Size = new Size(200, 23);
            beginDatePickerrr.TabIndex = 71;
            beginDatePickerrr.ValueChanged += beginDatePicker_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(538, 163);
            label8.Name = "label8";
            label8.Size = new Size(53, 13);
            label8.TabIndex = 85;
            label8.Text = "*Zorunlu";
            // 
            // UC_CompleteMaintenanceScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label8);
            Controls.Add(isMaintenanceStartedPanel);
            Controls.Add(label1);
            Controls.Add(isMaintenanceStarted);
            Controls.Add(endDatePanel);
            Controls.Add(isMaintenanceCompletedLabel);
            Controls.Add(isMaintenanceCompleted);
            Controls.Add(maintenanceTypeComboBox);
            Controls.Add(machineComboBox);
            Controls.Add(maintIdComboBox);
            Controls.Add(maintenanceIdLabel);
            Controls.Add(partUsedTextBox);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(createButton);
            Controls.Add(machineLabel);
            Controls.Add(maintenanceTypeLabel);
            Controls.Add(explanationTextBox);
            Controls.Add(explanationLabel);
            Controls.Add(plannedDateLabel);
            Controls.Add(plannedDateTimePicker);
            Name = "UC_CompleteMaintenanceScreen";
            Size = new Size(992, 500);
            Load += UC_CompleteMaintenanceScreen_Load;
            endDatePanel.ResumeLayout(false);
            endDatePanel.PerformLayout();
            isMaintenanceStartedPanel.ResumeLayout(false);
            isMaintenanceStartedPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button createButton;
        private Label machineLabel;
        private Label maintenanceTypeLabel;
        private RichTextBox explanationTextBox;
        private Label explanationLabel;
        private Label plannedDateLabel;
        private DateTimePicker plannedDateTimePicker;
        private RichTextBox partUsedTextBox;
        private Label label3;
        private Label maintenanceIdLabel;
        private Label endDateLabel;
        private DateTimePicker endDatePicker;
        private ComboBox maintIdComboBox;
        private ComboBox machineComboBox;
        private ComboBox maintenanceTypeComboBox;
        private CheckBox isMaintenanceCompleted;
        private Label isMaintenanceCompletedLabel;
        private Label label5;
        private Panel endDatePanel;
        private Label label1;
        private CheckBox isMaintenanceStarted;
        private Panel isMaintenanceStartedPanel;
        private Label label6;
        private Label label7;
        private DateTimePicker beginDatePickerrr;
        private Label label8;
    }
}
