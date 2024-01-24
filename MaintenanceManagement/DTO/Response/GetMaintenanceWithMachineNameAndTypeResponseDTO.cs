using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.DTO.Response
{
    public record GetMaintenanceWithMachineNameAndTypeResponseDTO
    {
        public string machineName {  get; set; }
        public int id;
        public int machineId;
        public int type;
        public string explanation;
        public string partUsed;
        public DateTime? plannedDate;
        public DateTime? beginDate;
        public string label;

        public GetMaintenanceWithMachineNameAndTypeResponseDTO(string machineName, int id, int machineId, int type, string explanation, string partUsed, DateTime? plannedDate, DateTime? beginDate, string label)
        {
            this.machineName = machineName;
            this.id = id;
            this.machineId = machineId;
            this.type = type;
            this.explanation = explanation;
            this.partUsed = partUsed;
            this.plannedDate = plannedDate;
            this.beginDate = beginDate;
            this.label = label;
        }

        public GetMaintenanceWithMachineNameAndTypeResponseDTO(string machineName, int id, string explanation, string partUsed, DateTime? plannedDate, DateTime? beginDate, string label)
        {
            this.machineName = machineName;
            this.id = id;
            this.explanation = explanation;
            this.partUsed = partUsed;
            this.plannedDate = plannedDate;
            this.beginDate = beginDate;
            this.label = label;
        }
    }
}
