namespace MaintenanceManagement.UserControls
{
    partial class UC_SelectMachineForViewOldMaintenancesScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SelectMachineForViewOldMaintenancesScreen));
            machineIdLabel = new Label();
            machineIdComboBox = new ComboBox();
            goBackButton = new Button();
            selectMachineButton = new Button();
            label1 = new Label();
            beginPicker = new DateTimePicker();
            endPicker = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // machineIdLabel
            // 
            machineIdLabel.AutoSize = true;
            machineIdLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            machineIdLabel.Location = new Point(277, 66);
            machineIdLabel.Name = "machineIdLabel";
            machineIdLabel.Size = new Size(75, 21);
            machineIdLabel.TabIndex = 3;
            machineIdLabel.Text = "Makine :";
            // 
            // machineIdComboBox
            // 
            machineIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            machineIdComboBox.FormattingEnabled = true;
            machineIdComboBox.Location = new Point(363, 64);
            machineIdComboBox.Name = "machineIdComboBox";
            machineIdComboBox.Size = new Size(121, 23);
            machineIdComboBox.TabIndex = 2;
            // 
            // goBackButton
            // 
            goBackButton.BackColor = Color.Red;
            goBackButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            goBackButton.ForeColor = SystemColors.ActiveCaptionText;
            goBackButton.Image = (Image)resources.GetObject("goBackButton.Image");
            goBackButton.ImageAlign = ContentAlignment.TopLeft;
            goBackButton.Location = new Point(277, 189);
            goBackButton.Name = "goBackButton";
            goBackButton.Padding = new Padding(5, 0, 5, 0);
            goBackButton.Size = new Size(120, 40);
            goBackButton.TabIndex = 32;
            goBackButton.Text = "Geri Dön";
            goBackButton.TextAlign = ContentAlignment.MiddleRight;
            goBackButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            goBackButton.UseVisualStyleBackColor = false;
            goBackButton.Click += GoBackButtonClick;
            // 
            // selectMachineButton
            // 
            selectMachineButton.BackColor = Color.FromArgb(76, 180, 80);
            selectMachineButton.FlatAppearance.BorderSize = 0;
            selectMachineButton.FlatStyle = FlatStyle.Flat;
            selectMachineButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            selectMachineButton.ForeColor = SystemColors.ActiveCaptionText;
            selectMachineButton.Image = (Image)resources.GetObject("selectMachineButton.Image");
            selectMachineButton.ImageAlign = ContentAlignment.BottomLeft;
            selectMachineButton.Location = new Point(474, 189);
            selectMachineButton.Name = "selectMachineButton";
            selectMachineButton.Padding = new Padding(5, 0, 5, 0);
            selectMachineButton.Size = new Size(123, 40);
            selectMachineButton.TabIndex = 31;
            selectMachineButton.Text = "Görüntüle";
            selectMachineButton.TextAlign = ContentAlignment.MiddleRight;
            selectMachineButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            selectMachineButton.UseVisualStyleBackColor = false;
            selectMachineButton.Click += AddUC_ViewOldMaintenancesOfTheMachine;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(399, 246);
            label1.Name = "label1";
            label1.Size = new Size(457, 13);
            label1.TabIndex = 80;
            label1.Text = "*Seçilen makinenin verilen tarih aralağında tamamlanmış bakımını / bakımlarını gösterir.";
            // 
            // beginPicker
            // 
            beginPicker.Location = new Point(363, 98);
            beginPicker.Name = "beginPicker";
            beginPicker.Size = new Size(200, 23);
            beginPicker.TabIndex = 81;
            beginPicker.ValueChanged += beginDatePicker_ValueChanged;
            // 
            // endPicker
            // 
            endPicker.Location = new Point(363, 128);
            endPicker.Name = "endPicker";
            endPicker.Size = new Size(200, 23);
            endPicker.TabIndex = 82;
            endPicker.ValueChanged += endDatePicker_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(277, 98);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 83;
            label2.Text = "Tarih 1  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(277, 128);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 84;
            label3.Text = "Tarih 2  :";
            // 
            // UC_SelectMachineForViewOldMaintenancesScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(endPicker);
            Controls.Add(beginPicker);
            Controls.Add(label1);
            Controls.Add(goBackButton);
            Controls.Add(selectMachineButton);
            Controls.Add(machineIdLabel);
            Controls.Add(machineIdComboBox);
            Name = "UC_SelectMachineForViewOldMaintenancesScreen";
            Size = new Size(992, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label machineIdLabel;
        private ComboBox machineIdComboBox;
        private Button goBackButton;
        private Button selectMachineButton;
        private Label label1;
        private DateTimePicker beginPicker;
        private DateTimePicker endPicker;
        private Label label2;
        private Label label3;
    }
}
