using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.DTO.Response
{
    internal class GetCompletedMaintenancesResponseDTO
    {
        public GetCompletedMaintenancesResponseDTO(int machineId, int maintenanceId, string machineName, string label, string explanation,
            string partUsed, DateTime? plannedDate, DateTime beginDate, DateTime endDate, int userId, string completedBy)
        {
            this.machineId = machineId;
            this.maintenanceId = maintenanceId;
            this.machineName = machineName;
            this.label = label;
            this.explanation = explanation;
            this.partUsed = partUsed;
            this.plannedDate = plannedDate;
            this.beginDate = beginDate;
            this.endDate = endDate;
            this.userId = userId;
            this.completedBy = completedBy;
        }

        public int machineId {  get; set; }
        public int maintenanceId {  get; set; }
        public string machineName {  get; set; }
        public string label {  get; set; }
        public string explanation {  get; set; }
        public string partUsed { get; set; }
        public DateTime? plannedDate {  get; set; }
        public DateTime beginDate { get; set; }
        public DateTime endDate { get; set; }
        public int userId {  get; set; }
        public string completedBy {  get; set; }
    }
}
