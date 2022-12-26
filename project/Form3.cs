using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Connection conn = new Connection();

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            OleDbConnection connect = conn.connect;
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT Lightings.Name, Lightings.Price, Lightings.Code FROM Lightings WHERE (((Lightings.Code)='ОТ'))", connect);
                command.Parameters.AddWithValue("@1", listBox1.Text);
                connect.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    double price = double.Parse(reader[1].ToString());
                    price = Math.Round(price * 0.95,2);
                    listBox1.Items.Add(reader[0].ToString());
                    listBox2.Items.Add(price);    
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
