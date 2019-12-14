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
    public partial class Form4 : Form
    {
        public void TotalCupom(string user_name,string pass)
        {
           


        }
     

        public Form4()
        {
            InitializeComponent();
        }

        public static int value=0 ;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9LCQ337;Initial Catalog=bloodsystem;Integrated Security=True");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select user ");
                SqlCommand cmd = new SqlCommand("select user_type from [user_table] where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
                string user_type = (string)cmd.ExecuteScalar();
                if (user_type == "u")
                {
                    SqlDataAdapter da = new SqlDataAdapter("select count(*) from [user_table] where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    SqlCommand cm = new SqlCommand("select [use_id] from [user_table] where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
                    value = (int)cm.ExecuteScalar();
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        Form5 f5 = new Form5();
                        f5.Show();

                    }
                    else
                    {
                        MessageBox.Show("invaulid username or password");
                    }


                }
                else if (user_type == "a")
                {
                    SqlDataAdapter da = new SqlDataAdapter("select count(*) from [user_table] where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        Form6 f6 = new Form6();
                        f6.Show();

                    }
                    else
                    {
                        MessageBox.Show("invaulid username or password");
                    }


                }
                else
                {
                    MessageBox.Show("invaulid username or password");
                }
            }
            else
            {
                MessageBox.Show("fill all textbox");
            }

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }
    }
}
