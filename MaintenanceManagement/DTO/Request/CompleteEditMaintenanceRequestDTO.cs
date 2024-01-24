using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.DTO.Request
{
    public record CompleteEditMaintenanceRequestDTO
    {
        public CompleteEditMaintenanceRequestDTO(int maintenanceId, string explanation = null, string partUsed = null, DateTime? beginDate = null, DateTime? endDate = null, int? completedBy = null)
        {
            this.maintenanceId = maintenanceId;
            this.explanation = explanation;
            this.partUsed = partUsed;
            this.beginDate = beginDate;
            this.endDate = endDate;
            this.completedBy = completedBy;
        }

        public int maintenanceId { get; set; }
        public string explanation { get; set; }
        public string partUsed { get; set; }
        public DateTime? beginDate { get; set; }
        public DateTime? endDate { get; set; }
        public int? completedBy { get; set; }
    }

}
