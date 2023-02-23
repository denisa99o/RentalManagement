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
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Denisuta\Documents\CarRentalDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Dash_Load(object sender, EventArgs e)
        {
            string querycar = "select Count(*) from [Car]";
            SqlDataAdapter sda = new SqlDataAdapter(querycar,Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Carlbl.Text = dt.Rows[0][0].ToString();

            string querycust = "select Count(*) from [Customer]";
            SqlDataAdapter sda1 = new SqlDataAdapter(querycust, Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Custlbl.Text = dt1.Rows[0][0].ToString();

            string queryuser = "select Count(*) from [User]";
            SqlDataAdapter sda2 = new SqlDataAdapter(queryuser, Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            Userlbl.Text = dt2.Rows[0][0].ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();

        }
    }
}
