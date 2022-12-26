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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void осветителниТелаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.Show();
        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.Show();
        }

        private void намалениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form3();
            frm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void осветителниТелаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Form5();
            frm.Show();
        }

        private void складToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Form4();
            frm.Show();
        }
    }
}
