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
using Microsoft.Office.Interop.Excel;

namespace CosmeticRoom
{
    public partial class Service : Form
    {
        // Переменная con содержит строку подключения к базе данных из файла конфигурации.
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

            // Проверка, является ли текущий пользователь администратором и установка видимости кнопки AddServBtn в зависимости от этого.
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
            // Обработчик события клика на кнопку AddServBtn. Отображает форму ServEditor.
            ServEditor servE = new ServEditor();
            servE.WindowState = this.WindowState;

            this.Hide();
            servE.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Обработчик события клика на кнопку Назад. Отображает форму Menu.
            Menu menu = new Menu();
            menu.WindowState = this.WindowState;

            this.Hide();
            menu.Show();
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            // Применение фильтра к servicesBindingSource по значению выбранному в filterComboBoxServ.
            servicesBindingSource.Filter = "MasterID='" + filterComboBoxServ.SelectedValue.ToString() + "'";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Счетчик найденных результатов поиска.
            int count = 0;
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
                    if (dataGridView1[i, j].Value.ToString().IndexOf(searchTextBoxServ.Text) != -1)
                    {
                        dataGridView1[i, j].Style.BackColor = Color.AliceBlue;
                        dataGridView1[i, j].Style.ForeColor = Color.Blue;
                        count++;
                    }
                }
            }
            // Если ни один результат не найден, выводится сообщение с информацией об отсутствии результатов.
            if (count == 0)
            {
                MessageBox.Show("К сожалению не нашли такую услугу");
            }
        }

        private DataGridViewColumn getSortCol()
        {
            // Возвращает выбранный пользователем столбец сортировки в dataGridView1.
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
            // Удаление фильтра из servicesBindingSource для отображения всех записей.
            servicesBindingSource.RemoveFilter();
        }

        private void sortDownBtn_Click(object sender, EventArgs e)
        {
            // Сортировка dataGridView1 по выбранному столбцу в порядке убывания.
            dataGridView1.Sort(getSortCol(), System.ComponentModel.ListSortDirection.Descending);
        }

        private void sortUpBtn_Click(object sender, EventArgs e)
        {
            // Сортировка dataGridView1 по выбранному столбцу в порядке возрастания.
            dataGridView1.Sort(getSortCol(), System.ComponentModel.ListSortDirection.Ascending);

        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обработчик события клика на пункт меню "Экспорт". Создает и отображает Excel-приложение и экспортирует данные из dataGridView1 в него.
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 15;

            ExcelApp.Cells[1, 1] = "Название";
            ExcelApp.Cells[1, 2] = "Адрес";
            ExcelApp.Cells[1, 3] = "Цена";
            ExcelApp.Cells[1, 4] = "ID мастера";

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    ExcelApp.Cells[j + 2, i + 1] = (dataGridView1[i, j].Value).ToString();
                }
            }
            ExcelApp.Visible = true;
        }
    }
}
