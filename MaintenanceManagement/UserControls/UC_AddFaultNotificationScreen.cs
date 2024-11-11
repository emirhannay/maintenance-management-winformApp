using MaintenanceManagement.Core;
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
    public partial class UC_AddFaultNotificationScreen : UserControl
    {
        EntityContextWithSp entityContextWithSp = new EntityContextWithSp();
        public UC_AddFaultNotificationScreen()
        {
            InitializeComponent();
            InitializeMachineIdComboBoxData();
            InitializePriorityComboBox();
            InitializeMachineFaultTypeComboBox();
            SetDateTimePickerFormat();


        }

        private void UC_AddFaultNotificationScreen_Load(object sender, EventArgs e)
        {

        }

        public void ChangeEnabledSituation(object sender, EventArgs e)
        {
            if (explanationTextBox.Text.Length >= 3)
            {
                FaultNotificationsMenuButton.Enabled = true;
                FaultNotificationsMenuButton.BackColor = Color.FromArgb(76, 200, 80);
            }
            else
            {
                FaultNotificationsMenuButton.Enabled = false;
                FaultNotificationsMenuButton.BackColor = Color.Gray;
            }
        }
        private void InitializeMachineIdComboBoxData()
        {
            List<GetMachinesResponseDTO> list = entityContextWithSp.GetMachines();
            machineIdComboBox.DataSource = list;
            machineIdComboBox.ValueMember = "id";
            machineIdComboBox.DisplayMember = "name";
        }

        private void InitializePriorityComboBox()
        {
            List<GetMachineFaultPriorityResponseDTO> list = entityContextWithSp.GetMachineFaultPriority();
            priorityComboBox.DataSource = list;
            priorityComboBox.ValueMember = "Value";
            priorityComboBox.DisplayMember = "Label";
        }

        private void InitializeMachineFaultTypeComboBox()
        {
            List<GetMachineFaultTypeResponseDTO> list = entityContextWithSp.GetMachineFaultType();
            machineFaultTypeComboBox.DataSource = list;
            machineFaultTypeComboBox.ValueMember = "value";
            machineFaultTypeComboBox.DisplayMember = "label";
        }

        private void GoBackButtonClick(object sender, EventArgs e)
        {

            GoMainMenu();
        }
        private void GoMainMenu()
        {

            if (MainForm.currentScreen == "CreateFaultNotificationScreen")
            {
                UC_MainScreen mainScreen = new UC_MainScreen();
                mainScreen.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(mainScreen);
                this.Parent.Controls.Remove(this);

            }

        }

        private void CreateButtonClick(object sender, EventArgs e)
        {

            int machineId = (int)machineIdComboBox.SelectedValue;
            int priority = (int)priorityComboBox.SelectedValue;
            int type = (int)machineFaultTypeComboBox.SelectedValue;
            DateTime beginDate = beginDateTimePicker.Value;
            string explanation = explanationTextBox.Text;
            bool isStopped = isStoppedCheckBox.Checked;
            int userId = SessionManager.Id;

            entityContextWithSp.AddMachineFault(new AddMachineFaultRequestDTO(machineId, priority, type, beginDate, explanation, isStopped, userId));
            MessageBox.Show("Arıza kaydı oluşturuldu");
            GoMainMenu();
        }
        private void SetDateTimePickerFormat()
        {
            beginDateTimePicker.Format = DateTimePickerFormat.Custom;
            beginDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
        }



    }
}
