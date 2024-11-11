using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.DTO.Response
{
    public record GetUpcomingMaintenancesResponseDTO
    {
        public GetUpcomingMaintenancesResponseDTO(int id, string name, int remainingDays, int remainingHours,
            int remainingMinutes, DateTime plannedDate,string explanation,string label)
        {
            this.id = id;
            this.name = name;
            this.remainingDays = remainingDays;
            this.remainingHours = remainingHours;
            this.remainingMinutes = remainingMinutes;
            this.plannedDate = plannedDate;
            this.explanation = explanation;
            this.label = label;
        }

        public int id {  get; set; }
        public string name { get; set; }
        public int remainingDays { get; set; }
        public int remainingHours { get; set; }
        public int remainingMinutes { get; set; }
        public DateTime plannedDate { get; set; }
        public string explanation {  get; set; }
        public string label { get; set; }
    }
}
