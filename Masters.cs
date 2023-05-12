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
    public partial class Masters : Form
    {
        public Masters()
        {
            InitializeComponent();
        }

        private void mastersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mastersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cosmeticRoomDataSet);

        }

        private void Masters_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cosmeticRoomDataSet.Masters". При необходимости она может быть перемещена или удалена.
            this.mastersTableAdapter.Fill(this.cosmeticRoomDataSet.Masters);

            if (!Program.isAdminUser())
            {
                EditBtn.Visible = false;
            }
            else
            {
                EditBtn.Visible = true;
            }


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.WindowState = this.WindowState;

            this.Hide();
            menu.Show();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            MastersEditor me = new MastersEditor();
            me.WindowState = this.WindowState;

            this.Hide();
            me.Show();
        }



        private void filterBtn_Click(object sender, EventArgs e)
        {
            mastersBindingSource.Filter = "Category='" + filterComboBox.SelectedItem.ToString() + "'";
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
                    col = masterNameDataGridViewTextBoxColumn;
                    break;
                case 1:
                    col = categoryDataGridViewTextBoxColumn;
                    break;

            }
            return col;
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            mastersBindingSource.RemoveFilter();
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
