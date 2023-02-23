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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Denisuta\Documents\CarRentalDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from [Car]";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (RegNoTb.Text == "" || BrandTb.Text == "" || ModelTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into [Car] values('" + RegNoTb.Text + "', '" + BrandTb.Text + "' , '" + ModelTb.Text + "','" + AvailableCb.SelectedItem.ToString() + "'," + PriceTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Added");
                    Con.Close();
                   populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

      
        private void Car_Load(object sender, EventArgs e)
        {
            populate();
          //  fillAvailable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RegNoTb.Text == "")
            {
                MessageBox.Show("Missing information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from [Car] where RegNumber='" + RegNoTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Deleted Succesfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void CarDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RegNoTb.Text = CarDGV.SelectedRows[0].Cells[0].Value.ToString();
            BrandTb.Text = CarDGV.SelectedRows[0].Cells[1].Value.ToString();
            ModelTb.Text = CarDGV.SelectedRows[0].Cells[2].Value.ToString();
            AvailableCb.SelectedItem = CarDGV.SelectedRows[0].Cells[3].Value.ToString();
            PriceTb.Text = CarDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RegNoTb.Text == "" || BrandTb.Text == "" || ModelTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update [Car] set Brand='" + BrandTb.Text + "',Model='" + ModelTb.Text + "', Available= '"+AvailableCb.SelectedItem.ToString()+"',Price="+PriceTb.Text+" where RegNumber='" + RegNoTb.Text + "';";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Updated");
                    Con.Close();
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

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string flag = "";
            if (Search.SelectedItem.ToString() == "Available")
            {
                flag = "Yes";
            }
            else
            {
                flag = "No";
            }
            Con.Open();
            string query = "select * from [Car] where Available ='"+flag+"' ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
    }
}
