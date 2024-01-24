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
    public partial class UC_CompleteActiveFaultNotificationScreen : UserControl
    {
        EntityContextWithSp entityContext = new EntityContextWithSp();
        private int machineFaultId { get; set; }
        private bool initializing { get; set; }
        public UC_CompleteActiveFaultNotificationScreen()
        {
            initializing = true;
            InitializeComponent();
            SetDateTimePickerFormat(beginDateTimePicker);
            SetDateTimePickerFormat(endDateTimePicker);
            initializing = false;

            endDateTimePicker.Value = DateTime.Now;
            beginDateTimePicker.Value = DateTime.Now.AddHours(-1);

        }

        public void SetMachineFaultId(int id)
        {
            machineFaultId = id;
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!initializing && endDateTimePicker.Value <= beginDateTimePicker.Value)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden önce veya eşit olamaz. Doğru bir veri girişi sağlayınız.");
                endDateTimePicker.Value = beginDateTimePicker.Value.AddHours(1);
            }
        }

        private void beginDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!initializing && beginDateTimePicker.Value >= endDateTimePicker.Value)
            {
                MessageBox.Show("Başlangıç tarihi bitiş tarihinden sonra veya eşit olamaz. Doğru bir veri girişi sağlayınız.");
                beginDateTimePicker.Value = endDateTimePicker.Value.AddHours(-1);
            }
        }


        private void GoBackButtonClick(object sender, EventArgs e)
        {
            GoMainMenu();
        }

        private void GoMainMenu()
        {
            if (MainForm.currentScreen == "CompleteActiveFaultNotificationScreen")
            {
                UC_MainScreen mainScreen = new UC_MainScreen();
                mainScreen.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(mainScreen);
                this.Parent.Controls.Remove(this);

            }
        }
        private void SetDateTimePickerFormat()
        {
            beginDateTimePicker.Format = DateTimePickerFormat.Custom;
            beginDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        public void AddMaintenance(object sender, EventArgs e)
        {
            GetMachineFaultResponseDTO response = entityContext.GetMachineFaultById(machineFaultId);
            entityContext.AddFaultMaintenance(new AddFaultMaintenanceRequestDTO(response.machineId
                , explanationTextBox.Text, partUsedTextBox.Text, beginDateTimePicker.Value, endDateTimePicker.Value, machineFaultId));
            MessageBox.Show("Arıza kaydının bakımı tamamlandı. Bakım bilgileri sisteme eklenmiştir.");

            GoMainMenu();
        }

        public void ChangeEnabledSituationForAddMaintenanceButton(object sender, EventArgs e)
        {
            if (explanationTextBox.Text.Length >= 3)
            {
                AddMaintenanceButton.Enabled = true;
                AddMaintenanceButton.BackColor = Color.FromArgb(76, 200, 80);
            }
            else
            {
                AddMaintenanceButton.Enabled = false;
                AddMaintenanceButton.BackColor = Color.Gray;
            }
        }

        private void SetDateTimePickerFormat(DateTimePicker picker)
        {
            picker.Format = DateTimePickerFormat.Custom;
            picker.CustomFormat = "dd/MM/yyyy HH:mm";
        }
    }
}
