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

namespace for1_is_project
{
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9LCQ337;Initial Catalog=bloodsystem;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from [request]", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9LCQ337;Initial Catalog=bloodsystem;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from [request] where date='" + textBox1.Text+"'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Adddonators f5 = new Adddonators();
            f5.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9LCQ337;Initial Catalog=bloodsystem;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from request ", con);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            MessageBox.Show("numbers of donators :"+count.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9LCQ337;Initial Catalog=bloodsystem;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from [request] where user_id='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
