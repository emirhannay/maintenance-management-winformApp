using MaintenanceManagement.Core;
using MaintenanceManagement.Repository;
using MaintenanceManagement.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MaintenanceManagement
{
    public partial class MainForm : Form
    {
        public static string currentScreen = "Main";
        public MainForm()
        {
            EntityContextWithSp entityContextWithSp = new EntityContextWithSp();
            InitializeComponent();
            this.Load += new EventHandler(Form_Load);
        }
        private void Form_Load(object sender, EventArgs e)
        {


            SetMainContentsAccordingToRole();
            SetMenuButtonsAccordingToRole();


        }

        private void AddUC_MainScreen()

        {
            UC_MainScreen userControl = new UC_MainScreen();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            mainPanel.SendToBack();
            userControl.BringToFront();
            mainLabel.Text = "Ana Ekran";
        }

        public void AddUC_AllFaultNotificationsScreen(object sender, EventArgs e)

        {
            if(MainForm.currentScreen != "AllFaultNotificationScreen")
            {
                UC_AllFaultNotificationsScreen userControl = new UC_AllFaultNotificationsScreen();
                userControl.Dock = DockStyle.Fill;
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(userControl);
                mainPanel.SendToBack();
                userControl.BringToFront();
                currentScreen = "AllFaultNotificationScreen";
                mainLabel.Text = "Tüm Arıza Bildirimleri";
            }
            

        }

        public void AddUC_MaintenanceMainScreen(object sender, EventArgs e)

        {
            UC_MaintenanceMainScreen userControl = new UC_MaintenanceMainScreen();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            mainPanel.SendToBack();
            userControl.BringToFront();
            currentScreen = "MaintenanceMainScreen";
            mainLabel.Text = "Bakım Ekranı";
        }

        public void AddUC_MaintenanceScreen(object sender, EventArgs e)

        {
            UC_AddMaintenanceScreen userControl = new UC_AddMaintenanceScreen();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            mainPanel.SendToBack();
            userControl.BringToFront();
            currentScreen = "CreateMaintenanceScreen";
        }

        private void SetMainContentsAccordingToRole()
        {
            if (SessionManager.TypeValue == 0)
            {                //It means user role is ADMIN
                AddUC_MainScreen();

            }
            else if (SessionManager.TypeValue == 1)
            {
                //It means user role is Maintenance Man
                AddUC_MainScreen();
            }
            else if (SessionManager.TypeValue == 2)
            {
                //It means user role is Team Leader
                AddUC_MainScreen();
            }
        }
        private void SetMenuButtonsAccordingToRole()
        {
            if (SessionManager.TypeValue == 0)
            {
                //It means user role is ADMIN
                SetMenuButtonsVisibilityForAdmin();

            }
            else if (SessionManager.TypeValue == 1)
            {
                //It means user role is Maintenance Man
                SetMenuButtonsVisibilityForMaintenanceMan();
            }

            else if (SessionManager.TypeValue == 2)
            {
                //It means user role is Team Leader
                SetMenuButtonsVisibilityForTeamLeader();
            }
        }

        private void SetMenuButtonsVisibilityForAdmin()
        {
            FaultNotificationsMenuButton.Visible = true;
            MaintenanceMenuButton.Visible = true;

        }

        private void SetMenuButtonsVisibilityForMaintenanceMan()
        {
            FaultNotificationsMenuButton.Visible = true;
            MaintenanceMenuButton.Visible = true;

        }

        private void SetMenuButtonsVisibilityForTeamLeader()
        {
            FaultNotificationsMenuButton.Visible = true;
            MaintenanceMenuButton.Visible = false;

        }



        private void MainMenuButtonClick(object sender, EventArgs e)
        {
            if (currentScreen != "Main")
            {
                UC_MainScreen uc = new UC_MainScreen();
                AddUC_MainScreen();
                currentScreen = "Main";
            }

        }

       

        private void closeAppClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
       
    }
}
