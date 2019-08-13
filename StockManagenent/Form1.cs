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

namespace StockManagenent
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.//DESKTOP-MKB2KCB;Initial Catalog="Nimedco Pharmay";Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.add_stockTableAdapter.Fill(this.nimedco_PharmayDataSet.add_stock);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String batchNo = BatchNo.Text.ToString();
                String des = Des.Text.ToString();
                String type = Type.Text.ToString();
                String qut = Qut.Text.ToString();
                String manf = Manf.Text.ToString();
                String sup = Sup.Text.ToString();
                String mfgDate = MfgDate.Text.ToString();

                MessageBox.Show("Success");
                SqlCommand sc = new SqlCommand();

            } catch() {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BatchNo.Text = "";
            this.Des.Text = "";
            this.Type.Text = "";
            this.Manf.Text = "";
            this.Sup.Text = "";
            this.MfgDate.Text = "";
            this.ExpDate.Text = "";
            this.Qut.Text = "";
            this.PurPrice.Text = "";
            this.SalPrice.Text = "";
            this.PurDate.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.SelectedRows
        }
    }
}
