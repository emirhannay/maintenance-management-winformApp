using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.DTO.Response
{
    public record GetAllMachineFaultsResponseDTO
    {

        public GetAllMachineFaultsResponseDTO(int id, string machineName, int machineId, int faultTypeValue, int faultPriorityValue,
          DateTime beginDate,DateTime? endDate, string faultTypeLabel, string faultPriorityLabel, string explanation, string creator, bool isStopped)
        {
            this.id = id;
            this.machineName = machineName;
            this.machineId = machineId;
            this.faultTypeValue = faultTypeValue;
            this.faultPriorityValue = faultPriorityValue;
            this.beginDate = beginDate;
            this.faultTypeLabel = faultTypeLabel;
            this.faultPriorityLabel = faultPriorityLabel;
            this.explanation = explanation;
            this.creator = creator;
            this.isStopped = isStopped;
            this.endDate = endDate;
        }

        public GetAllMachineFaultsResponseDTO(int id, string machineName, int machineId, int faultTypeValue, int faultPriorityValue,
          DateTime beginDate,  string faultTypeLabel, string faultPriorityLabel, string explanation, string creator, bool isStopped)
        {
            this.id = id;
            this.machineName = machineName;
            this.machineId = machineId;
            this.faultTypeValue = faultTypeValue;
            this.faultPriorityValue = faultPriorityValue;
            this.beginDate = beginDate;
            this.faultTypeLabel = faultTypeLabel;
            this.faultPriorityLabel = faultPriorityLabel;
            this.explanation = explanation;
            this.creator = creator;
            this.isStopped = isStopped;
        }

        public int id { get; set; }

        public string machineName { get; set; }
        public int machineId { get; init; }

        public int faultTypeValue { get; init; }
        public int faultPriorityValue { get; init; }

        public DateTime beginDate { get; init; }
        public DateTime? endDate { get; init; }
        public string creator { get; init; }

        public string faultTypeLabel { get; init; }
        public string faultPriorityLabel { get; init; }
        public string explanation { get; init; }
        public bool isStopped { get; set; }
    }
}
