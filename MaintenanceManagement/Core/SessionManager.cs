using MaintenanceManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.Core
{
    public static class SessionManager
    {
        public static int Id { get; set; }
        public static string Name {  get; set; }
        public static string Username { get; private set; }
        public static string Password { get; private set; }
        public static String Type { get; private set; }

        public static int TypeValue { get; private set; }



        public static void StartSession(string name, string username, string password, int id, string typeName, int typeValue)
        {
            Id = id;
            Username = username;
            Name = name;
            Password = password;
            Type = typeName;
            TypeValue = typeValue;


        }

        public static void EndSession()
        {
            Username = null;
        }

        public static bool IsSessionActive()
        {
            return !string.IsNullOrEmpty(Username);
        }
    }
}
