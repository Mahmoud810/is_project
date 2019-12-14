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
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9LCQ337;Initial Catalog=bloodsystem;Integrated Security=True");
            con.Open();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
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
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";

                    MessageBox.Show("saved");
       
                }
                else
                    MessageBox.Show("erorr in data");
            }
            con.Close();
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
