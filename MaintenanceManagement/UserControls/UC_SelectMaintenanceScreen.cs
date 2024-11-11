using MaintenanceManagement.Core;
using MaintenanceManagement.DTO.Response;
using MaintenanceManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceManagement.UserControls
{
    public partial class UC_SelectMaintenanceScreen : UserControl
    {
        EntityContextWithSp entityContext = new EntityContextWithSp();
        public UC_SelectMaintenanceScreen()
        {
            InitializeComponent();
            InitializeData();
            selectMaintenanceGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void InitializeData()
        {
            // DataGridView'e sütunları elle ekleme
            selectMaintenanceGrid.Columns.Add("machineId", "MachineId");
            selectMaintenanceGrid.Columns.Add("machineName", "MachineName");
            selectMaintenanceGrid.Columns.Add("maintenanceId", "MaintenanceId");
            selectMaintenanceGrid.Columns.Add("type", "Type");
            selectMaintenanceGrid.Columns.Add("label", "Label");
            selectMaintenanceGrid.Columns.Add("explanation", "Explanation");
            selectMaintenanceGrid.Columns.Add("partUsed", "PartUsed");
            selectMaintenanceGrid.Columns.Add("plannedDate", "PlannedDate");
            selectMaintenanceGrid.Columns.Add("beginDate", "BeginDate");

            // Var olan listeyi alın
            List<GetMaintenanceWithMachineNameAndTypeResponseDTO> existingList = entityContext.GetMaintenanceWithMachineNameAndType();

            // DataGridView'in DataSource'unu güncellemek yerine, verileri doğrudan DataGridView'e ekleyin
            if (existingList != null)
            {
                foreach (var item in existingList)
                {
                    selectMaintenanceGrid.Rows.Add(item.machineId, item.machineName, item.id, item.type,
                        item.label, item.explanation, item.partUsed, item.plannedDate, item.beginDate);
                }
            }


        }


        public void AddUC_CompleteEditMaintenanceScreen(object sender, EventArgs e)

        {
            if (selectMaintenanceGrid.SelectedRows.Count == 1)
            {
                int selectedRowIndex = selectMaintenanceGrid.SelectedRows[0].Index;

                if (selectMaintenanceGrid.Rows[selectedRowIndex] == null || selectMaintenanceGrid.Rows[selectedRowIndex].Cells[0].Value == null)
                {
                    MessageBox.Show("Lütfen boş satır seçmeyiniz!");
                }
                else
                {

                    DataGridViewRow selectedRow = selectMaintenanceGrid.Rows[selectedRowIndex];
                    int maintenanceId = selectedRow.Cells[2].Value as int? ?? 0;
                    string machineName = selectedRow.Cells[1].Value as string;
                    string maintenanceTypeString = selectedRow.Cells[4].Value as string;
                    string explanation = selectedRow.Cells[5].Value as string;
                    string partUsed = selectedRow.Cells[6].Value as string;
                    DateTime? plannedDate = selectedRow.Cells[7].Value as DateTime?;
                    DateTime? beginDate = selectedRow.Cells[8].Value as DateTime?;




                    UC_CompleteMaintenanceScreen userControl = new UC_CompleteMaintenanceScreen(new GetMaintenanceWithMachineNameAndTypeResponseDTO(machineName, maintenanceId, explanation, partUsed, plannedDate, beginDate, maintenanceTypeString));

                    userControl.Dock = DockStyle.Fill;
                    this.Parent.Controls.Add(userControl);
                    this.Parent.Controls.Remove(this);
                    MainForm.currentScreen = "CompleteMaintenanceScreen";
                }
            }
            else if (selectMaintenanceGrid.SelectedRows.Count > 1)
            {
                MessageBox.Show("Lütfen tek bir satır seçin!");

            }

            else
            {
                MessageBox.Show("Lütfen bir satır seçin!");
            }

        }

        private void GoMaintenanceMainScreen()
        {
            if (MainForm.currentScreen == "SelectMaintenanceScreen")
            {
                UC_MaintenanceMainScreen maintenanceScreen = new UC_MaintenanceMainScreen();
                maintenanceScreen.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(maintenanceScreen);
                this.Parent.Controls.Remove(this);
                MainForm.currentScreen = "MaintenanceMainScreen";
            }
        }

        private void GoBackButtonClick(object sender, EventArgs e)
        {
            GoMaintenanceMainScreen();
        }
    }
}
