using MaintenanceManagement.Core;
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
    public partial class UC_MainScreen : UserControl
    {
        EntityContextWithSp entityContextWithSp = new EntityContextWithSp();
        public UC_MainScreen()
        {
            InitializeComponent();
            InitializeData();
            CheckButtonsVisibilityAccordingToRole();
        }

        private void InitializeData()
        {
            NameInfoLabel.Text = SessionManager.Name;
            RoleInfoLabel.Text = SessionManager.Type;

            activeFaultNotificationsGrid.Columns.Add("id", "ID");
            activeFaultNotificationsGrid.Columns.Add("machineName", "MachineName");
            activeFaultNotificationsGrid.Columns.Add("beginDate", "BeginDate");
            activeFaultNotificationsGrid.Columns.Add("creator", "Creator");
            activeFaultNotificationsGrid.Columns.Add("faultTypeLabel", "FaultTypeLabel");
            activeFaultNotificationsGrid.Columns.Add("faultPriorityLabel", "FaultPriorityLabel");
            activeFaultNotificationsGrid.Columns.Add("explanation", "Explanation");
            activeFaultNotificationsGrid.Columns.Add("isStopped", "IsStopped");

            List<GetActiveMachineFaultsResponseDTO> existingList = entityContextWithSp.GetActiveMachineFaults();

            if (existingList != null)
            {
                foreach (var item in existingList)
                {
                    activeFaultNotificationsGrid.Rows.Add(item.id, item.machineName, item.beginDate,
                        item.creator, item.faultTypeLabel, item.faultPriorityLabel, item.explanation, item.isStopped);
                }
            }

        }
        private void AddUC_AddFaultNotificationScreen()

        {
            UC_AddFaultNotificationScreen userControl = new UC_AddFaultNotificationScreen();
            userControl.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(userControl);
            this.Parent.Controls.Remove(this);
        }

        public void AddUC_CompleteActiveFaultNotificationScreen(object sender, EventArgs e)

        {
            if (activeFaultNotificationsGrid.SelectedRows.Count == 1)
            {
               
              
                    int selectedRowIndex = activeFaultNotificationsGrid.SelectedRows[0].Index;

                    if (activeFaultNotificationsGrid.Rows[selectedRowIndex] == null || activeFaultNotificationsGrid.Rows[selectedRowIndex].Cells[0].Value == null)
                    {
                        MessageBox.Show("Lütfen boş satır seçmeyiniz!");
                    }
                    else
                    {
                    DataGridViewRow selectedRow = activeFaultNotificationsGrid.Rows[selectedRowIndex];
                    int id = (int)selectedRow.Cells[0].Value;

                    UC_CompleteActiveFaultNotificationScreen userControl = new UC_CompleteActiveFaultNotificationScreen();
                    userControl.SetMachineFaultId(id);
                    userControl.Dock = DockStyle.Fill;
                    this.Parent.Controls.Add(userControl);
                    this.Parent.Controls.Remove(this);
                    MainForm.currentScreen = "CompleteActiveFaultNotificationScreen";
                    }                                    
            }
            else if (activeFaultNotificationsGrid.SelectedRows.Count > 1)
            {
                MessageBox.Show("Lütfen tek bir satır seçin!");
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin!");
            }

        }



        public void CreateFaultNotificationClick(object sender, EventArgs e)
        {
            UC_AddFaultNotificationScreen userControl = new UC_AddFaultNotificationScreen();
            userControl.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(userControl);
            this.Parent.Controls.Remove(this);
            MainForm.currentScreen = "CreateFaultNotificationScreen";

        }

        private void activeFaultNotificationsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void DeleteFaultNotificationButton_Click(object sender, EventArgs e)
        {
            if (activeFaultNotificationsGrid.SelectedRows.Count == 1)
            {

                int selectedRowIndex = activeFaultNotificationsGrid.SelectedRows[0].Index;
                DataGridViewRow selectedRow = activeFaultNotificationsGrid.Rows[selectedRowIndex];
                int cellValue = (int)selectedRow.Cells[0].Value;

                entityContextWithSp.DeleteMachineFaultById(cellValue);

                MessageBox.Show("Kayıt silindi!");
                ClearDataGridView(activeFaultNotificationsGrid);
                InitializeData();
            }
            else if (activeFaultNotificationsGrid.SelectedRows.Count > 1)
            {
                MessageBox.Show("Lütfen tek satır seçin!");
            }

            else
            {
                MessageBox.Show("Lütfen bir satır seçin!");
            }

        }
        private void ClearDataGridView(DataGridView datagrid)
        {
            datagrid.Rows.Clear();
            datagrid.DataSource = null;
        }

        private void ShowMessageBox(object sender, EventArgs e)
        {
           if(SessionManager.TypeValue == 1)
            {
                MessageBox.Show("Bu arayüzde bakımcı aktif arıza bildirimlerini görüntüler. Eğer bu arıza bildirimine yönelik bir bakım çalışması gerçekleştirdi ise ilgili satırı seçip 'Tamamlandı olarak işaretle' butonuna tıklar.");
            }
           else
            {
                MessageBox.Show("Bu arayüzde üretimci aktif arıza bildirimlerini görüntüler. 'Arıza Bildirimi Oluştur' butonuna tıklayarak yeni bir bildirim oluşturabilir veya yanlış oluşturulduğunu düşündüğü bir bildirim varsa bunu 'Seçilen Arıza Bildirimini Sil' butonuna tıklayarak silebilir.");
            }
        }
        private void CheckButtonsVisibilityAccordingToRole()
        {
            if (SessionManager.TypeValue == 2 || SessionManager.TypeValue == 0)
            {
                CreateFaultNotificationButton.Visible = true;
                DeleteFaultNotificationButton.Visible = true;
                CompleteActiveFaultNotificationButton.Visible = false;
            }
            else if (SessionManager.TypeValue == 1)
            {
                CreateFaultNotificationButton.Visible = false;
                DeleteFaultNotificationButton.Visible = false;
                CompleteActiveFaultNotificationButton.Visible = true;
            }

        }


    }
}
