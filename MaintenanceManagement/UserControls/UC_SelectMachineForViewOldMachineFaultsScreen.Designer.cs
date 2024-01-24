namespace MaintenanceManagement.UserControls
{
    partial class UC_SelectMachineForViewOldMachineFaultsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SelectMachineForViewOldMachineFaultsScreen));
            label3 = new Label();
            label2 = new Label();
            endPicker = new DateTimePicker();
            beginPicker = new DateTimePicker();
            label1 = new Label();
            goBackButton = new Button();
            selectMachineButton = new Button();
            machineIdLabel = new Label();
            machineIdComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(277, 128);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 93;
            label3.Text = "Tarih 2  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(277, 98);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 92;
            label2.Text = "Tarih 1  :";
            // 
            // endPicker
            // 
            endPicker.Location = new Point(363, 128);
            endPicker.Name = "endPicker";
            endPicker.Size = new Size(200, 23);
            endPicker.TabIndex = 91;
            endPicker.ValueChanged += endDatePicker_ValueChanged;
            // 
            // beginPicker
            // 
            beginPicker.Location = new Point(363, 98);
            beginPicker.Name = "beginPicker";
            beginPicker.Size = new Size(200, 23);
            beginPicker.TabIndex = 90;
            beginPicker.ValueChanged += beginDatePicker_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(399, 246);
            label1.Name = "label1";
            label1.Size = new Size(447, 13);
            label1.TabIndex = 89;
            label1.Text = "*Seçilen makinenin verilen tarih aralağında ortaya çıkmış arızasını / arızalarını gösterir.";
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
            goBackButton.TabIndex = 88;
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
            selectMachineButton.TabIndex = 87;
            selectMachineButton.Text = "Görüntüle";
            selectMachineButton.TextAlign = ContentAlignment.MiddleRight;
            selectMachineButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            selectMachineButton.UseVisualStyleBackColor = false;
            selectMachineButton.Click += AddUC_ViewOldMachineFaultsOfTheMachine;
            // 
            // machineIdLabel
            // 
            machineIdLabel.AutoSize = true;
            machineIdLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            machineIdLabel.Location = new Point(277, 66);
            machineIdLabel.Name = "machineIdLabel";
            machineIdLabel.Size = new Size(75, 21);
            machineIdLabel.TabIndex = 86;
            machineIdLabel.Text = "Makine :";
            // 
            // machineIdComboBox
            // 
            machineIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            machineIdComboBox.FormattingEnabled = true;
            machineIdComboBox.Location = new Point(363, 64);
            machineIdComboBox.Name = "machineIdComboBox";
            machineIdComboBox.Size = new Size(121, 23);
            machineIdComboBox.TabIndex = 85;
            // 
            // UC_SelectMachineForViewOldMachineFaultsScreen
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
            Name = "UC_SelectMachineForViewOldMachineFaultsScreen";
            Size = new Size(992, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private DateTimePicker endPicker;
        private DateTimePicker beginPicker;
        private Label label1;
        private Button goBackButton;
        private Button selectMachineButton;
        private Label machineIdLabel;
        private ComboBox machineIdComboBox;
    }
}
