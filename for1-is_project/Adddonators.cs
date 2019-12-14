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
    public partial class Adddonators : Form
    {
        public Adddonators()
        {
            InitializeComponent();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        
        Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
            {
                int y; int x = LoginForm.value;
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9LCQ337;Initial Catalog=bloodsystem;Integrated Security=True");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select blood_id from [blood] where blood_type='" + comboBox1.Text + "'", con);
                y = (int)cmd1.ExecuteScalar();
                SqlCommand cmd = new SqlCommand("insert into request (user_id,blood_id,name,date) values (@a,@b,@c,@d) ", con);
                cmd.Parameters.Add("@a", x);
                cmd.Parameters.Add("@b", y);
                cmd.Parameters.Add("@c", textBox1.Text);
                cmd.Parameters.Add("@d", textBox2.Text);
             
               int i= cmd.ExecuteNonQuery();
                   if(i>0)
                {
                    MessageBox.Show("saved");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "";
                }
                   
                con.Close();
            }
            else
            {
                MessageBox.Show("fill all data");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FilterForm f7 = new FilterForm();
            f7.Show();

        }
    }
}
