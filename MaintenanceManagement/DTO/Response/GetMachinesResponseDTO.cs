using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.DTO.Response
{
    public record GetMachinesResponseDTO
    {
        public GetMachinesResponseDTO(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int id { get; init; }
        public string name { get; init; }
    }
}
