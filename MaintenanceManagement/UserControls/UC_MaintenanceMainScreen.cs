using MaintenanceManagement.Core;
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
    public partial class UC_MaintenanceMainScreen : UserControl
    {
        public UC_MaintenanceMainScreen()
        {
            InitializeComponent();

        }

        public void AddUC_AddMaintenanceScreen(Object sender, EventArgs e)
        {
            if (MainForm.currentScreen != "CreateFaultNotificationScreen")
            {
                UC_AddMaintenanceScreen userControl = new UC_AddMaintenanceScreen();
                userControl.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(userControl);
                this.Parent.Controls.Remove(this);
                MainForm.currentScreen = "CreateFaultNotificationScreen";
            }


        }

        public void AddUC_UpcomingMaintenanceScreen(Object sender, EventArgs e)
        {
            if (MainForm.currentScreen != "UpcomingMaintenancesScreen")
            {
                UC_UpcomingMaintenances userControl = new UC_UpcomingMaintenances();
                userControl.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(userControl);
                this.Parent.Controls.Remove(this);
                MainForm.currentScreen = "UpcomingMaintenancesScreen";
            }



        }

        public void AddUC_SelectMachineForViewOldMaintenancesScreen(Object sender, EventArgs e)
        {
            if (MainForm.currentScreen != "SelectMachineForViewOldMaintenancesScreen")
            {
                UC_SelectMachineForViewOldMaintenancesScreen userControl = new UC_SelectMachineForViewOldMaintenancesScreen();
                userControl.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(userControl);
                this.Parent.Controls.Remove(this);
                MainForm.currentScreen = "SelectMachineForViewOldMaintenancesScreen";
            }



        }

        public void AddUC_SelectMaintenanceScreen(Object sender, EventArgs e)
        {
            if (MainForm.currentScreen != "SelectMaintenanceScreen")
            {
                UC_SelectMaintenanceScreen userControl = new UC_SelectMaintenanceScreen();
                userControl.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(userControl);
                this.Parent.Controls.Remove(this);
                MainForm.currentScreen = "SelectMaintenanceScreen";
            }



        }
        public void AddUC_SelectMachineForViewOldMachineFaultsScreen(Object sender, EventArgs e)
        {
            if (MainForm.currentScreen != "SelectMachineForViewOldMachineFaultsScreen")
            {
                UC_SelectMachineForViewOldMachineFaultsScreen userControl = new UC_SelectMachineForViewOldMachineFaultsScreen();
                userControl.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(userControl);
                this.Parent.Controls.Remove(this);
                MainForm.currentScreen = "SelectMachineForViewOldMachineFaultsScreen";
            }



        }



        private void UC_MaintenanceMainScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
