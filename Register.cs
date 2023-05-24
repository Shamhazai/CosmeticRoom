using CosmeticRoom;
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
    public partial class Register : Form
    {
      
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int countUsernames = (int)loginTableAdapter.GetLoginUsernames(textBox1.Text);
            if (textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Поле не может быть пустым");
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Пароли не совпадают.");
            }
            else if (countUsernames > 0) {
                MessageBox.Show("Такое имя пользователя уже существует.");
            }
            else
            {
                loginTableAdapter.Insert(textBox1.Text, textBox2.Text);
                Login firstPage = new Login();
                firstPage.WindowState = this.WindowState;

                this.Hide();
                firstPage.Show();

            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.WindowState = this.WindowState;
            this.Hide();
            form1.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
