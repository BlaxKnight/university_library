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
    public partial class viewStudents : Form
    {
        public viewStudents()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=db.mdb");
        OleDbCommand cmd = new OleDbCommand();

        private void view_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.dbDataSet.students);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا می خواهید انصراف دهید", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text != "" && txtStudentName.Text != "" && txtStudentAddress.Text != "" && txtStudentNumber.Text != "" && txtStudentEmail.Text != "")
            {
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "insert into `students`(`name`, `address`, `phone`, `email`) values(@a, @b, @c, @d)";
                cmd.Parameters.AddWithValue("@a", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@b", txtStudentAddress.Text);
                cmd.Parameters.AddWithValue("@c", txtStudentNumber.Text);
                cmd.Parameters.AddWithValue("@d", txtStudentEmail.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.studentsTableAdapter.Fill(this.dbDataSet.students);
                MessageBox.Show("اطلاعات با موفقیت ذخیره شد", "پیغام موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentID.Clear();
                txtStudentName.Clear();
                txtStudentAddress.Clear();
                txtStudentNumber.Clear();
                txtStudentEmail.Clear();
            }
            else
            {
                MessageBox.Show("فیلد ها نباید خالی باشند", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text != "" && txtStudentName.Text != "" && txtStudentAddress.Text != "" && txtStudentNumber.Text != "" && txtStudentEmail.Text != "" && int.Parse(txtStudentID.Text) > 0)
            {
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "Update students Set name='" + txtStudentName.Text + "',address='" + txtStudentAddress.Text + "',phone='" + txtStudentNumber.Text + "',email='" + txtStudentEmail.Text + "' where ID = " + int.Parse(txtStudentID.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.studentsTableAdapter.Fill(this.dbDataSet.students);
                MessageBox.Show("ویرایش انجام شد", "پیغام ویرایش", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فیلد ها نباید خالی باشند", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text != "" && int.Parse(txtStudentID.Text) > 0)
            {
            try{
                int x = int.Parse(txtStudentID.Text);
                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "delete from students where ID = @N";
                cmd.Parameters.AddWithValue("@N", x);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.studentsTableAdapter.Fill(this.dbDataSet.students);
                MessageBox.Show("حذف انجام شد", "پیغام حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentID.Clear();
                txtStudentName.Clear();
                txtStudentAddress.Clear();
                txtStudentNumber.Clear();
                txtStudentEmail.Clear();
            }
            catch { }
            }
            else
            {
                MessageBox.Show("فیلد ایدی نباید خالی باشند", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvStudents_MouseUp(object sender, MouseEventArgs e)
        {
            try{
            txtStudentID.Text = dgvStudents[0, dgvStudents.CurrentRow.Index].Value.ToString();
            txtStudentName.Text = dgvStudents[1, dgvStudents.CurrentRow.Index].Value.ToString();
            txtStudentAddress.Text = dgvStudents[2, dgvStudents.CurrentRow.Index].Value.ToString();
            txtStudentNumber.Text = dgvStudents[3, dgvStudents.CurrentRow.Index].Value.ToString();
            txtStudentEmail.Text = dgvStudents[4, dgvStudents.CurrentRow.Index].Value.ToString();
            }
            catch { }
        }

        private void txtStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
