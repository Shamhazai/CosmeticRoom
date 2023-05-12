using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmeticRoom
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.WindowState = this.WindowState;
            this.Hide();
            service.Show();
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.MediumVioletRed;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Black;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Program.login = "";
            login.WindowState = this.WindowState;
            this.Hide();
            login.Show();
        }

        private void mastersBtn_Click(object sender, EventArgs e)
        {
            Masters m = new Masters();
            m.WindowState = this.WindowState;
            this.Hide();
            m.Show();
        }

        private void registrationsBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
