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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9LCQ337;Initial Catalog=bloodsystem;Integrated Security=True");
            con.Open();
            if(textBox1.Text==""|| textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == ""||textBox9.Text == "")
            {
                MessageBox.Show("fill all textbox");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into user_table(name,city,e_mail,gender,username,password,age,request_date,phone)values(@name,@city,@e_mail,@gender,@username,@password,@age,@request_date,@phone)", con);
                cmd.Parameters.Add("@name", textBox1.Text);
                cmd.Parameters.Add("@city", textBox2.Text);
                cmd.Parameters.Add("@e_mail", textBox3.Text);
                cmd.Parameters.Add("@gender", comboBox1.Text);
                cmd.Parameters.Add("@username", textBox5.Text);
                cmd.Parameters.Add("@password", textBox6.Text);
                cmd.Parameters.Add("@age", textBox7.Text);
                cmd.Parameters.Add("@request_date", textBox8.Text);
                cmd.Parameters.Add("@phone", textBox9.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("compelet insert");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                display_data();
            }
        }
        public void display_data()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9LCQ337;Initial Catalog=bloodsystem;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from user_table",con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


        private void Form6_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9LCQ337;Initial Catalog=bloodsystem;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from [user_table] where use_id='"+dataGridView1.SelectedRows[0].Cells[0].Value+"'", con);
            cmd.ExecuteNonQuery();
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            con.Close();
            MessageBox.Show("deleted");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9LCQ337;Initial Catalog=bloodsystem;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update  [user_table] set password='"+textBox10.Text+"' where use_id='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'", con);
            cmd.ExecuteNonQuery();
            display_data();
            con.Close();
            MessageBox.Show("Updated3");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
