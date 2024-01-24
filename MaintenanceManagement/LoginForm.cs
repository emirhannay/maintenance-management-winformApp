using MaintenanceManagement.Core;
using MaintenanceManagement.DTO.Request;
using MaintenanceManagement.DTO.Response;
using MaintenanceManagement.DTO.Response.MaintenanceManagement.DTO.Response;


using MaintenanceManagement.Repository;

using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Diagnostics;

namespace MaintenanceManagement
{
    public partial class LoginForm : Form
    {

        private EntityContextWithSp entityContextWithSp = new EntityContextWithSp();


        public LoginForm()
        {



            InitializeComponent();

            registerLabel.Cursor = Cursors.Hand;
            Debug.WriteLine("SA");

        }


        private void closeAppClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openRegisterScreenClick(object sender, EventArgs e)
        {
            RegisterScreen registerScreen = new RegisterScreen();
            this.Visible = false;
            registerScreen.Visible = true;
        }





        private void loginClick(object sender, EventArgs e)
        {

            GetUserWithTypeNameResponseDTO response = entityContextWithSp.GetUserWithTypeName(new GetUserRequestDTO(usernameBox.Text));

            if (response != null)
            {
                if (usernameBox.Text == response.username & passwordBox.Text == response.password)
                {

                    MessageBox.Show("Giriþ baþarýlý. Hoþgeldiniz...");
                    SessionManager.StartSession(response.name, response.username, response.password, response.id, response.typeName, response.type);
                    this.Visible = false;
                    MainForm mainScreen = new MainForm();
                    mainScreen.Visible = true;

                }
                else
                {
                    MessageBox.Show("Hatalý giriþ yaptýnýz. Lütfen verileri kontrol ederek tekrar deneyiniz.");
                }

            }
            else
            {
                MessageBox.Show("Hatalý giriþ yaptýnýz. Lütfen verileri kontrol ederek tekrar deneyiniz.");
            }

        }

        private void usernameValueChanged(object sender, EventArgs e)
        {
            //User Experience
            if (usernameBox.Text.Length <= 3 | usernameBox.Text == null)
            {
                loginButton.Enabled = false;
            }
            else
            {
                if (!(passwordBox.Text.Length <= 4) & !(passwordBox.Text == null))
                {
                    loginButton.Enabled = true;
                }

            }
            //
        }
        private void passwordValueChanged(object sender, EventArgs e)
        {
           

            //User Experience
            if (passwordBox.Text.Length <= 4 | passwordIcon.Text == null)
            {
                loginButton.Enabled = false;
            }
            else
            {
                if (!(usernameBox.Text.Length <= 3) & !(usernameBox.Text == null))
                {
                    loginButton.Enabled = true;
                }

            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usernameUnderLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}