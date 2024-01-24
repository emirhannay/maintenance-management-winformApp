using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.DTO.Request
{
    public record UserLoginRequestDTO
    {
       
        public string Username { get; init; }
        public string Password { get; init; }

        public UserLoginRequestDTO(string username, string password)
        {
            Username = username;
            Password = password;
        }

    }
}
