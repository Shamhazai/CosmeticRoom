﻿using System;
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
            // данная строка кда позволяет загрузить данные в таблицу "cosmeticRoomDataSet.Masters". При необходимости она может быть перемещена или удалена.
            this.mastersTableAdapter.Fill(this.cosmeticRoomDataSet.Masters);
            // данная строка кода позволяет загрузить данные в таблицу "cosmeticRoomDataSet.Services". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter.Fill(this.cosmeticRoomDataSet.Services);
            
            ToolTip tip = new ToolTip();
            tip.SetToolTip(serviceNameTextBox,"Введите название услуги");
            tip.SetToolTip(addressTextBox,"Введите адрес");
            tip.SetToolTip(priceMTB,"Введите цену на услугу(не более 100.000 р.)");
            tip.SetToolTip(masterNameComboBox,"Выберете имя мастера");

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
            DialogResult result = MessageBox.Show(
                "Удалить услугу?",
                "Сообщение",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information,
                 MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                bindingSource1.RemoveCurrent();
            }
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            if ((serviceNameTextBox.TextLength == 0) || (addressTextBox.TextLength == 0) || (priceMTB.TextLength == 0) || (masterNameComboBox.Items == null))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {

                this.Validate();
                this.bindingSource1.EndEdit();
                this.mastersBindingSource1.EndEdit();
                this.mastersBindingSource.EndEdit();
                this.mastersTableAdapter.Fill(this.cosmeticRoomDataSet.Masters);

                this.tableAdapterManager.UpdateAll(this.cosmeticRoomDataSet);
                MessageBox.Show("Данные услуги сохранены!");
            }
        }
    }
}
