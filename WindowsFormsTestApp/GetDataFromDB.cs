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

            strRes = @"DELETE FROM [transport].[dbo].[PTS] WHERE [UNTS] = " + id.ToString();

            return strRes;
        }

        public static string updateQueryTS(int id, int tableID, string A, string B, string C)
        {
            string strRes = string.Empty;

            strRes = "UPDATE ";
            strRes += "  [transport].[dbo].[PTS] SET [name] = \'" + A + "\' , [description] = \'" + B + "\' WHERE [UNTS] = " + id.ToString();// + DB_NAME_TABLE;

            return strRes;
        }

        public static string setQueryTS(List<object> list, int tableID)
        {
            string strRes = string.Empty;
            strRes = @"INSERT INTO [transport].[dbo].[PTS] ([stat_id],[object_id],[fire_number],[date_in],[location],[type_id],[mark_id],[factory],[factory_num],[date_crt],[mark_otv]) VALUES (";

            int i = 0;
            if (tableID == 0 || tableID > 2)
                i++;
            for (; i < list.Count; i++)
            {
                strRes = strRes + "@val" + i + ",";
            }
            strRes = strRes.Remove(strRes.Length - 1, 1);
            strRes = strRes + ")";

            return strRes;
        }


        public void DeleteDataFromTable(int id)
        {
            string query = deleteQueryTS(id);
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
        }

        public void UpdateDataFromTable(int id, int tableID, string A, string B, string C)
        {
            string query = updateQueryTS(id, tableID, A, B, C);
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
        }

        public void SetDataToTable(List<object> list, int tableID)
        {
            string query = setQueryTS(list, tableID);
            cmd.CommandText = query;

            cmd.Parameters.Clear();
            int i = 0;
            if (tableID == 0 || tableID > 2)
                i++;
            for (; i < list.Count; i++)
            {
                SqlParameter sqlParameter = new SqlParameter("@val" + i, list[i]);
                cmd.Parameters.Add(sqlParameter);
            }

            int rowCount = cmd.ExecuteNonQuery();
        }
    }




}