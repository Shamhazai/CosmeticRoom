namespace CosmeticRoom
{
    partial class ServEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label serviceIDLabel;
            System.Windows.Forms.Label serviceNameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label masterNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServEditor));
            this.deleteB = new System.Windows.Forms.Button();
            this.saveB = new System.Windows.Forms.Button();
            this.InsertB = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cosmeticRoomDataSet = new CosmeticRoom.CosmeticRoomDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.servicesTableAdapter = new CosmeticRoom.CosmeticRoomDataSetTableAdapters.ServicesTableAdapter();
            this.tableAdapterManager = new CosmeticRoom.CosmeticRoomDataSetTableAdapters.TableAdapterManager();
            this.mastersTableAdapter = new CosmeticRoom.CosmeticRoomDataSetTableAdapters.MastersTableAdapter();
            this.serviceIDTextBox = new System.Windows.Forms.TextBox();
            this.serviceNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.mastersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.masterNameComboBox = new System.Windows.Forms.ComboBox();
            this.mastersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            serviceIDLabel = new System.Windows.Forms.Label();
            serviceNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            masterNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticRoomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceIDLabel
            // 
            serviceIDLabel.AutoSize = true;
            serviceIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            serviceIDLabel.Location = new System.Drawing.Point(19, 16);
            serviceIDLabel.Name = "serviceIDLabel";
            serviceIDLabel.Size = new System.Drawing.Size(72, 16);
            serviceIDLabel.TabIndex = 15;
            serviceIDLabel.Text = "Service ID:";
            // 
            // serviceNameLabel
            // 
            serviceNameLabel.AutoSize = true;
            serviceNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            serviceNameLabel.Location = new System.Drawing.Point(19, 66);
            serviceNameLabel.Name = "serviceNameLabel";
            serviceNameLabel.Size = new System.Drawing.Size(96, 16);
            serviceNameLabel.TabIndex = 16;
            serviceNameLabel.Text = "Service Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.Location = new System.Drawing.Point(19, 116);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(61, 16);
            addressLabel.TabIndex = 18;
            addressLabel.Text = "Address:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceLabel.Location = new System.Drawing.Point(19, 166);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(41, 16);
            priceLabel.TabIndex = 20;
            priceLabel.Text = "Price:";
            // 
            // masterNameLabel
            // 
            masterNameLabel.AutoSize = true;
            masterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            masterNameLabel.Location = new System.Drawing.Point(19, 216);
            masterNameLabel.Name = "masterNameLabel";
            masterNameLabel.Size = new System.Drawing.Size(91, 16);
            masterNameLabel.TabIndex = 25;
            masterNameLabel.Text = "Master Name:";
            // 
            // deleteB
            // 
            this.deleteB.BackColor = System.Drawing.Color.Crimson;
            this.deleteB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.deleteB.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteB.Location = new System.Drawing.Point(268, 452);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(163, 35);
            this.deleteB.TabIndex = 14;
            this.deleteB.Text = "Удалить";
            this.deleteB.UseVisualStyleBackColor = false;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // saveB
            // 
            this.saveB.BackColor = System.Drawing.Color.White;
            this.saveB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveB.FlatAppearance.BorderSize = 0;
            this.saveB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.saveB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveB.Location = new System.Drawing.Point(446, 452);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(131, 35);
            this.saveB.TabIndex = 13;
            this.saveB.Text = "💾 Сохранить";
            this.saveB.UseVisualStyleBackColor = false;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // InsertB
            // 
            this.InsertB.BackColor = System.Drawing.Color.MediumVioletRed;
            this.InsertB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.InsertB.ForeColor = System.Drawing.SystemColors.Control;
            this.InsertB.Location = new System.Drawing.Point(102, 452);
            this.InsertB.Name = "InsertB";
            this.InsertB.Size = new System.Drawing.Size(147, 35);
            this.InsertB.TabIndex = 12;
            this.InsertB.Text = "Вставить";
            this.InsertB.UseVisualStyleBackColor = false;
            this.InsertB.Click += new System.EventHandler(this.InsertB_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1105, 25);
            this.bindingNavigator1.TabIndex = 15;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Services";
            this.bindingSource1.DataSource = this.cosmeticRoomDataSet;
            // 
            // cosmeticRoomDataSet
            // 
            this.cosmeticRoomDataSet.DataSetName = "CosmeticRoomDataSet";
            this.cosmeticRoomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.MastersTableAdapter = this.mastersTableAdapter;
            this.tableAdapterManager.ServiceRegistrationTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = this.servicesTableAdapter;
            this.tableAdapterManager.UpdateOrder = CosmeticRoom.CosmeticRoomDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mastersTableAdapter
            // 
            this.mastersTableAdapter.ClearBeforeFill = true;
            // 
            // serviceIDTextBox
            // 
            this.serviceIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "ServiceID", true));
            this.serviceIDTextBox.Location = new System.Drawing.Point(179, 19);
            this.serviceIDTextBox.Name = "serviceIDTextBox";
            this.serviceIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.serviceIDTextBox.TabIndex = 16;
            // 
            // serviceNameTextBox
            // 
            this.serviceNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "ServiceName", true));
            this.serviceNameTextBox.Location = new System.Drawing.Point(179, 69);
            this.serviceNameTextBox.Name = "serviceNameTextBox";
            this.serviceNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.serviceNameTextBox.TabIndex = 17;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(179, 119);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 19;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(179, 169);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 21;
            // 
            // mastersBindingSource1
            // 
            this.mastersBindingSource1.AllowNew = false;
            this.mastersBindingSource1.DataMember = "Masters";
            this.mastersBindingSource1.DataSource = this.cosmeticRoomDataSet;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.masterNameComboBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(masterNameLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.serviceIDTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(serviceIDLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(serviceNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.priceTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(priceLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.serviceNameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(addressLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.addressTextBox, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(99, 157);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 282);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // masterNameComboBox
            // 
            this.masterNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource1, "MasterID", true));
            this.masterNameComboBox.DataSource = this.mastersBindingSource1;
            this.masterNameComboBox.DisplayMember = "MasterName";
            this.masterNameComboBox.FormattingEnabled = true;
            this.masterNameComboBox.Location = new System.Drawing.Point(179, 219);
            this.masterNameComboBox.Name = "masterNameComboBox";
            this.masterNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.masterNameComboBox.TabIndex = 26;
            this.masterNameComboBox.ValueMember = "MasterID";
            // 
            // mastersBindingSource
            // 
            this.mastersBindingSource.DataMember = "Services_Masters";
            this.mastersBindingSource.DataSource = this.bindingSource1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 32F);
            this.label1.Location = new System.Drawing.Point(23, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 49);
            this.label1.TabIndex = 24;
            this.label1.Text = " ✏️ Редактирование услуг";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBack.Location = new System.Drawing.Point(12, 512);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(154, 41);
            this.buttonBack.TabIndex = 25;
            this.buttonBack.Text = "← Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(102, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(24, 0, 16, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Вставка, изменение, удаление и сохранение";
            // 
            // ServEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 617);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.InsertB);
            this.Name = "ServEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServEditor";
            this.Load += new System.EventHandler(this.ServEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticRoomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Button InsertB;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CosmeticRoomDataSet cosmeticRoomDataSet;
        private CosmeticRoomDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private CosmeticRoomDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox serviceIDTextBox;
        private System.Windows.Forms.TextBox serviceNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.BindingSource mastersBindingSource1;
        private System.Windows.Forms.BindingSource mastersBindingSource;
        private CosmeticRoomDataSetTableAdapters.MastersTableAdapter mastersTableAdapter;
        private System.Windows.Forms.ComboBox masterNameComboBox;
        private System.Windows.Forms.Label label2;
    }
}