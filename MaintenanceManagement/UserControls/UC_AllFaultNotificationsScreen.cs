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
    public partial class UC_AllFaultNotificationsScreen : UserControl
    {
        EntityContextWithSp entityContext = new EntityContextWithSp();
        public UC_AllFaultNotificationsScreen()
        {
            InitializeComponent();
            InitializeData();
        }
        private void InitializeData()
        {

            AllFaultNotificationsGrid.Columns.Add("id", "ID");
            AllFaultNotificationsGrid.Columns.Add("machineName", "MachineName");
            AllFaultNotificationsGrid.Columns.Add("beginDate", "BeginDate");
            AllFaultNotificationsGrid.Columns.Add("endDate", "EndDate");
            AllFaultNotificationsGrid.Columns.Add("creator", "Creator");
            AllFaultNotificationsGrid.Columns.Add("faultTypeLabel", "FaultTypeLabel");
            AllFaultNotificationsGrid.Columns.Add("faultPriorityLabel", "FaultPriorityLabel");
            AllFaultNotificationsGrid.Columns.Add("explanation", "Explanation");
            AllFaultNotificationsGrid.Columns.Add("isStopped", "IsStopped");




            List<GetAllMachineFaultsResponseDTO> existingList = entityContext.GetAllMachineFaults();


            if (existingList != null)
            {
                foreach (var item in existingList)
                {
                    AllFaultNotificationsGrid.Rows.Add(item.id, item.machineName, item.beginDate, item.endDate,
                        item.creator, item.faultTypeLabel, item.faultPriorityLabel, item.explanation, item.isStopped);
                }
            }
        }

       
    }
}
