using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace project
{
    class Connection
    {
        public OleDbConnection connect { get; set; }
        public OleDbCommand command { get; set; }

        private void ConnectionTo()
        {
            connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\tsp project\project\project\Database.accdb");
            command = connect.CreateCommand();
        }

        public Connection()
        {
            ConnectionTo();
        }

        public void InsertLighting(lighting lighting)
        {
            try
            {
                command.CommandText = "INSERT INTO Lightings([Name], Amount, MinAmount, Price, DDS, [Code], [Measure], StorageID) VALUES ('" +
                lighting.Name + "'," + lighting.Amount + "," + lighting.MinAmount + "," + lighting.Price + "," + lighting.DDS + ",'" + lighting.Code + "','" + lighting.Measure + "'," +
                lighting.StorageID + ")";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Incorect Data");
            }
            finally 
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
            
        }

        public void InsertStorage(Storage storage)
        {
            try
            {
                command.CommandText = "INSERT INTO Storage([Name], [Address]) VALUES ('" +
                storage.Name + "','" + storage.Address + "')";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Incorect Data");
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public void CheckDiscount()
        {
            try
            {
                command.CommandText = "SELECT * FROM Lighting WHERE CODE = 'ОТ')";
                command.CommandType = System.Data.CommandType.Text;
                connect.Open();
                //command.ExecuteNonQuery();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Incorect Data");
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }
        
    }
}
