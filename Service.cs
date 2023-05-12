using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CosmeticRoom
{
    public partial class Service : Form
    {

        string con = ConfigurationManager.ConnectionStrings["CosmeticRoom.Properties.Settings.CosmeticRoom"].ConnectionString;

        public Service()
        {
            InitializeComponent();
        }


        private void Service_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmeticRoomDataSet.Masters". При необходимости она может быть перемещена или удалена.
            this.mastersTableAdapter.Fill(this.cosmeticRoomDataSet.Masters);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmeticRoomDataSet.Services". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter.Fill(this.cosmeticRoomDataSet.Services);

            if (!Program.isAdminUser())
            {
                AddServBtn.Visible = false;
            } else
            {
                AddServBtn.Visible = true;
            }

        }


        private void AddServBtn_Click(object sender, EventArgs e)
        {
            ServEditor servE = new ServEditor();
            servE.WindowState = this.WindowState;

            this.Hide();
            servE.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.WindowState = this.WindowState;

            this.Hide();
            menu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            servicesBindingSource.Filter = "MasterID='" + filterComboBox.SelectedValue.ToString() + "'";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //перебирает все ячейки таблицы и устанавливает в них белый цвет фона
            // и чёрный цвет текста, то есть отменяет результаты предыдущего поиска
            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    dataGridView1[i, j].Style.BackColor = Color.White;
                    dataGridView1[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    if (dataGridView1[i, j].Value.ToString().IndexOf(searchTextBox.Text) != -1)
                    {
                        dataGridView1[i, j].Style.BackColor = Color.AliceBlue;
                        dataGridView1[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private DataGridViewColumn getSortCol()
        {
            DataGridViewColumn col = new DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    col = serviceNameDataGridViewTextBoxColumn;
                    break;
                case 1:
                    col = addressDataGridViewTextBoxColumn; break;
                case 2:
                    col = priceDataGridViewTextBoxColumn; break;

            }
            return col;
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            servicesBindingSource.RemoveFilter();
        }

        private void sortDownBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(getSortCol(), System.ComponentModel.ListSortDirection.Descending);
        }

        private void sortUpBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(getSortCol(), System.ComponentModel.ListSortDirection.Ascending);

        }
    }
}
