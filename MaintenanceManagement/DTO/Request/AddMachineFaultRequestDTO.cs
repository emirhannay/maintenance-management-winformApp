using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.DTO.Request
{
  

    public record AddMachineFaultRequestDTO
    {
        public AddMachineFaultRequestDTO(int machineId, int priority, int type, DateTime beginDate, string explanation, bool isStopped, int creator)
        {
            this.machineId = machineId;
            this.priority = priority;
            this.type = type;
            this.beginDate = beginDate;
            this.explanation = explanation;
            this.isStopped = isStopped;
            this.creator = creator;
        }

        public int machineId { get; init; }
        public int priority { get; init; }
        public int type {  get; init; }
        public DateTime beginDate { get; init; }
        public string explanation { get; init; }
        public bool isStopped {    get; init; }
        public int creator {  get; init; }

    

    }
}
