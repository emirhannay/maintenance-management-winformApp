using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.DTO.Request
{
    public record UserRegisterRequestDTO
    {
       

        public string Name { get; init; }
        public string Username { get; init; }
        public string Password { get; init; }
        public int Type { get; init; }

        public int MaintenanceManType { get; init; }

        public UserRegisterRequestDTO(string name, string username, string password, int type )
        {
            Name = name;
            Username = username;
            Password = password;
            Type = type;
        }
        public UserRegisterRequestDTO(string name, string username, string password, int type, int maintenanceManType)
        {
            Name = name;
            Username = username;
            Password = password;
            Type = type;
            MaintenanceManType = maintenanceManType;
        }
    }
}
