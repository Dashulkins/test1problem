using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace Test1.Models
{
    public class DBregulator
    {

        public static T ConvertValues<T>(object obj)
        {
            if (obj == null || obj == DBNull.Value)
            {
                return default(T);
            }
            else
            {
                return (T)obj;
            }
        }

        public FireFighter ReturnFireFighter()
        {
            using (var con = new SqlConnection("Data Source = db - mssql; Initial Catalog = s22297; Integrated Security = True"))
            using (var com = new SqlCommand())
            {
                com.Connection = con;
                com.CommandText = "Select *  from  FireFighter";
                con.Open();
                var dr = com.ExecuteReader();
                FireFighter fireFighter = null;
                while (dr.Read())
                {
                    fireFighter = new FireFighter
                    {
                        idFireFighter = (int)dr["idFirefighter"],
                        FirstName = (string)dr["FirstName"],
                        LastName = (string)dr["SecondName"]

                    };
                    Console.WriteLine(fireFighter.LastName + " " + fireFighter.FirstName);
                }

                return fireFighter;
            }

        }
    }
}
