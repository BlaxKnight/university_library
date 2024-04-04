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
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        private void history_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.returned' table. You can move, or remove it, as needed.
            this.returnedTableAdapter.Fill(this.dbDataSet.returned);
            // TODO: This line of code loads data into the 'dbDataSet.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.dbDataSet.orders);
        }
    }
}
