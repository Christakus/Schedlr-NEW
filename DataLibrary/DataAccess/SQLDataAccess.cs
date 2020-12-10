using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper; //dapper for SQL connections and functions
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using DataLibrary.Models;

namespace DataLibrary.DataAccess
{
    public static class SQLDataAccess
    {
        // connection string function

        public static string GetConnectionString(string connectionString = "SchedlrDB")
        {
            return ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;

        }

        #region LoadData generic functions to load and save data
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList(); // pulling all data into a list
            }
        }
        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data); // executing sql to database and returns number of rows affected
            }
        }

        public static int DeleteData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {

                return cnn.Execute(sql, data);
            }
        }
        #endregion

        #region LoadEmployee functions to load / save / update employees
        public static List<T> LoadEmployee<T>(string sql, string email)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql, new { data = new string[] { email } }).ToList(); // executing sql to database and returns number of rows affected
            }
        }
        public static List<T> LoadByEmployeeID<T>(string sql, int id)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql, new { data = new int[] { id } }).ToList(); // executing sql to database and returns number of rows affected
            }
        }

        #endregion


        #region LoadShifts functions to load save / update shifts

        public static List<T> LoadShifts<T>(string sql, int id)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql, new { data = new int[] { id } }).ToList(); // getting shifts from db and return as list
            }
        }


        public static List<T> LoadShifts<T>(string sql, string date)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql, new { data = new string[] { date } }).ToList(); // getting shifts by date of shift
            }
        }

        public static void UpdateShift(ShiftModel shift, int id)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            using (IDbCommand command = cnn.CreateCommand())
            {
                command.CommandText = "UPDATE dbo.Shifts SET EmployeeId = @employeeId WHERE ShiftID = @shiftId AND EmployeeId = @firstEmployeeId";

                /* creating parameters for update statement */
                var idParameter = command.CreateParameter();
                idParameter.ParameterName = "@employeeId";
                idParameter.Value = id;
                command.Parameters.Add(idParameter);

                var shiftParameter = command.CreateParameter();
                shiftParameter.ParameterName = "@shiftId";
                shiftParameter.Value = shift.ShiftID;
                command.Parameters.Add(shiftParameter);

                var currentIdParameter = command.CreateParameter();
                currentIdParameter.ParameterName = "@firstEmployeeId";
                currentIdParameter.Value = shift.EmployeeID;
                command.Parameters.Add(currentIdParameter);


                cnn.Open();
                command.ExecuteNonQuery();
                cnn.Close();
            }
        }

        #endregion


        #region LoadMeeting functions to load / save / update meetings
        public static List<T> LoadMeeting<T>(string sql, int id)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql, new { data = new int[] { id } }).ToList(); // getting meetings from db and return as list
            }
        }

        #endregion

        #region LoadNotifications functions to load / save / update notifications
        public static List<T> LoadNotifications<T>(string sql, int id)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql, new { data = new int[] { id } }).ToList(); // getting notifications for user
            }
        }
        /*public static NotificationModel LoadNotification(string sql, int id)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
               List<T> models = cnn.Query<T>(sql, new { data = new int[] { id } });

                return ()Convert.ChangeType(value, typeof(T));
                return 
            }
        }*/

        public static void DeleteNotification(string sql, int id)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            using (IDbCommand command = cnn.CreateCommand())
            {
                command.CommandText = "DELETE FROM dbo.Notification WHERE ID = @id";
                /* creating parameters for update statement */
                var idParameter = command.CreateParameter();
                idParameter.ParameterName = "@id";
                idParameter.Value = id;
                command.Parameters.Add(idParameter);
                cnn.Open();
                command.ExecuteNonQuery();
                cnn.Close();
            }
            #endregion
        }
    }
}

