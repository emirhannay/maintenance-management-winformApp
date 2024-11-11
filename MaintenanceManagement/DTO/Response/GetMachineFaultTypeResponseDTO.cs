using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.DTO.Response
{
    public record GetMachineFaultTypeResponseDTO
    {
        public GetMachineFaultTypeResponseDTO(int value, string label)
        {
            this.value = value;
            this.label = label;
        }

        public int value { get; init; }
        public string label { get; init; }
    }

}
