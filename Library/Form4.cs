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
    public partial class viewBooks : Form
    {
        public viewBooks()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=db.mdb");
        OleDbCommand cmd = new OleDbCommand();
        private void viewBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.dbDataSet.books);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.dbDataSet.books);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (bID.Text != "" && bname.Text != "" && bauthor.Text != "" && bpubl.Text != "" && bdate.Text != "" && bprice.Text != "" && bq.Text != "" && int.Parse(bID.Text) > 0)
            {
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "Update books Set name='" + bname.Text + "',author='" + bauthor.Text + "',publication='" + bpubl.Text + "',[date]='" + bdate.Text + "',price='" + int.Parse(bprice.Text) + "',q='" + int.Parse(bq.Text) + "' where ID = " + int.Parse(bID.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            this.booksTableAdapter.Fill(this.dbDataSet.books);
            MessageBox.Show("ویرایش انجام شد", "پیغام ویرایش", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فیلد ها نباید خالی باشند", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bID.Text != "" && int.Parse(bID.Text) > 0)
            {
            try{
            int x = int.Parse(bID.Text);
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "delete from books where ID = @N";
            cmd.Parameters.AddWithValue("@N", x);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            this.booksTableAdapter.Fill(this.dbDataSet.books);
            MessageBox.Show("حذف انجام شد", "پیغام حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bID.Clear();
            bname.Clear();
            bauthor.Clear();
            bpubl.Clear();
            bprice.Clear();
            bq.Clear();
            }
            catch { }
            }
            else
            {
                MessageBox.Show("فیلد ایدی نباید خالی باشند", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا می خواهید انصراف دهید", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dgvBooks_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                bID.Text = dgvBooks[0, dgvBooks.CurrentRow.Index].Value.ToString();
                bname.Text = dgvBooks[1, dgvBooks.CurrentRow.Index].Value.ToString();
                bauthor.Text = dgvBooks[2, dgvBooks.CurrentRow.Index].Value.ToString();
                bpubl.Text = dgvBooks[3, dgvBooks.CurrentRow.Index].Value.ToString();
                bdate.Text = dgvBooks[4, dgvBooks.CurrentRow.Index].Value.ToString();
                bprice.Text = dgvBooks[5, dgvBooks.CurrentRow.Index].Value.ToString();
                bq.Text = dgvBooks[6, dgvBooks.CurrentRow.Index].Value.ToString();
            }
            catch { }
        }

        private void bprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bname.Text != "" && bauthor.Text != "" && bpubl.Text != "" && bdate.Text != "" && bprice.Text != "" && bq.Text != "")
            {
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "insert into `books`(`name`, `author`, `publication`, `date`, `price`, `q`) values(@a, @b, @c, @d, @e, @f)";
                cmd.Parameters.AddWithValue("@a", bname.Text);
                cmd.Parameters.AddWithValue("@b", bauthor.Text);
                cmd.Parameters.AddWithValue("@c", bpubl.Text);
                cmd.Parameters.AddWithValue("@d", bdate.Text);
                cmd.Parameters.AddWithValue("@e", bprice.Text);
                cmd.Parameters.AddWithValue("@f", bq.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.booksTableAdapter.Fill(this.dbDataSet.books);
                MessageBox.Show("اطلاعات با موفقیت ذخیره شد", "پیغام موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bID.Clear();
                bname.Clear();
                bauthor.Clear();
                bpubl.Clear();
                bprice.Clear();
                bq.Clear();
            }
            else
            {
                MessageBox.Show("فیلد ها نباید خالی باشند", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا می خواهید انصراف دهید", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void bID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
