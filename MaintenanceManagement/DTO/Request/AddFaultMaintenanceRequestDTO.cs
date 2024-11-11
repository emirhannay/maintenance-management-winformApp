using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.DTO.Request
{


    public record AddFaultMaintenanceRequestDTO
    {
        public AddFaultMaintenanceRequestDTO(int machineId, string explanation, string partUsed, DateTime beginDate,
            DateTime endDate, int machineFaultId)
        {
            this.machineId = machineId;
            this.explanation = explanation;
            this.partUsed = partUsed;
            this.beginDate = beginDate;
            this.endDate = endDate;
            this.machineFaultId = machineFaultId;
        }

        public int machineId { get; init; }
        public string explanation { get; init; }
        public string partUsed { get; init; }
        public DateTime beginDate { get; init; }
        public DateTime endDate { get; init; }
        public int machineFaultId { get; init; }



    }
}
