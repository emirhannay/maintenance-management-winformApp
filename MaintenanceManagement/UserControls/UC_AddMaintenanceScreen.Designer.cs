namespace MaintenanceManagement.UserControls
{
    partial class UC_AddMaintenanceScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddMaintenanceScreen));
            label1 = new Label();
            explanationTextBox = new RichTextBox();
            explanationLabel = new Label();
            plannedDateLabel = new Label();
            plannedDateTimePicker = new DateTimePicker();
            maintenanceTypeLabel = new Label();
            maintenanceTypeComboBox = new ComboBox();
            machineLabel = new Label();
            machineComboBox = new ComboBox();
            createButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(527, 119);
            label1.Name = "label1";
            label1.Size = new Size(53, 13);
            label1.TabIndex = 42;
            label1.Text = "*Zorunlu";
            // 
            // explanationTextBox
            // 
            explanationTextBox.Location = new Point(610, 98);
            explanationTextBox.Name = "explanationTextBox";
            explanationTextBox.Size = new Size(219, 80);
            explanationTextBox.TabIndex = 41;
            explanationTextBox.Text = "";
            explanationTextBox.TextChanged += ChangeEnabledSituationForAddMaintenanceButton;
            // 
            // explanationLabel
            // 
            explanationLabel.AutoSize = true;
            explanationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            explanationLabel.Location = new Point(515, 98);
            explanationLabel.Name = "explanationLabel";
            explanationLabel.Size = new Size(89, 21);
            explanationLabel.TabIndex = 40;
            explanationLabel.Text = "Açıklama :";
            // 
            // plannedDateLabel
            // 
            plannedDateLabel.AutoSize = true;
            plannedDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            plannedDateLabel.Location = new Point(155, 199);
            plannedDateLabel.Name = "plannedDateLabel";
            plannedDateLabel.Size = new Size(137, 21);
            plannedDateLabel.TabIndex = 39;
            plannedDateLabel.Text = "Planlanan Tarih :";
            // 
            // plannedDateTimePicker
            // 
            plannedDateTimePicker.Format = DateTimePickerFormat.Custom;
            plannedDateTimePicker.Location = new Point(299, 199);
            plannedDateTimePicker.Name = "plannedDateTimePicker";
            plannedDateTimePicker.ShowUpDown = true;
            plannedDateTimePicker.Size = new Size(200, 23);
            plannedDateTimePicker.TabIndex = 38;
            // 
            // maintenanceTypeLabel
            // 
            maintenanceTypeLabel.AutoSize = true;
            maintenanceTypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            maintenanceTypeLabel.Location = new Point(188, 143);
            maintenanceTypeLabel.Name = "maintenanceTypeLabel";
            maintenanceTypeLabel.Size = new Size(99, 21);
            maintenanceTypeLabel.TabIndex = 44;
            maintenanceTypeLabel.Text = "Bakım Tipi :";
            // 
            // maintenanceTypeComboBox
            // 
            maintenanceTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            maintenanceTypeComboBox.FormattingEnabled = true;
            maintenanceTypeComboBox.Location = new Point(293, 141);
            maintenanceTypeComboBox.Name = "maintenanceTypeComboBox";
            maintenanceTypeComboBox.Size = new Size(121, 23);
            maintenanceTypeComboBox.TabIndex = 43;
            // 
            // machineLabel
            // 
            machineLabel.AutoSize = true;
            machineLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            machineLabel.Location = new Point(198, 94);
            machineLabel.Name = "machineLabel";
            machineLabel.Size = new Size(75, 21);
            machineLabel.TabIndex = 50;
            machineLabel.Text = "Makine :";
            // 
            // machineComboBox
            // 
            machineComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            machineComboBox.FormattingEnabled = true;
            machineComboBox.Location = new Point(293, 96);
            machineComboBox.Name = "machineComboBox";
            machineComboBox.Size = new Size(121, 23);
            machineComboBox.TabIndex = 49;
            // 
            // createButton
            // 
            createButton.BackColor = Color.Gray;
            createButton.Enabled = false;
            createButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            createButton.ForeColor = SystemColors.ActiveCaptionText;
            createButton.Image = (Image)resources.GetObject("createButton.Image");
            createButton.ImageAlign = ContentAlignment.TopLeft;
            createButton.Location = new Point(549, 245);
            createButton.Name = "createButton";
            createButton.Padding = new Padding(5, 0, 5, 0);
            createButton.Size = new Size(121, 40);
            createButton.TabIndex = 51;
            createButton.Text = "Oluştur";
            createButton.TextAlign = ContentAlignment.MiddleRight;
            createButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            createButton.UseVisualStyleBackColor = false;
            createButton.TextChanged += ChangeEnabledSituationForAddMaintenanceButton;
            createButton.Click += CreateButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(402, 245);
            button1.Name = "button1";
            button1.Padding = new Padding(5, 0, 5, 0);
            button1.Size = new Size(120, 40);
            button1.TabIndex = 52;
            button1.Text = "Geri Dön";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += GoBackButton_Click;
            // 
            // UC_AddMaintenanceScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(createButton);
            Controls.Add(machineLabel);
            Controls.Add(machineComboBox);
            Controls.Add(maintenanceTypeLabel);
            Controls.Add(maintenanceTypeComboBox);
            Controls.Add(label1);
            Controls.Add(explanationTextBox);
            Controls.Add(explanationLabel);
            Controls.Add(plannedDateLabel);
            Controls.Add(plannedDateTimePicker);
            Name = "UC_AddMaintenanceScreen";
            Size = new Size(992, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox explanationTextBox;
        private Label explanationLabel;
        private Label plannedDateLabel;
        private DateTimePicker plannedDateTimePicker;
        private Label maintenanceTypeLabel;
        private ComboBox maintenanceTypeComboBox;
        private Label machineLabel;
        private ComboBox machineComboBox;
        private Button createButton;
        private Button button1;
    }
}
