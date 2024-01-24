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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MaintenanceManagement.UserControls
{
    public partial class UC_CompleteMaintenanceScreen : UserControl
    {

        private GetMaintenanceWithMachineNameAndTypeResponseDTO objectToEdit;

        private bool initializing = true;

        EntityContextWithSp entityContext = new EntityContextWithSp();

        public UC_CompleteMaintenanceScreen(GetMaintenanceWithMachineNameAndTypeResponseDTO responseDTO)
        {
            initializing = true;
            InitializeComponent();
            SetObjectToEdit(responseDTO);
            InitializeData();
            SelectDefaultValues();

            initializing = false;
        }

        private void UC_CompleteMaintenanceScreen_Load(object sender, EventArgs e)
        {

        }

        private void InitializeData()
        {
            maintIdComboBox.Items.Add(objectToEdit.id);
            machineComboBox.Items.Add(objectToEdit.machineName);
            maintenanceTypeComboBox.Items.Add(objectToEdit.label);
            partUsedTextBox.Text = objectToEdit.partUsed;
            explanationTextBox.Text = objectToEdit.explanation;
            if (objectToEdit.plannedDate != null)
            {
                plannedDateTimePicker.Value = (DateTime)objectToEdit.plannedDate;

            }
            if (objectToEdit.beginDate != null)
            {
                beginDatePickerrr.Value = (DateTime)objectToEdit.beginDate;
                isMaintenanceStarted.Checked = true;
            }
            else
            {
                beginDatePickerrr.Value = DateTime.Now;
                isMaintenanceStarted.Checked = false;
            }

            SetDateTimePickerFormat(beginDatePickerrr);
            SetDateTimePickerFormat(plannedDateTimePicker);
            SetDateTimePickerFormat(endDatePicker);


            endDatePicker.Value = DateTime.Now.AddMinutes(1);

        }

        private void SelectDefaultValues()
        {
            //For maintIdComboBox
            int index = maintIdComboBox.FindStringExact(objectToEdit.id.ToString());

            if (index != -1)
            {
                maintIdComboBox.SelectedIndex = index;
            }

            //ForMachineComboBox

            int index2 = machineComboBox.FindStringExact(objectToEdit.machineName);

            if (index2 != -1)
            {
                machineComboBox.SelectedItem = machineComboBox.Items[index2];
                machineComboBox.SelectedIndex = index2;

            }

            //MaintenanceTypeComboBox
            int index3 = maintenanceTypeComboBox.FindStringExact(objectToEdit.label);

            if (index3 != -1)
            {
                maintenanceTypeComboBox.SelectedItem = maintenanceTypeComboBox.Items[index3];
                maintenanceTypeComboBox.SelectedIndex = index3;
            }
        }
        public void SetObjectToEdit(GetMaintenanceWithMachineNameAndTypeResponseDTO objectToEdit)
        {
            this.objectToEdit = objectToEdit;
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!initializing && endDatePicker.Value <= beginDatePickerrr.Value)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden önce veya eşit olamaz. Doğru bir veri girişi sağlayınız.");
                endDatePicker.Value = beginDatePickerrr.Value.AddHours(1);
            }
        }

        private void beginDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!initializing && beginDatePickerrr.Value >= endDatePicker.Value)
            {
                MessageBox.Show("Başlangıç tarihi bitiş tarihinden sonra veya eşit olamaz. Doğru bir veri girişi sağlayınız.");
                beginDatePickerrr.Value = endDatePicker.Value.AddHours(-1);
            }
        }

        public void CompleteMaintenance(object sender, EventArgs e)
        {
            int maintenanceId = (int)maintIdComboBox.SelectedItem;
            string explanation = explanationTextBox.Text;
            string partUsed = partUsedTextBox.Text;
            DateTime? beginDate = null;
            DateTime? endDate = null;
            int completedBy = -1;

            // beginDate değişiklik kontrolü
            if (objectToEdit.beginDate != beginDatePickerrr.Value)
            {
                beginDate = beginDatePickerrr.Value;
            }

            // endDate değişiklik kontrolü
            if (isMaintenanceCompleted.Checked)
            {
                endDate = endDatePicker.Value;
                completedBy = SessionManager.Id;
            }

            if (completedBy != -1)
            {
                entityContext.CompleteEditMaintenance(new CompleteEditMaintenanceRequestDTO(maintenanceId, explanation,
                partUsed, beginDate, endDate, completedBy));
            }
            else
            {
                entityContext.CompleteEditMaintenance(new CompleteEditMaintenanceRequestDTO(maintenanceId, explanation,
                partUsed, beginDate, endDate));

            }

            MessageBox.Show("Bakımı tamamlama / değiştirme işlemi gerçekleşti!");
            GoSelectMaintenanceScreen();
        }

        private void SetDateTimePickerFormat(DateTimePicker picker)
        {
            picker.Format = DateTimePickerFormat.Custom;
            picker.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void IsMaintenanceCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (isMaintenanceCompleted.Checked)
            {
                endDatePanel.Visible = true;
                isMaintenanceStartedPanel.Visible = true;
                isMaintenanceStarted.Checked = true;
            }
            else
            {
                endDatePanel.Visible = false;
            }
        }

        private void IsMaintenanceStarted_CheckedChanged(object sender, EventArgs e)
        {
            if (isMaintenanceStarted.Checked)
            {
                isMaintenanceStartedPanel.Visible = true;
            }
            else
            {
                isMaintenanceStartedPanel.Visible = false;
            }
        }

        private void ShowMessageBox(object sender, EventArgs e)
        {



        }



        private void GoSelectMaintenanceScreen()
        {
            if (MainForm.currentScreen == "CompleteMaintenanceScreen")
            {
                UC_SelectMaintenanceScreen selectMaintenanceScreen = new UC_SelectMaintenanceScreen();
                selectMaintenanceScreen.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(selectMaintenanceScreen);
                this.Parent.Controls.Remove(this);
                MainForm.currentScreen = "SelectMaintenanceScreen";
            }
        }

        private void GoBackButtonClick(object sender, EventArgs e)
        {
            GoSelectMaintenanceScreen();
        }


    }
}
