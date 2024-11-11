using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.DTO.Response
{
    public record GetMachineFaultResponseDTO
    {
        public GetMachineFaultResponseDTO(int id, int machineId, int priority, int type, DateTime beginDate, string explanation, bool isStopped, int creator)
        {
            this.id = id;
            this.machineId = machineId;
            this.priority = priority;
            this.type = type;
            this.beginDate = beginDate;
            this.explanation = explanation;
            this.isStopped = isStopped;
            this.creator = creator;
        }

        public int id {  get; set; }
        public int machineId { get; set; }
        public int priority { get; set; }
        public int type { get; set; }
        public DateTime beginDate { get; set; }
        public string explanation { get; set; }
        public bool isStopped {  get; set; }
        public int creator {  get; set; }   
    }

    
}
