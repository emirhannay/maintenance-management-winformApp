using MaintenanceManagement.Core;
using MaintenanceManagement.DTO.Request;
using MaintenanceManagement.DTO.Response;
using MaintenanceManagement.DTO.Response.MaintenanceManagement.DTO.Response;


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MaintenanceManagement.Repository
{
    internal class EntityContextWithSp
    {
        private readonly static string connectionString = @"Server=DESKTOP-NPET4RG\TEW_SQLEXPRESS;Database=MaintenanceManagement;Integrated Security=True; Encrypt = False";
        //private static SqlConnection sqlConnection;
        public void AddUser(UserRegisterRequestDTO request) {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                
                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("AddUser", sqlConnection); // sp_adi, çalıştırmak istediğiniz stored procedure'ün adıdır
                    command.CommandType = CommandType.StoredProcedure;

                    if (request.MaintenanceManType == 0)
                    {                                         
                        command.Parameters.AddWithValue("@Name", request.Name);
                        command.Parameters.AddWithValue("@Username", request.Username);
                        command.Parameters.AddWithValue("@Password", request.Password);
                        command.Parameters.AddWithValue("@Type", request.Type);
                        int rowsAffected = command.ExecuteNonQuery();
                        Debug.WriteLine("Stored procedure başarıyla tetiklendi. Etkilenen satır sayısı: " + rowsAffected);
                        
                    }
                    else
                    {                                             
                        command.Parameters.AddWithValue("@Name", request.Name);
                        command.Parameters.AddWithValue("@Username", request.Username);
                        command.Parameters.AddWithValue("@Password", request.Password);
                        command.Parameters.AddWithValue("@Type", request.Type);
                        command.Parameters.AddWithValue("@MaintenanceManType", request.MaintenanceManType);
                        int rowsAffected = command.ExecuteNonQuery();
                        Debug.WriteLine("Stored procedure başarıyla tetiklendi. Etkilenen satır sayısı: " + rowsAffected);
                        
                    }
                    sqlConnection.Close();

                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }

        }


        public GetUserResponseDTO GetUser(GetUserRequestDTO getUserRequestDTO)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
               
                try
                {
                    //OpenConnection();
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("GetUser", sqlConnection); // sp_adi, çalıştırmak istediğiniz stored procedure'ün adıdır
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", getUserRequestDTO.Username);
    

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Console.WriteLine($"{reader["Name"]}, {reader["Username"]}");
                       
                        int id = (int) reader["Id"];
                        string name = Convert.ToString(reader["Name"]);
                        string username = Convert.ToString(reader["Username"]);
                        string password = Convert.ToString(reader["Password"]);
                        int type = Convert.ToInt32(reader["Type"]);
                        //CloseConnection();
                        sqlConnection.Close();
                        reader.Close();
                        return new GetUserResponseDTO(id,name,username,password,type);
                    }
                    else
                    {
                        throw new Exception();
                    }



                }
                catch (Exception ex)
                {
                    //CloseConnection();
                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                    return null;
                }
            }


        }

        public GetUserWithTypeNameResponseDTO GetUserWithTypeName(GetUserRequestDTO getUserRequestDTO)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                try
                {
                    //OpenConnection();
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("GetUserWithTypeName", sqlConnection); // sp_adi, çalıştırmak istediğiniz stored procedure'ün adıdır
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", getUserRequestDTO.Username);


                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Console.WriteLine($"{reader["Name"]}, {reader["Username"]}");

                        int id = (int)reader["Id"];
                        string name = Convert.ToString(reader["Name"]);
                        string username = Convert.ToString(reader["Username"]);
                        string password = Convert.ToString(reader["Password"]);
                        int type = Convert.ToInt32(reader["Type"]);
                        string typeName = Convert.ToString(reader["TypeName"]);
                        //CloseConnection();
                        sqlConnection.Close();
                        reader.Close();
                        return new GetUserWithTypeNameResponseDTO(id, name, username, password, type, typeName);
                    }
                    else
                    {
                        throw new Exception();
                    }



                }
                catch (Exception ex)
                {
                    //CloseConnection();
                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                    return null;
                }
            }


        }

        public List<GetUserTypesRequestDTO> GetUserTypes()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    //OpenConnection();
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("GetUserTypes", sqlConnection); // sp_adi, çalıştırmak istediğiniz stored procedure'ün adıdır
                    command.CommandType = CommandType.StoredProcedure;
                    
                    

                    SqlDataReader reader = command.ExecuteReader();

                    List<GetUserTypesRequestDTO> data = new List<GetUserTypesRequestDTO>();
                    while (reader.Read())
                    {


                        int id = (int)reader["Id"];
                        string paramCode = Convert.ToString(reader["ParamCode"]);
                        string label = Convert.ToString(reader["Label"]);
                        int value = Convert.ToInt32(reader["Value"]);

                        data.Add(new GetUserTypesRequestDTO(id, paramCode, label, value));
                    }
                    reader.Close();
                    //CloseConnection();
                    sqlConnection.Close();
                    return data;

                }
                catch (Exception ex)
                {
                    //CloseConnection();
                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                    return null;
                }

            }
        }

        public List<GetMaintenanceManTypesResponseDTO> GetMaintenanceManTypes()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    //OpenConnection();
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("GetMaintenanceManTypes", sqlConnection); // sp_adi, çalıştırmak istediğiniz stored procedure'ün adıdır
                    command.CommandType = CommandType.StoredProcedure;



                    SqlDataReader reader = command.ExecuteReader();

                    List<GetMaintenanceManTypesResponseDTO> data = new List<GetMaintenanceManTypesResponseDTO>();
                    while (reader.Read())
                    {
                        string label = Convert.ToString(reader["Label"]);
                        int value = Convert.ToInt32(reader["Value"]);

                        data.Add(new GetMaintenanceManTypesResponseDTO(value,label));
                    }
                    reader.Close();
                    //CloseConnection();
                    sqlConnection.Close();
                    return data;

                }
                catch (Exception ex)
                {
                    //CloseConnection();
                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                    return null;
                }

            }
        }

        public List<GetMachinesResponseDTO> GetMachines()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                   
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("GetMachines", sqlConnection); // sp_adi, çalıştırmak istediğiniz stored procedure'ün adıdır
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();

                    List<GetMachinesResponseDTO> data = new List<GetMachinesResponseDTO>();
                    while (reader.Read())
                    {
                        string name = Convert.ToString(reader["Name"]);
                        int id = Convert.ToInt32(reader["Id"]);

                        data.Add(new GetMachinesResponseDTO(id, name));
                    }
                    reader.Close();
                    sqlConnection.Close();

                    return data;

                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                    return null;
                }

            }
        }

        public List<GetActiveMachineFaultsResponseDTO> GetActiveMachineFaults() {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {

                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("GetActiveMachineFaults", sqlConnection); 
                    command.CommandType = CommandType.StoredProcedure;



                    SqlDataReader reader = command.ExecuteReader();

                    List<GetActiveMachineFaultsResponseDTO> data = new List<GetActiveMachineFaultsResponseDTO>();
                    while (reader.Read())
                    {


                        int id = (int)reader["Id"];
                        string machineName = (string)reader["MachineName"];
                        int machineId = (int)reader["MachineId"];
         
                        DateTime beginDate = (DateTime) reader["BeginDate"];

                        string creator = (string)reader["Creator"];

                        int faultTypeValue = (int)reader["FaultTypeValue"];
                        int faultPriorityValue = (int)reader["FaultPriorityValue"];
                        

                        string faultPriorityLabel = (string)reader["FaultPriorityLabel"];
                        string faultTypeLabel = (string)reader["FaultTypeLabel"];                
                     
                        string explanation = (string)reader["Explanation"];
                        bool isStopped = (bool)reader["isStopped"];


               data.Add(new GetActiveMachineFaultsResponseDTO(id, machineName, machineId, faultTypeValue, faultPriorityValue, beginDate,faultTypeLabel,faultPriorityLabel,explanation,creator, isStopped));
                    }
                    reader.Close();
                    sqlConnection.Close();
                    return data;

                }
                catch (Exception ex)
                {

                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                    return null;
                }

            }



        }

        public List<GetMachineFaultPriorityResponseDTO> GetMachineFaultPriority()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("GetMachineFaultPriority", sqlConnection); 
                    command.CommandType = CommandType.StoredProcedure;



                    SqlDataReader reader = command.ExecuteReader();

                    List<GetMachineFaultPriorityResponseDTO> data = new List<GetMachineFaultPriorityResponseDTO>();
                    while (reader.Read())
                    {
                        string label = Convert.ToString(reader["Label"]);
                        int value = Convert.ToInt32(reader["Value"]);

                        data.Add(new GetMachineFaultPriorityResponseDTO(value, label));
                    }
                    reader.Close();
                    //CloseConnection();
                    sqlConnection.Close();
                    return data;

                }
                catch (Exception ex)
                {
                    //CloseConnection();
                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                    return null;
                }

            }
        }

        public List<GetMachineFaultTypeResponseDTO> GetMachineFaultType()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {

                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("GetMachineFaultType", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();

                    List<GetMachineFaultTypeResponseDTO> data = new List<GetMachineFaultTypeResponseDTO>();
                    while (reader.Read())
                    {
                        string label = Convert.ToString(reader["Label"]);
                        int value = Convert.ToInt32(reader["Value"]);

                        data.Add(new GetMachineFaultTypeResponseDTO(value, label));
                    }
                    reader.Close();
                    sqlConnection.Close();
                    return data;
                }

                catch (Exception ex)
                {
                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                    return null;
                }

            }
        }

        public List<GetMachineFaultTypeResponseDTO> GetMaintenanceType()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {

                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("GetMaintenanceType", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();

                    List<GetMachineFaultTypeResponseDTO> data = new List<GetMachineFaultTypeResponseDTO>();
                    while (reader.Read())
                    {
                        string label = Convert.ToString(reader["Label"]);
                        int value = Convert.ToInt32(reader["Value"]);

                        if(value == 0)
                        {
                            continue;
                        }
                        data.Add(new GetMachineFaultTypeResponseDTO(value, label));
                    }
                    reader.Close();
                    sqlConnection.Close();
                    return data;
                }

                catch (Exception ex)
                {
                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                    return null;
                }

            }
        }

        public void AddMachineFault(AddMachineFaultRequestDTO request)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("AddMachineFault", sqlConnection); // sp_adi, çalıştırmak istediğiniz stored procedure'ün adıdır
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MachineId", request.machineId);
                    command.Parameters.AddWithValue("@Priority", request.priority);
                    command.Parameters.AddWithValue("@Type ", request.type);
                    command.Parameters.AddWithValue("@BeginDate", request.beginDate);
                    command.Parameters.AddWithValue("@Explanation ", request.explanation);
                    command.Parameters.AddWithValue("@IsStopped ", request.isStopped);
                    command.Parameters.AddWithValue("@Creator", request.creator);

                    int rowsAffected = command.ExecuteNonQuery();
                    Debug.WriteLine("Stored procedure başarıyla tetiklendi. Etkilenen satır sayısı: " + rowsAffected);
                    sqlConnection.Close();


                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }

        }

        public void DeleteMachineFaultById(int id) {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("DeleteMachineFaultById", sqlConnection); 
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }

        }


        public void AddMaintenance(AddMaintenanceRequestDTO request)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("AddMaintenance", sqlConnection); 
                    command.CommandType = CommandType.StoredProcedure;
                    
                    command.Parameters.AddWithValue("@MachineId", request.machineId);
                    command.Parameters.AddWithValue("@Explanation", request.explanation);
                    command.Parameters.AddWithValue("@PlannedDate", request.plannedDate);
                    command.Parameters.AddWithValue("@Type", request.type);
                    command.Parameters.AddWithValue("@Creator", SessionManager.Id);

                    int rowsAffected = command.ExecuteNonQuery();
                    Debug.WriteLine("Stored procedure başarıyla tetiklendi. Etkilenen satır sayısı: " + rowsAffected);
                    sqlConnection.Close();

                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }

        }
        public void CompleteEditMaintenance(CompleteEditMaintenanceRequestDTO request)

        { 
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("CompleteEditMaintenance", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaintenanceId", request.maintenanceId);
                    command.Parameters.AddWithValue("@Explanation", request.explanation);
                    command.Parameters.AddWithValue("@PartUsed", request.partUsed);
                    command.Parameters.AddWithValue("@BeginDate", request.beginDate);
                    command.Parameters.AddWithValue("@EndDate", request.endDate);
                    command.Parameters.AddWithValue("@CompletedBy", request.completedBy);


                    int rowsAffected = command.ExecuteNonQuery();
                    Debug.WriteLine("Stored procedure başarıyla tetiklendi. Etkilenen satır sayısı: " + rowsAffected);
                    sqlConnection.Close();

                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }

        }

        public void AddFaultMaintenance(AddFaultMaintenanceRequestDTO request)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("AddMaintenance", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MachineId", request.machineId);
                    command.Parameters.AddWithValue("@Explanation", request.explanation);
                    command.Parameters.AddWithValue("@PartUsed", request.partUsed);
                    command.Parameters.AddWithValue("@BeginDate", request.beginDate);
                    command.Parameters.AddWithValue("@EndDate", request.endDate);
                    command.Parameters.AddWithValue("@MachineFaultId", request.machineFaultId);
                    command.Parameters.AddWithValue("@Creator", SessionManager.Id);

                    int rowsAffected = command.ExecuteNonQuery();
                    Debug.WriteLine("Stored procedure başarıyla tetiklendi. Etkilenen satır sayısı: " + rowsAffected);
                    sqlConnection.Close();

                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }

        }

        public GetMachineFaultResponseDTO GetMachineFaultById(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                { 
                   sqlConnection.Open();
                    SqlCommand command = new SqlCommand("GetMachineFault", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {                    
                        int faultId = (int)reader["Id"];
                        int machineId = (int)reader["MachineId"];
                        int priority = (int)reader["Priority"];
                        int type = (int)reader["Type"];
                        DateTime beginDate = (DateTime) reader["BeginDate"];
                        string explanation = (string) reader["Explanation"];                 
                        bool isStopped = (bool)reader["isStopped"];
                        int creator = (int)reader["Creator"];

                        sqlConnection.Close();
                        reader.Close();
                        return new GetMachineFaultResponseDTO(faultId,machineId,priority,type,beginDate,explanation,isStopped,creator);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                 
                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                    return null;
                }
            }


        }

        public List<GetMaintenanceWithMachineNameAndTypeResponseDTO> GetMaintenanceWithMachineNameAndType( )
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("GetMaintenanceWithMachineNameAndType", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    List<GetMaintenanceWithMachineNameAndTypeResponseDTO> response = new List<GetMaintenanceWithMachineNameAndTypeResponseDTO>();
                    while (reader.Read())
                    {
                        string machineName = (string)reader["MachineName"];
                        int id = (int)reader["Id"];
                        int machineId = (int)reader["MachineId"];
                        int type = (int)reader["Type"];
                        string explanation = null;
                        string partUsed = null;
                        DateTime? plannedDate = null;
                        DateTime? beginDate = null;
                        if (reader["Explanation"] != DBNull.Value)
                        {
                            explanation = (string)reader["Explanation"];
                        }
                        if (reader["PartUsed"] != DBNull.Value)
                        {
                            partUsed = (string)reader["PartUsed"];
                        }
                        if (reader["PlannedDate"] != DBNull.Value)
                        {
                            plannedDate = (DateTime?)reader["PlannedDate"];
                        }
                        if (reader["BeginDate"] != DBNull.Value)
                        {
                            beginDate = (DateTime?)reader["BeginDate"];
                        }

                        string label = (string)reader["Label"];

                        
                        
                        response.Add(new GetMaintenanceWithMachineNameAndTypeResponseDTO(machineName, id, machineId, type,
                             explanation, partUsed, plannedDate, beginDate, label));
                    }
                    sqlConnection.Close();
                    reader.Close();
                    return response;
                }
                catch (Exception ex)
                {

                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                    return null;
                }
            }


        }


        public List<GetUpcomingMaintenancesResponseDTO> GetUpcomingMaintenances()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("GetUpcomingMaintenances", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    List<GetUpcomingMaintenancesResponseDTO> responseData = new List<GetUpcomingMaintenancesResponseDTO>();
                    while (reader.Read())
                    {
                        int id = (int)reader["Id"];
                        string machineName = (string)reader["Name"];
                        int remainingDays = (int)reader["RemainingDays"];
                        int remainingHours = (int)reader["RemainingHours"];
                        int remainingMinutes = (int)reader["RemainingMinutes"];
                        DateTime plannedDate = (DateTime) reader["PlannedDate"];
                        string explanation = (string)reader["Explanation"];
                        string label = (string)reader["Label"];
                        
                        responseData.Add(new GetUpcomingMaintenancesResponseDTO(id,machineName,remainingDays,remainingHours,remainingMinutes,plannedDate,explanation,label));
                    }

                    sqlConnection.Close();
                    reader.Close();

                    return responseData;
                }
                catch (Exception ex)
                {

                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                    return null;
                }
            }


        }

        public List<GetAllMachineFaultsResponseDTO> GetAllMachineFaults() {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {

                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("GetAllMachineFaults", sqlConnection); 
                    command.CommandType = CommandType.StoredProcedure;



                    SqlDataReader reader = command.ExecuteReader();

                    List<GetAllMachineFaultsResponseDTO> data = new List<GetAllMachineFaultsResponseDTO>();
                    while (reader.Read())
                    {


                        int id = (int)reader["Id"];
                        string machineName = (string)reader["MachineName"];
                        int machineId = (int)reader["MachineId"];
         
                        DateTime beginDate = (DateTime) reader["BeginDate"];
                        DateTime? endDate = null;
                        if (reader["EndDate"] != DBNull.Value)
                        {
                            endDate = (DateTime?)reader["EndDate"];
                        }
                        
                        string creator = (string)reader["Creator"];

                        int faultTypeValue = (int)reader["FaultTypeValue"];
                        int faultPriorityValue = (int)reader["FaultPriorityValue"];
                        

                        string faultPriorityLabel = (string)reader["FaultPriorityLabel"];
                        string faultTypeLabel = (string)reader["FaultTypeLabel"];                
                     
                        string explanation = (string)reader["Explanation"];
                        bool isStopped = (bool)reader["isStopped"];


               data.Add(new GetAllMachineFaultsResponseDTO(id, machineName, machineId, faultTypeValue, faultPriorityValue, beginDate,endDate,faultTypeLabel,faultPriorityLabel,explanation,creator, isStopped));
                    }
                    reader.Close();
                    sqlConnection.Close();
                    return data;

                }
                catch (Exception ex)
                {

                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                    return null;
                }

            }



        }

        public List<GetCompletedMaintenancesResponseDTO> GetCompletedMaintenances(int machineId,DateTime beginDate,DateTime endDate)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("GetCompletedMaintenancesAccordingToMachine", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MachineId", machineId);
                    command.Parameters.AddWithValue("@DateTimeBegin", beginDate);
                    command.Parameters.AddWithValue("@DateTimeEnd", endDate);
                    SqlDataReader reader = command.ExecuteReader();
                    List<GetCompletedMaintenancesResponseDTO> responseData = new List<GetCompletedMaintenancesResponseDTO>();
                    
                    
                    while (reader.Read())
                    {
                        
                        int macId = (int)reader["MachineId"];
                        int maintenanceId = (int)reader["MaintenanceId"];
                        string name = (string)reader["Name"];
                        string label = (string)reader["Label"];
                        string explanation = (string)reader["Explanation"];
                        string partUsed = (string)reader["PartUsed"];
                        DateTime? plannedDate = null;
                        if (reader["PlannedDate"] != DBNull.Value)
                        {
                            plannedDate = (DateTime) reader["PlannedDate"];
                        }
                        DateTime startDate = (DateTime)reader["BeginDate"];
                        DateTime finishDate = (DateTime)reader["EndDate"];
                        int userId = (int)reader["UserId"];
                        string completedBy = (string)reader["CompletedBy"];

                        
                        
                        responseData.Add(new GetCompletedMaintenancesResponseDTO(macId, maintenanceId, name, label, explanation, partUsed, plannedDate, startDate, finishDate, userId, completedBy));
                    }
                    sqlConnection.Close();
                    reader.Close();
                    return responseData;
                }
                catch (Exception ex)
                {

                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                    return null;
                }
            }


        }

         public List<GetCompletedMachineFaultsAccordingToMachineResponseDTO> GetCompletedMachineFaults(int machineId,DateTime beginDate,DateTime endDate)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand("GetCompletedMachineFaultsAccordingToMachine", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MachineId", machineId);
                    command.Parameters.AddWithValue("@DateTimeBegin", beginDate);
                    command.Parameters.AddWithValue("@DateTimeEnd", endDate);
                    SqlDataReader reader = command.ExecuteReader();
                    List<GetCompletedMachineFaultsAccordingToMachineResponseDTO> responseData = new List<GetCompletedMachineFaultsAccordingToMachineResponseDTO>();
                    while (reader.Read())
                    {

                        int id = (int)reader["Id"];
                        int macId = (int)reader["MachineId"];
                        string name = (string)reader["Name"];
                        string faultPriorityLabel = (string)reader["FaultPriorityLabel"];
                        string faultTypeLabel = (string)reader["FaultTypeLabel"];
                        DateTime partUsed = (DateTime)reader["BeginDate"];
                        string explanation = (string)reader["Explanation"];
                        bool isStopped = (bool)reader["isStopped"];
                        string userName = (string)reader["UserName"];
                        string solution = (string)reader["Solution"];
                        int solutionTime = (int)reader["SolutionTime"];

                        responseData.Add(new GetCompletedMachineFaultsAccordingToMachineResponseDTO(id, macId, name,
                            faultPriorityLabel, faultTypeLabel, partUsed, explanation, isStopped, userName, solution, solutionTime));
                    }
                    sqlConnection.Close();
                    reader.Close();
                    return responseData;
                }
                catch (Exception ex)
                {

                    sqlConnection.Close();
                    Console.WriteLine("Hata: " + ex.Message);
                    return null;
                }
            }


        }






        //public List<GetUserTypesRequestDTO> GetUserTypes()
        //{
        //    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            //OpenConnection();
        //            sqlConnection.Open();
        //            SqlCommand command = new SqlCommand("GetUserTypes", sqlConnection); // sp_adi, çalıştırmak istediğiniz stored procedure'ün adıdır
        //            command.CommandType = CommandType.StoredProcedure;



        //            SqlDataReader reader = command.ExecuteReader();

        //            List<GetUserTypesRequestDTO> data = new List<GetUserTypesRequestDTO>();
        //            while (reader.Read())
        //            {


        //                int id = (int)reader["Id"];
        //                string paramCode = Convert.ToString(reader["ParamCode"]);
        //                string label = Convert.ToString(reader["Label"]);
        //                int value = Convert.ToInt32(reader["Value"]);

        //                data.Add(new GetUserTypesRequestDTO(id, paramCode, label, value));
        //            }
        //            reader.Close();
        //            //CloseConnection();
        //            sqlConnection.Close();
        //            return data;

        //        }
        //        catch (Exception ex)
        //        {
        //            //CloseConnection();
        //            sqlConnection.Close();
        //            Console.WriteLine("Hata: " + ex.Message);
        //            return null;
        //        }

        //    }
        //}




    }
}
