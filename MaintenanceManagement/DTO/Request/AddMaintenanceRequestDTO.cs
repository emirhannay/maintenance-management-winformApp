using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.DTO.Request
{
    public record AddMaintenanceRequestDTO
    {
        public AddMaintenanceRequestDTO(DateTime plannedDate, int machineId, int type, string explanation)
        {
            this.plannedDate = plannedDate;
            this.machineId = machineId;
            this.type = type;
            this.explanation = explanation;
        }

        public DateTime plannedDate {  get; set; }
        public int machineId { get; set; }
        public int type {  get; set; }
        public string explanation { get; set; }


    }
}
