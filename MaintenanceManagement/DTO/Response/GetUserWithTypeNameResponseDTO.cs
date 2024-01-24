using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.DTO.Response
{
    internal class GetUserWithTypeNameResponseDTO
    {
        public GetUserWithTypeNameResponseDTO(int id, string name, string username, string password, int type, string typeName)
        {

            this.id = id;
            this.name = name;
            this.username = username;
            this.password = password;
            this.type = type;
            this.typeName = typeName;
        }
        public int id { get; set; }
        public string name { get; init; }
        public string username { get; init; }
        public string password { get; init; }
        public int type { get; init; }
        public string typeName {  get; init; }

    }
}
