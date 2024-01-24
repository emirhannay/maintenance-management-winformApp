using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.DTO.Response
{
    public record GetCompletedMachineFaultsAccordingToMachineResponseDTO
    {
        public int id;
        public int machineId;
        public string machineName;
        public string faultPriorityLabel;
        public string faultTypeLabel;
        public DateTime beginDate;
        public string explanation;
        public bool isStopped;
        public string userName;
        public string solution;
        public int solutionTime;

        public GetCompletedMachineFaultsAccordingToMachineResponseDTO(int id, int machineId, string machineName, string faultPriorityLabel,
            string faultTypeLabel, DateTime beginDate, string explanation, bool isStopped, string userName,
            string solution, int solutionTime)
        {
            this.id = id;
            this.machineId = machineId;
            this.machineName = machineName;
            this.faultPriorityLabel = faultPriorityLabel;
            this.faultTypeLabel = faultTypeLabel;
            this.beginDate = beginDate;
            this.explanation = explanation;
            this.isStopped = isStopped;
            this.userName = userName;
            this.solution = solution;
            this.solutionTime = solutionTime;
        }
    }
}
