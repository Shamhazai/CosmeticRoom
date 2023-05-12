using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CosmeticRoom
{
    public partial class Login : Form
    {

        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CosmeticRoom.Properties.Settings.CosmeticRoom"].ConnectionString);
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private bool UserAuthenticated(string l, string p)
        {
            try
            {
                int result = (int)loginTableAdapter.GetLogin(l, p);
                if (result > 0) return true;
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from Login where UserName = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'";
            //cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //con.Close();



            if (UserAuthenticated(textBox1.Text, textBox2.Text))
            {
                Program.login = textBox1.Text;
                Menu menu = new Menu();
                menu.WindowState = this.WindowState;
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Некорректные логин или пароль");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register registration = new Register();
            registration.WindowState = this.WindowState;
            this.Hide();
            registration.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
