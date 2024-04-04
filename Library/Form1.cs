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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=db.mdb");
        OleDbCommand cmd = new OleDbCommand();

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "نام کاربری")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "رمز عبور")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int i = 0;
            cmd = new OleDbCommand("select Count(*) from users where username = @N AND password = @F", con);
            cmd.Parameters.AddWithValue("@N", txtUsername.Text);
            cmd.Parameters.AddWithValue("@F", txtPassword.Text);
            con.Open();
            i = (int)cmd.ExecuteScalar();
            if (i > 0)
            {
                new Dashboard().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("کاربری با این مشخصات وجود ندارد", "پیغام خطا");
            }
        }
    }
}
