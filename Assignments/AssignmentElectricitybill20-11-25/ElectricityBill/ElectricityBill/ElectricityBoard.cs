using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ElectricityBill
{
    public class ElectricityBoard
    {
        public void CalculateBill(ElectricityBill bill)
        {
            int unitsRemaining = bill.UnitsConsumed;
            double totalAmount = 0;

            unitsRemaining -= Math.Min(100, unitsRemaining);

            if (unitsRemaining > 0)
            {
                int slabUnits = Math.Min(200, unitsRemaining);
                totalAmount += slabUnits * 1.5;
                unitsRemaining -= slabUnits;
            }

            if (unitsRemaining > 0)
            {
                int slabUnits = Math.Min(300, unitsRemaining);
                totalAmount += slabUnits * 3.5;
                unitsRemaining -= slabUnits;
            }

            if (unitsRemaining > 0)
            {
                int slabUnits = Math.Min(400, unitsRemaining);
                totalAmount += slabUnits * 5.5;
                unitsRemaining -= slabUnits;
            }

            if (unitsRemaining > 0)
            {
                totalAmount += unitsRemaining * 7.5;
            }

            bill.BillAmount = totalAmount;
        }

        public void AddBill(ElectricityBill bill)
        {
            DBHandler dbHandler = new DBHandler();
            using (SqlConnection connection = dbHandler.GetConnection())
            {
                string insertQuery = "insert into ElectricityBill " +
                                     "(consumer_number, consumer_name, units_consumed, bill_amount) " +
                                     "VALUES (@number, @name, @units, @amount)";

                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@number", bill.ConsumerNumber);
                command.Parameters.AddWithValue("@name", bill.ConsumerName);
                command.Parameters.AddWithValue("@units", bill.UnitsConsumed);
                command.Parameters.AddWithValue("@amount", bill.BillAmount);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<ElectricityBill> GetLastNBills(int count)
        {
            List<ElectricityBill> billsList = new List<ElectricityBill>();
            DBHandler dbHandler = new DBHandler();

            using (SqlConnection connection = dbHandler.GetConnection())
            {
                string selectQuery = "select top (@count) * from ElectricityBill order by consumer_number DESC";
                SqlCommand command = new SqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@count", count);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ElectricityBill bill = new ElectricityBill
                    {
                        ConsumerNumber = reader["consumer_number"].ToString(),
                        ConsumerName = reader["consumer_name"].ToString(),
                        UnitsConsumed = Convert.ToInt32(reader["units_consumed"]),
                        BillAmount = Convert.ToDouble(reader["bill_amount"])
                    };

                    billsList.Add(bill);
                }
            }

            return billsList;
        }
    }
}









public class DBHandler
{
    public SqlConnection GetConnection()
    {
        string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ElectricityBilling;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connStr);
        return conn;
    }
}