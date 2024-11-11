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
using MaintenanceManagement.DTO.Request;
using MaintenanceManagement.Core;
using System.Data.SqlClient;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MaintenanceManagement.DTO.Response;
using System.Text.RegularExpressions;

namespace MaintenanceManagement
{
    public partial class RegisterScreen : Form
    {
        EntityContextWithSp entityContextWithSp = new EntityContextWithSp();


        public RegisterScreen()
        {
            InitializeComponent();
            goBackPictureBox.Cursor = Cursors.Hand;
            usernameMessageBox.Cursor = Cursors.Hand;
            passwordMessageBox.Cursor = Cursors.Hand;

            addDatasToComboTypeBox();
            addDatasToMaintenanceTypeComboBox();

            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            maintenanceTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SetMaintenanceTypeComboBoxVisibility(false);

            int selectedTypeValue = Convert.ToInt32(typeComboBox.SelectedValue.ToString());

            // Seçili değeri kontrol et ve işlem yap           
            if (selectedTypeValue == 1)
            {
                SetMaintenanceTypeComboBoxVisibility(true);
            }
            else
            {
                SetMaintenanceTypeComboBoxVisibility(false);
            }



        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameMessageBox_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Kullanıcı adı yalnızca harf ve rakamlardan oluşmalı ve en az 4 karakter uzunluğunda olmalıdır!");
        }
        private void passwordMessageBox_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Şifre yalnızca harf ve rakamlardan oluşmalı. En az 1 harf içermeli ve 8 karakter uzunluğunda olmalıdır!");
        }

        private void goBackClick(object sender, EventArgs e)


        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }


        private void registerClick(object sender, EventArgs e)
        {

            int selectedTypeValue = Convert.ToInt32(typeComboBox.SelectedValue.ToString());

            if (maintenanceTypeComboBox.SelectedValue.ToString() == null)
            {

                entityContextWithSp.AddUser(new UserRegisterRequestDTO(nameBox.Text, usernameBox.Text, passwordBox.Text, selectedTypeValue));
                MessageBox.Show("Kayıt oluşturuldu. Ana ekrandan giriş yapabilirsiniz.");
                this.Visible = false;
                LoginForm login = new LoginForm();
                login.Visible = true;

            }

            else if (maintenanceTypeComboBox.SelectedValue.ToString() != null)
            {
                int selectedMaintenanceTypeValue = Convert.ToInt32(maintenanceTypeComboBox.SelectedValue.ToString());
                entityContextWithSp.AddUser(new UserRegisterRequestDTO(nameBox.Text, usernameBox.Text, passwordBox.Text, selectedTypeValue, selectedMaintenanceTypeValue));
                MessageBox.Show("Kayıt oluşturuldu. Ana ekrandan giriş yapabilirsiniz.");
                this.Visible = false;
                LoginForm login = new LoginForm();
                login.Visible = true;
            }

        }


        private void closeAppClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addDatasToComboTypeBox()
        {
            List<GetUserTypesRequestDTO> response = entityContextWithSp.GetUserTypes();
            typeComboBox.DataSource = response;
            typeComboBox.DisplayMember = "Label";
            typeComboBox.ValueMember = "Value";

        }

        private void addDatasToMaintenanceTypeComboBox()
        {
            List<GetMaintenanceManTypesResponseDTO> response = entityContextWithSp.GetMaintenanceManTypes();
            maintenanceTypeComboBox.DataSource = response;
            maintenanceTypeComboBox.DisplayMember = "Label";
            maintenanceTypeComboBox.ValueMember = "Value";
        }
        private void SetMaintenanceTypeComboBoxVisibility(bool boolean)
        {
            if (boolean)
            {
                MaintenanceTypePanel.Visible = true;
            }
            else
            {
                MaintenanceTypePanel.Visible = false;
            }
        }


        //Check if user chose Maintenance Man role for show the component so the maintainer can choose its type
        public void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (typeComboBox.SelectedItem != null)
            {
                // Seçili değeri al
                int selectedTypeValue = Convert.ToInt32(typeComboBox.SelectedValue.ToString());

                // Seçili değeri kontrol et ve işlem yap           
                if (selectedTypeValue == 1)
                {
                    SetMaintenanceTypeComboBoxVisibility(true);
                }
                else
                {
                    SetMaintenanceTypeComboBoxVisibility(false);
                }

            }
        }

        private void usernameBoxValueChanged(object sender, EventArgs e)
        {
            //User Experience
            if (usernameBox.Text.Length <= 3 | usernameBox.Text == null)
            {
                usernameBox.Enabled = false;
            }
            else
            {
                if (!(passwordBox.Text.Length <= 4) & !(passwordBox.Text == null))
                {
                    usernameBox.Enabled = true;
                }

            }
            //
        }
        private void EnableRegisterButtonAccordingToUserFormInput(object sender, EventArgs e)
        {
            bool passwordBoxSituation = CheckWithRegexIsInputCorrectFormat(passwordBox.Text, @"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z\d]{8,30}$");
            bool usernameBoxSituation = CheckWithRegexIsInputCorrectFormat(usernameBox.Text, @"^[a-zA-ZığüşöçĞÜŞİÖÇ\d]{4,30}$");
            bool nameBoxSituation = CheckWithRegexIsInputCorrectFormat(nameBox.Text, @"^[a-zA-ZığüşöçĞÜŞİÖÇ\s]{3,30}$");

            if (passwordBoxSituation & usernameBoxSituation & nameBoxSituation)
            {
                registerButton.Enabled = true;
            }
            else
            {
                registerButton.Enabled = false;
            }
        }
        private bool CheckWithRegexIsInputCorrectFormat(string input, string pattern)
        {
            return Regex.IsMatch(input, pattern);
        }







    }
}
