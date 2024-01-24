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
    public partial class UC_SelectMachineForViewOldMaintenancesScreen : UserControl
    {
        EntityContextWithSp entityContext = new EntityContextWithSp();
        private bool initializing;
        public UC_SelectMachineForViewOldMaintenancesScreen()
        {
            InitializeComponent();
            InitializeMachineIdComboBoxData();
        }
        private void InitializeMachineIdComboBoxData()
        {
            initializing = true;
            List<GetMachinesResponseDTO> list = entityContext.GetMachines();
            machineIdComboBox.DataSource = list;
            machineIdComboBox.ValueMember = "id";
            machineIdComboBox.DisplayMember = "name";

            beginPicker.Value = DateTime.Now.AddDays(-1);
            endPicker.Value = DateTime.Now;
            initializing = false;
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!initializing && endPicker.Value <= beginPicker.Value)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden önce veya eşit olamaz. Doğru bir veri girişi sağlayınız.");
                endPicker.Value = beginPicker.Value.AddDays(1);
            }
        }

        private void beginDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!initializing && beginPicker.Value >= endPicker.Value)
            {
                MessageBox.Show("Başlangıç tarihi bitiş tarihinden sonra veya eşit olamaz. Doğru bir veri girişi sağlayınız.");
                beginPicker.Value = endPicker.Value.AddDays(-1);
            }
        }


        private void GoMaintenanceMainScreen()
        {
            if (MainForm.currentScreen == "SelectMachineForViewOldMaintenancesScreen")
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

        private void AddUC_ViewOldMaintenancesOfTheMachine(object sender, EventArgs e)
        {
            if (MainForm.currentScreen == "SelectMachineForViewOldMaintenancesScreen")
            {

                int machineId = (int)machineIdComboBox.SelectedValue;
                DateTime beginDate = (DateTime)beginPicker.Value;
                DateTime endDate = (DateTime)endPicker.Value;
                UC_ViewOldMaintenancesOfTheMachine screen = new UC_ViewOldMaintenancesOfTheMachine(machineId, beginDate, endDate);
                screen.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(screen);
                this.Parent.Controls.Remove(this);
                MainForm.currentScreen = "ViewOldMaintenancesOfTheMachineScreen";
            }
        }


    }


}
