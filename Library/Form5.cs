using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Library
{
    public partial class issueBooks : Form
    {
        public issueBooks()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=db.mdb");
        OleDbCommand cmd = new OleDbCommand();

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.dbDataSet.students);
            // TODO: This line of code loads data into the 'dbDataSet.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.dbDataSet.orders);
            // TODO: This line of code loads data into the 'dbDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.dbDataSet.books);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBooks_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                txtBookID.Text = dgvBooks[0, dgvBooks.CurrentRow.Index].Value.ToString();
            }
            catch { }
        }

        private void dgvOrders_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                txtGetID.Text = dgvOrders[0, dgvOrders.CurrentRow.Index].Value.ToString();
            }
            catch { }
        }

        private void dgvStudents_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                txtStudentID.Text = dgvStudents[0, dgvStudents.CurrentRow.Index].Value.ToString();
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text != "" && txtBookID.Text != "")
            {
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "insert into `orders`(`studentID`, `bookID`, `issuedDate`) values(@a, @b, @c)";
                cmd.Parameters.AddWithValue("@a", txtStudentID.Text);
                cmd.Parameters.AddWithValue("@b", txtBookID.Text);
                cmd.Parameters.AddWithValue("@c", txtDate.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.ordersTableAdapter.Fill(this.dbDataSet.orders);
                MessageBox.Show("اطلاعات با موفقیت ذخیره شد", "پیغام موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentID.Clear();
                txtBookID.Clear();
                txtGetID.Clear();
            }
            else
            {
                MessageBox.Show("فیلد ها نباید خالی باشند", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtGetID.Text != "")
            {
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "insert into `returned`(`studentID`, `bookID`, `issuedDate`) values(@a, @b, @c)";
                cmd.Parameters.AddWithValue("@a", dgvOrders[2, dgvOrders.CurrentRow.Index].Value.ToString());
                cmd.Parameters.AddWithValue("@b", dgvOrders[1, dgvOrders.CurrentRow.Index].Value.ToString());
                cmd.Parameters.AddWithValue("@c", dgvOrders[3, dgvOrders.CurrentRow.Index].Value.ToString());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                int x = int.Parse(txtGetID.Text);
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "delete from orders where ID = @a";
                cmd.Parameters.AddWithValue("@a", x);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.ordersTableAdapter.Fill(this.dbDataSet.orders);
                MessageBox.Show("حذف انجام شد", "پیغام حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentID.Clear();
                txtBookID.Clear();
                txtGetID.Clear();
            }
            else
            {
                MessageBox.Show("فیلد ایدی نباید خالی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
