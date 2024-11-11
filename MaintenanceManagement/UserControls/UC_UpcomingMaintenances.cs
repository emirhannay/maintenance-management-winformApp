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
    public partial class UC_UpcomingMaintenances : UserControl
    {
        EntityContextWithSp entityContext = new EntityContextWithSp();
        public UC_UpcomingMaintenances()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            List<GetUpcomingMaintenancesResponseDTO> existingList = entityContext.GetUpcomingMaintenances();

            UpcomingMaintenancesDataGrid.Columns.Add("id", "Id");
            UpcomingMaintenancesDataGrid.Columns.Add("machineName", "MachineName");
            UpcomingMaintenancesDataGrid.Columns.Add("remainingDays", "RemainingDays");
            UpcomingMaintenancesDataGrid.Columns.Add("remainingHours", "RemainingHours");
            UpcomingMaintenancesDataGrid.Columns.Add("remainingMinutes", "RemainingMinutes");
            UpcomingMaintenancesDataGrid.Columns.Add("plannedDate", "PlannedDate");
            UpcomingMaintenancesDataGrid.Columns.Add("explanation", "Explanation");
            UpcomingMaintenancesDataGrid.Columns.Add("label", "Label");

            if (existingList != null)
            {
                foreach (var item in existingList)
                {
                    UpcomingMaintenancesDataGrid.Rows.Add(item.id, item.name, item.remainingDays, item.remainingHours,
                        item.remainingMinutes, item.plannedDate,item.explanation,item.label);
                }
            }








        }

        private void GoMaintenanceMainScreen()
        {
            if (MainForm.currentScreen == "UpcomingMaintenancesScreen")
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
