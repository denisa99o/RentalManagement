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
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Denisuta\Documents\CarRentalDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void fillcombo()
        {
            Con.Open();
            string query = "select RegNumber from [Car] where Available='"+"Yes"+"'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RegNumber", typeof(string));
            dt.Load(rdr);
            CarRegCb.ValueMember = "RegNumber";
            CarRegCb.DataSource = dt;

            Con.Close();
        }

        private void fillCustomer()
        {
            Con.Open();
            string query = "select CustomerId from [Customer]";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerId", typeof(int));
            dt.Load(rdr);
            CustCb.ValueMember = "CustomerId";
            CustCb.DataSource = dt;

            Con.Close();
        }
        private void CarRegCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void fetchCustName()
        {
            Con.Open();
            string query = "select * from [Customer] where CustomerId=" + CustCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                CustNameTb.Text = dr["CutomerName"].ToString();
            }
            Con.Close();
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from [RentalTbl]";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void UpdateRent()
        {
            Con.Open();
            string query = "update [Car] set Available= '"+"No"+"'  where RegNumber='" + CarRegCb.SelectedValue.ToString() + "';";

            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
          //  MessageBox.Show("Car Successfully Updated");
            Con.Close();
        }
        private void UpdateonRentDelete()
        {
            Con.Open();
            string query = "update [Car] set Available= '"+"Yes"+"'  where RegNumber='" + CarRegCb.SelectedValue.ToString() + "';";

            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            //  MessageBox.Show("Car Successfully Updated");
            Con.Close();
        }
        private void Rental_Load(object sender, EventArgs e)
        {
            fillcombo();
            fillCustomer();
            populate();
        }

        private void CarRegCb_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CustCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCustName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || CustNameTb.Text == "" || FeesTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into [RentalTbl] values("+ IdTb.Text + ", '" + CarRegCb.SelectedValue.ToString()+ "' , '" + CustNameTb.Text + "','" + RentDate.Text + "','" + ReturnDate.Text + "'," + FeesTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Rented");
                    Con.Close();
                    UpdateRent();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    if (IdTb.Text == "")
        //    {
        //        MessageBox.Show("Missing information");

        //    }
        //    else
        //    {
        //        try
        //        {
        //            Con.Open();
        //            string query = "delete from [RentalTbl] where RentId=" + IdTb.Text + ";";
        //            SqlCommand cmd = new SqlCommand(query, Con);
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Rental Deleted Succesfully");
        //            Con.Close();
        //            populate();
        //            UpdateonRentDelete();
        //        }
        //        catch (Exception Myex)
        //        {
        //            MessageBox.Show(Myex.Message);
        //        }aud
        //    }
      //  }

        private void RentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTb.Text = RentDGV.SelectedRows[0].Cells[0].Value.ToString();
            CarRegCb.SelectedValue = RentDGV.SelectedRows[0].Cells[1].Value.ToString();
           // CustNameTb.Text = RentDGV.SelectedRows[0].Cells[3].Value.ToString();
            FeesTb.Text=RentDGV.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
