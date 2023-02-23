using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RentalManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Denisuta\Documents\CarRentalDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label6_Click(object sender, EventArgs e)
        {
            Uname.Text = "";
            PassTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select Count(*) from [User] where UserName='" + Uname.Text + "' and UserPass='" + PassTb.Text + "'";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            Con.Close();
        }
    }
}
