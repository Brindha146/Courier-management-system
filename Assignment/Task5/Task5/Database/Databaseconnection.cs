using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Database
{
    internal class Databaseconnection
    {
        private readonly SqlConnection sqlcon = null;
        private readonly SqlCommand sqlcmd = null;

        public Databaseconnection()
        {
            sqlcon = new SqlConnection("Server=LAPTOP-9P3K1IU4\\MSSQLSERVER01;Database=Courier Management System;Trusted_Connection=True");
        }
        public List<Courier> Getallcouriers()
        {
            List<Courier> couriers = new List<Courier>();
            sqlcmd.CommandText = "Select * from Courier";
            sqlcmd.Connection = sqlcon;
            sqlcon.Open();
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                Courier courier = new Courier();
                courier.CourierID = (String)reader["courierID"];
                courier.SenderName = (String)reader["Sender"];
                courier.SenderAddress = (String)reader["SenderAddress"];
                courier.ReceiverName = (String)reader["Receiver"];
                courier.ReceiverAddress = (String)reader["ReceiverAddress"];
                courier.Weight = (int)reader["Weight"];
                courier.Status = (String)reader["Status"];
                courier.TrackingNumber = (string)reader["TrackingNumber"];
                courier.UserID = (String)reader["UserID"];
                couriers.Add(courier);
            }
            sqlcon.Close();
            return couriers;
        }
        public int AddCourierValue(Courier courier)
        {
            sqlcmd.CommandText = "Insert into courier values(11,Bree,120 Elm St,Selvam,25 Oak St,25,Delivered,123456,20-03-2024,1)";
            sqlcon.Open();
            int Addcourierstatus = sqlcmd.ExecuteNonQuery();
            return Addcourierstatus;
        }
    }
}
