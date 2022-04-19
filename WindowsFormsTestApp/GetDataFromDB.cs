using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace WindowsFormsTestApp
{
    /// <summary>
    /// Класс для взаимодействия с базой данных
    /// </summary>
    public partial class GetDataFromDB
    {
        SqlConnection sqlConnection;
        SqlCommand cmd;

        /// <summary>
        /// Инициализировать подключение
        /// </summary>
        public void InitConnection()
        {
            DataTable tableRes = new DataTable();

            sqlConnection = new SqlConnection();
            sqlConnection = new SqlConnection("Data Source=localhost; Integrated Security=True;User ID=client;Password=client");
            sqlConnection.Open();

            // Создать объект Command.
            cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
        }

        public static string deleteQueryTS(int id)
        {
            string strRes = string.Empty;

            strRes = @"DELETE FROM [transport].[dbo].[PTS] WHERE [UIN] = " + id.ToString();

            return strRes;
        }

        public static string updateQueryTS(int id, string A, string B, string C)
        {
            string strRes = string.Empty;

            strRes = "UPDATE ";
            strRes += "  [transport].[dbo].[PTS] SET [UNTS] = \'" + A + "\' , [TID] = \'" + B + "\' WHERE [UIN] = " + id.ToString();// + DB_NAME_TABLE;

            return strRes;
        }

        public static string setQueryTS(List<object> list)
        {
            string strRes = string.Empty;
            strRes = @"INSERT INTO [transport].[dbo].[PTS] ([UNTS],[TID],[FIRMID],[GRP],[NORMT],[DATASP]) VALUES (";

            for (int i = 1; i < list.Count; i++)
            {
                strRes = strRes + "@val" + i + ",";
            }
            strRes = strRes.Remove(strRes.Length - 1, 1);
            strRes = strRes + ")";

            return strRes;
        }

        public static string getQueryTS()
        {
            string strRes = string.Empty;

            strRes = "SELECT *";
            strRes += " FROM  [transport].[dbo].[PTS]";
            return strRes;

        }

        /// <summary>
        /// Удаление данных из таблицы
        /// </summary>
        public void DeleteDataFromTable(int id)
        {
            string query = deleteQueryTS(id);
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Изменение данных
        /// </summary>
        public void UpdateDataFromTable(int id, string A, string B, string C)
        {
            string query = updateQueryTS(id, A, B, C);
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Добавление данных
        /// </summary>
        public void SetDataToTable(List<object> list)
        {
            string query = setQueryTS(list);
            cmd.CommandText = query;

            cmd.Parameters.Clear();
            
            for (int i = 1; i < list.Count; i++)
            {
                SqlParameter sqlParameter = new SqlParameter("@val" + i, list[i]);
                cmd.Parameters.Add(sqlParameter);
            }

            int rowCount = cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Получение данных из таблицы
        /// </summary>
        public List<List<object>> GetDataFromTable()
        {
            List<List<object>> tableRes = new List<List<object>>();

            string query = getQueryTS();
            cmd.CommandText = query;
            //cmd.EndExecuteReader();

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        List<object> row = new List<object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row.Add((object)reader.GetValue(i));
                        }
                        tableRes.Add(row);
                    }
                }
                reader.Close();
            }
            return tableRes;
        }
    }




}