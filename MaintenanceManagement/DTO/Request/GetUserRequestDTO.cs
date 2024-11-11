using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.DTO.Request
{
    public record GetUserRequestDTO
    {

        public string Username { get; init; }

        public GetUserRequestDTO(string username )
        {
            Username = username;
            
        }

    }
}
