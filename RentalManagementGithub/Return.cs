﻿using System;
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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Denisuta\Documents\CarRentalDb.mdf;Integrated Security=True;Connect Timeout=30");

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

        private void populateRet()
        {
            Con.Open();
            string query = "select * from [ReturnTbl]";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReturnDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void DeleteonReturn()
        {
            int rentId;
            rentId  = Convert.ToInt32(RentDGV.SelectedRows[0].Cells[0].Value.ToString());
            Con.Open();
            string query = "delete from [RentalTbl] where RentId=" + rentId+ ";";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
           // MessageBox.Show("Rental Deleted Succesfully");
            Con.Close();
            populate();
            //UpdateonRentDelete();
        }

        private void Return_Load(object sender, EventArgs e)
        {
            populate();
            populateRet();
        }

        private void RentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            CarIdTb.Text = RentDGV.SelectedRows[0].Cells[1].Value.ToString();
            CustNameTb.Text = RentDGV.SelectedRows[0].Cells[2].Value.ToString();
            ReturnDate.Text= RentDGV.SelectedRows[0].Cells[4].Value.ToString();
            DateTime d1 = ReturnDate.Value.Date;
            DateTime d2 = DateTime.Now;
            TimeSpan t = d2 - d1;
            int NrOfDays = Convert.ToInt32(t.TotalDays);
            if(NrOfDays <= 0)
            {
                DelayTb.Text = "No Delay";
                FineTb.Text = "0";
            }
            else
            {
                DelayTb.Text = "" + NrOfDays;
                FineTb.Text = "" + (NrOfDays * 250);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || CustNameTb.Text == "" || FineTb.Text=="" || DelayTb.Text=="" || DelayTb.Text=="")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into [ReturnTbl] values(" + IdTb.Text + ", '" + CarIdTb.Text + "' ,'" + CustNameTb.Text + "','" + ReturnDate.Text + "', '" + DelayTb.Text + "','" + FineTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Dully Returned");
                    Con.Close();
                   // UpdateRent();
                    populateRet();
                    DeleteonReturn();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
    }
}
