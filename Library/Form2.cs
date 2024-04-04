using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا قصد دارید از برنامه خارج شوید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void کتابهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new viewBooks().ShowDialog();
        }

        private void دانشآموزهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new viewStudents().ShowDialog();
        }

        private void کتابهایدادهشدهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new issueBooks().ShowDialog();
        }

        private void جزییاتکاملکتابهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new history().ShowDialog();
        }
    }
}
