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
        public Login()
        {
            InitializeComponent();
        }


        private bool UserAuthenticated(string l, string p)
        {
            // Вызов метода GetLogin у объекта loginTableAdapter, который возвращает результат аутентификации пользователя.
            // Предполагается, что метод GetLogin возвращает целочисленное значение.
            try
            {
                int result = (int)loginTableAdapter.GetLogin(l, p);
                // Если результат аутентификации больше нуля, то пользователь аутентифицирован и возвращается значение true
                if (result > 0) return true;
            }
            catch (Exception)
            {
                // Если возникла ошибка при аутентификации (например, исключение), возвращается значение false.
                return false;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Если пользователь успешно аутентифицирован с помощью метода UserAuthenticated,
            // выполняются следующие действия:
            if (UserAuthenticated(textBox1.Text, textBox2.Text))
            {
                Program.login = textBox1.Text;
                Menu menu = new Menu();
                menu.WindowState = this.WindowState;
                this.Hide();
                // Отображение формы Menu.
                menu.Show();
            }
            else
            {
                // Если аутентификация не удалась, выводится сообщение с информацией о некорректном логине или пароле.
                MessageBox.Show("Некорректные логин или пароль");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Закрытие текущей формы.
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register registration = new Register();
            registration.WindowState = this.WindowState;
            this.Hide();
            // Отображение формы Register.
            registration.Show();
        }
    }
}
