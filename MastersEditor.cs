﻿using System;
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
    public partial class MastersEditor : Form
    {
        public MastersEditor()
        {
            InitializeComponent();
        }

        private void mastersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mastersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cosmeticRoomDataSet);

        }

        private void MastersEditor_Load(object sender, EventArgs e)
        {
            // данная строка кода позволяет загрузить данные в таблицу "cosmeticRoomDataSet.Masters". При необходимости она может быть перемещена или удалена.
            this.mastersTableAdapter.Fill(this.cosmeticRoomDataSet.Masters);

            ToolTip tip = new ToolTip();
            tip.SetToolTip(masterNameTextBox, "Введите имя мастера");
            tip.SetToolTip(categoryTextBox, "Введите категорию мастера (Первая/Вторая/Третья/Высшая)");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Masters m = new Masters();
            m.WindowState = this.WindowState;
            this.Hide();
            m.Show();
        }

        private void InsertB_Click(object sender, EventArgs e)
        {
            mastersBindingSource.AddNew();
            MessageBox.Show("Вставили нового мастера, заполните данные");

        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Удалить мастера?",
                "Сообщение",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information,
                 MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                mastersBindingSource.RemoveCurrent();
            }
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mastersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cosmeticRoomDataSet);
            MessageBox.Show("Данные мастера сохранены!");
        }
    }
}
