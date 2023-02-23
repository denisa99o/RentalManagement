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
    public partial class BrandModel : Form
    {

        
        DataSet dsBrand;
        DataSet dsModel;

        public BrandModel()
        {
            InitializeComponent();
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Denisuta\Documents\CarRentalDb.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            dsBrand = new DataSet();
            dsModel = new DataSet();
            SqlDataAdapter daBrand= new SqlDataAdapter("SELECT * FROM Brand", Con);
            daBrand.Fill(dsBrand, "Brand");

            SqlDataAdapter daModel = new SqlDataAdapter("SELECT * FROM Model", Con);
            daModel.Fill(dsModel, "Model");
            foreach (DataRow dr in dsBrand.Tables["Brand"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                listBox1_brand.Items.Add(name);
            }
            Con.Close();
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

        private void listBox1_brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2_model.Items.Clear();
            
            int code = 0;
            String BrandSelected = listBox1_brand.SelectedItem.ToString();
            foreach (DataRow dr in dsBrand.Tables["Brand"].Rows)
            {
                if (BrandSelected == dr.ItemArray.GetValue(1).ToString())
                {
                    
                    code = Convert.ToInt16(dr.ItemArray.GetValue(2));
                    textBox_code.Text = code.ToString();
                }
            }
            foreach (DataRow dr in dsModel.Tables["Model"].Rows)
            {
                if (code == Convert.ToInt16(dr.ItemArray.GetValue(1)))
                {
                    String nameFac = dr.ItemArray.GetValue(2).ToString();
                    listBox2_model.Items.Add(nameFac);
                }
            }
        }
    }
}
