using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Connection connect = new Connection();

        private void button1_Click(object sender, EventArgs e)
        {
            lighting lightning = new lighting();

            lightning.Name = textBox2.Text;
            lightning.Amount = textBox3.Text;
            lightning.MinAmount = textBox4.Text;
            lightning.Price = textBox5.Text;
            lightning.DDS = textBox6.Text;
            lightning.Code = textBox7.Text;
            lightning.Measure = textBox8.Text;
            lightning.StorageID = textBox9.Text;

            connect.InsertLighting(lightning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new Form3();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
