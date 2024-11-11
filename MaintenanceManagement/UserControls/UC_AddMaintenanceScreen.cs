using MaintenanceManagement.DTO.Request;
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
    public partial class UC_AddMaintenanceScreen : UserControl
    {

        EntityContextWithSp entityContext = new EntityContextWithSp();
        public UC_AddMaintenanceScreen()
        {
            InitializeComponent();
            InitializeMachineComboBoxData();
            InitializeMaintenanceTypeComboBoxData();
            //SetFormAccordingToRole();
            SetDateTimePickerFormat(plannedDateTimePicker);
        }

        private void InitializeMachineComboBoxData()
        {
            List<GetMachinesResponseDTO> list = entityContext.GetMachines();
            machineComboBox.DataSource = list;
            machineComboBox.ValueMember = "id";
            machineComboBox.DisplayMember = "name";
        }

        private void InitializeMaintenanceTypeComboBoxData()
        {
            List<GetMachineFaultTypeResponseDTO> list = entityContext.GetMaintenanceType();
            maintenanceTypeComboBox.DataSource = list;
            maintenanceTypeComboBox.ValueMember = "Value";
            maintenanceTypeComboBox.DisplayMember = "Label";
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            int machineId = (int)machineComboBox.SelectedValue;
            string explanation = explanationTextBox.Text;
            DateTime plannedDate = plannedDateTimePicker.Value;

            int type = (int)maintenanceTypeComboBox.SelectedValue;

            entityContext.AddMaintenance(new AddMaintenanceRequestDTO(plannedDate, machineId, type, explanation));
            MessageBox.Show("Bakım oluşturuldu!");
        }

        public void GoBackButton_Click(object sender, EventArgs e)
        {
            if (MainForm.currentScreen == "CreateFaultNotificationScreen")
            {
                UC_MaintenanceMainScreen mainScreen = new UC_MaintenanceMainScreen();
                mainScreen.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(mainScreen);
                this.Parent.Controls.Remove(this);
                MainForm.currentScreen = "MaintenanceMainScreen";
            }

        }

        public void ChangeEnabledSituationForAddMaintenanceButton(object sender, EventArgs e)
        {
            if (explanationTextBox.Text.Length >= 3)
            {
                createButton.Enabled = true;
                createButton.BackColor = Color.FromArgb(76, 200, 80);
            }
            else
            {
                createButton.Enabled = false;
                createButton.BackColor = Color.Gray;
            }
        }

        private void SetDateTimePickerFormat(DateTimePicker picker)
        {
            picker.Format = DateTimePickerFormat.Custom;
            picker.CustomFormat = "dd/MM/yyyy HH:mm";
        }



        //private void SetFormAccordingToRole()
        //{
        //    if (maintenanceTypeComboBox.SelectedItem != null)
        //    {
        //        // Seçili değeri al
        //        int selectedTypeValue = Convert.ToInt32(maintenanceTypeComboBox.SelectedValue.ToString());

        //        // Seçili değeri kontrol et ve işlem yap           
        //        if (selectedTypeValue == 1)
        //        {
        //            beginDateLabel.Visible = false;
        //            beginDateTimePicker.Visible = false;
        //        }
        //        else
        //        {
        //            beginDateLabel.Visible = true;
        //            beginDateTimePicker.Visible = true;
        //        }

        //    }
        //}

    }


}
