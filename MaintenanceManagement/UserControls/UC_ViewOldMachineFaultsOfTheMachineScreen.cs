using MaintenanceManagement.DTO.Response;
using MaintenanceManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceManagement.UserControls
{
    public partial class UC_ViewOldMachineFaultsOfTheMachineScreen : UserControl
    {

        EntityContextWithSp entityContext = new EntityContextWithSp();
        private int machineId { get; set; }
        private DateTime beginDate { get; set; }
        private DateTime endDate { get; set; }
        public UC_ViewOldMachineFaultsOfTheMachineScreen(int id, DateTime beginDate, DateTime endDate)
        {
            InitializeComponent();
            this.machineId = id;
            this.beginDate = beginDate;
            this.endDate = endDate;
            InitializeData();
        }

        private void InitializeData()
        {
            completedMaintenancesGrid.Columns.Add("id", "Id");
            completedMaintenancesGrid.Columns.Add("machineId", "MachineId");
            completedMaintenancesGrid.Columns.Add("machineName", "MachineName");
            completedMaintenancesGrid.Columns.Add("faultPriorityLabel", "FaultPriorityLabel");
            completedMaintenancesGrid.Columns.Add("faultTypeLabel", "FaultTypeLabel");
            completedMaintenancesGrid.Columns.Add("beginDate", "BeginDate");
            completedMaintenancesGrid.Columns.Add("explanation", "Explanation");
            completedMaintenancesGrid.Columns.Add("isStopped", "isStopped");
            completedMaintenancesGrid.Columns.Add("userName", "UserName");
            completedMaintenancesGrid.Columns.Add("solution", "Solution");
            completedMaintenancesGrid.Columns.Add("solutionTime", "SolutionTime");

            dateLabel.Text = beginDate.Date.ToString("dd/MM/yyyy", new CultureInfo("tr-TR")) + " - " + endDate.Date.ToString("dd/MM/yyyy", new CultureInfo("tr-TR"));


            List<GetCompletedMachineFaultsAccordingToMachineResponseDTO> existingList = 
                entityContext.GetCompletedMachineFaults(machineId, beginDate, endDate);

            if (existingList != null)
            {
                foreach (var item in existingList)
                {
                    completedMaintenancesGrid.Rows.Add(item.id,item.machineId,item.machineName,item.faultPriorityLabel,
                        item.faultTypeLabel,item.beginDate,item.explanation,
                        item.isStopped,item.userName,item.solution,item.solutionTime);
                }
            }



        }

        private void GoSelectMachineForViewOldMachineFaultsScreen()
        {
            if (MainForm.currentScreen == "ViewOldMachineFaultsOfTheMachineScreen")
            {
                UC_SelectMachineForViewOldMachineFaultsScreen maintenanceScreen = new UC_SelectMachineForViewOldMachineFaultsScreen();
                maintenanceScreen.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(maintenanceScreen);
                this.Parent.Controls.Remove(this);
                MainForm.currentScreen = "SelectMachineForViewOldMachineFaultsScreen";
            }
        }

        private void GoBackButtonClick(object sender, EventArgs e)
        {
            GoSelectMachineForViewOldMachineFaultsScreen();
        }
    }
}
