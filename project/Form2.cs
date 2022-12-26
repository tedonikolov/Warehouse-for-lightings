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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Connection conn = new Connection();

        private void button1_Click(object sender, EventArgs e)
        {
            Storage storage = new Storage();

            storage.Name = textBox1.Text;
            storage.Address = textBox2.Text;

            conn.InsertStorage(storage);
        }
    }
}
