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

namespace CosmeticRoom
{
    public partial class ServEditor : Form
    {
        string con = ConfigurationManager.ConnectionStrings["CosmeticRoom.Properties.Settings.CosmeticRoom"].ConnectionString;

        public ServEditor()
        {
            InitializeComponent();
        }

        private void ServEditor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кда позволяет загрузить данные в таблицу "cosmeticRoomDataSet.Masters". При необходимости она может быть перемещена или удалена.
            this.mastersTableAdapter.Fill(this.cosmeticRoomDataSet.Masters);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmeticRoomDataSet.Services". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter.Fill(this.cosmeticRoomDataSet.Services);
            //string query = @" SELECT [MasterID],[MasterName] FROM [dbo].[Masters]";
            //DataTable dt = fillData(query);
            //comboBox1.DataSource = dt;
            //comboBox1.DisplayMember = "MasterName";
            //comboBox1.ValueMember = "MasterID";


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Service s = new Service();
            s.WindowState = this.WindowState;
            this.Hide();
            s.Show();
        }

        private void InsertB_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew() ;
            MessageBox.Show("Вставили новую услугу, заполните данные");

        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSource1.EndEdit();
            this.mastersBindingSource1.EndEdit();
            this.mastersBindingSource.EndEdit();
            this.mastersTableAdapter.Fill(this.cosmeticRoomDataSet.Masters);

            this.tableAdapterManager.UpdateAll(this.cosmeticRoomDataSet);
        }
    }
}
