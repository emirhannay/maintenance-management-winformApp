using MaintenanceManagement.DTO.Response;
using MaintenanceManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceManagement.UserControls
{
    public partial class UC_ViewOldMaintenancesOfTheMachine : UserControl
    {
        EntityContextWithSp entityContext = new EntityContextWithSp();
        private int machineId { get; set; }
        private DateTime beginDate { get; set; }
        private DateTime endDate { get; set; }
        public UC_ViewOldMaintenancesOfTheMachine(int id, DateTime beginDate, DateTime endDate)
        {
            InitializeComponent();
            machineId = id;
            this.beginDate = beginDate;
            this.endDate = endDate;
            InitializeData();
        }

        private void InitializeData()
        {


            completedMaintenancesGrid.Columns.Add("machineId", "MachineId");
            completedMaintenancesGrid.Columns.Add("maintenanceId", "MaintenanceId");
            completedMaintenancesGrid.Columns.Add("machineName", "MachineName");
            completedMaintenancesGrid.Columns.Add("label", "Label");
            completedMaintenancesGrid.Columns.Add("explanation", "Explanation");
            completedMaintenancesGrid.Columns.Add("partUsed", "PartUsed");
            completedMaintenancesGrid.Columns.Add("plannedDate", "PlannedDate");
            completedMaintenancesGrid.Columns.Add("beginDate", "BeginDate");
            completedMaintenancesGrid.Columns.Add("endDate", "EndDate");
            completedMaintenancesGrid.Columns.Add("userId", "UserId");
            completedMaintenancesGrid.Columns.Add("completedBy", "CompletedBy");

            dateLabel.Text = beginDate.Date.ToString("dd/MM/yyyy", new CultureInfo("tr-TR")) + " - " + endDate.Date.ToString("dd/MM/yyyy", new CultureInfo("tr-TR"));


            List<GetCompletedMaintenancesResponseDTO> existingList = entityContext.GetCompletedMaintenances(machineId, beginDate, endDate);


            if (existingList != null)
            {
                foreach (var item in existingList)
                {
                    completedMaintenancesGrid.Rows.Add(item.machineId, item.maintenanceId, item.machineName, item.label,
                        item.explanation, item.partUsed, item.plannedDate, item.beginDate, item.endDate, item.userId, item.completedBy);
                }
            }



        }

        private void GoSelectMachineForViewOldMaintenanceScreen()
        {
            if (MainForm.currentScreen == "ViewOldMaintenancesOfTheMachineScreen")
            {
                UC_SelectMachineForViewOldMaintenancesScreen maintenanceScreen = new UC_SelectMachineForViewOldMaintenancesScreen();
                maintenanceScreen.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(maintenanceScreen);
                this.Parent.Controls.Remove(this);
                MainForm.currentScreen = "SelectMachineForViewOldMaintenancesScreen";
            }
        }

        private void GoBackButtonClick(object sender, EventArgs e)
        {
            GoSelectMachineForViewOldMaintenanceScreen();
        }



    }
}
