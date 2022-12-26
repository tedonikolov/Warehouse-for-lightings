using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Connection conn = new Connection();
        

        private void Form4_Load(object sender, EventArgs e)
        {
            DisplayDataSklad();
        }
        private void DisplayDataSklad()
        {
            string mySelect = "select * from Storage";
            OleDbConnection connect = conn.connect;
            connect.Open();
            OleDbDataAdapter adapt = new OleDbDataAdapter(mySelect, connect);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void DisplayDataOTela()
        {
            OleDbConnection connect = conn.connect;
            string mySelect = "select * from Lightings where StorageID=" + id ;
            connect.Open();
            OleDbDataAdapter adapt = new OleDbDataAdapter(mySelect, connect);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            connect.Close();
        }

        int id;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            DisplayDataOTela();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
