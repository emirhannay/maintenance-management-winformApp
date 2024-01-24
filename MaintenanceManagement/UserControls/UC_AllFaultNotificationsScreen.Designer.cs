namespace MaintenanceManagement.UserControls
{
    partial class UC_AllFaultNotificationsScreen
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
            AllFaultNotificationsGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)AllFaultNotificationsGrid).BeginInit();
            SuspendLayout();
            // 
            // AllFaultNotificationsGrid
            // 
            AllFaultNotificationsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            AllFaultNotificationsGrid.BackgroundColor = Color.White;
            AllFaultNotificationsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllFaultNotificationsGrid.GridColor = SystemColors.Control;
            AllFaultNotificationsGrid.Location = new Point(19, 3);
            AllFaultNotificationsGrid.Name = "AllFaultNotificationsGrid";
            AllFaultNotificationsGrid.RowTemplate.Height = 25;
            AllFaultNotificationsGrid.Size = new Size(953, 478);
            AllFaultNotificationsGrid.TabIndex = 4;
            // 
            // UC_AllFaultNotificationsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AllFaultNotificationsGrid);
            Name = "UC_AllFaultNotificationsScreen";
            Size = new Size(992, 500);
            ((System.ComponentModel.ISupportInitialize)AllFaultNotificationsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView AllFaultNotificationsGrid;
    }
}
