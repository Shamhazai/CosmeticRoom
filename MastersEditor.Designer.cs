namespace CosmeticRoom
{
    partial class MastersEditor
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
            System.Windows.Forms.Label masterNameLabel;
            System.Windows.Forms.Label categoryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MastersEditor));
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.mastersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cosmeticRoomDataSet = new CosmeticRoom.CosmeticRoomDataSet();
            this.masterNameTextBox = new System.Windows.Forms.TextBox();
            this.deleteB = new System.Windows.Forms.Button();
            this.saveB = new System.Windows.Forms.Button();
            this.InsertB = new System.Windows.Forms.Button();
            this.mastersTableAdapter = new CosmeticRoom.CosmeticRoomDataSetTableAdapters.MastersTableAdapter();
            this.tableAdapterManager = new CosmeticRoom.CosmeticRoomDataSetTableAdapters.TableAdapterManager();
            this.mastersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.mastersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            masterNameLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticRoomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingNavigator)).BeginInit();
            this.mastersBindingNavigator.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // masterNameLabel
            // 
            masterNameLabel.AutoSize = true;
            masterNameLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            masterNameLabel.Location = new System.Drawing.Point(19, 16);
            masterNameLabel.Name = "masterNameLabel";
            masterNameLabel.Size = new System.Drawing.Size(139, 23);
            masterNameLabel.TabIndex = 34;
            masterNameLabel.Text = "ФИО мастера:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            categoryLabel.Location = new System.Drawing.Point(19, 66);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(108, 23);
            categoryLabel.TabIndex = 34;
            categoryLabel.Text = "Категория:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(117, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(24, 0, 16, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Вставка, изменение, удаление и сохранение";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBack.Location = new System.Drawing.Point(27, 495);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(154, 41);
            this.buttonBack.TabIndex = 32;
            this.buttonBack.Text = "← Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 32F);
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 49);
            this.label1.TabIndex = 31;
            this.label1.Text = " ✏️ Редактирование мастеров";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.39002F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.60998F));
            this.tableLayoutPanel1.Controls.Add(this.categoryTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(categoryLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.masterNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(masterNameLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(117, 272);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(573, 132);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mastersBindingSource, "Category", true));
            this.categoryTextBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryTextBox.Location = new System.Drawing.Point(178, 69);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(149, 22);
            this.categoryTextBox.TabIndex = 35;
            // 
            // mastersBindingSource
            // 
            this.mastersBindingSource.DataMember = "Masters";
            this.mastersBindingSource.DataSource = this.cosmeticRoomDataSet;
            // 
            // cosmeticRoomDataSet
            // 
            this.cosmeticRoomDataSet.DataSetName = "CosmeticRoomDataSet";
            this.cosmeticRoomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masterNameTextBox
            // 
            this.masterNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mastersBindingSource, "MasterName", true));
            this.masterNameTextBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterNameTextBox.Location = new System.Drawing.Point(178, 19);
            this.masterNameTextBox.Name = "masterNameTextBox";
            this.masterNameTextBox.Size = new System.Drawing.Size(321, 22);
            this.masterNameTextBox.TabIndex = 35;
            // 
            // deleteB
            // 
            this.deleteB.BackColor = System.Drawing.Color.Crimson;
            this.deleteB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.deleteB.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteB.Location = new System.Drawing.Point(283, 435);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(163, 35);
            this.deleteB.TabIndex = 29;
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
            this.saveB.Location = new System.Drawing.Point(461, 435);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(131, 35);
            this.saveB.TabIndex = 28;
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
            this.InsertB.Location = new System.Drawing.Point(117, 435);
            this.InsertB.Name = "InsertB";
            this.InsertB.Size = new System.Drawing.Size(147, 35);
            this.InsertB.TabIndex = 27;
            this.InsertB.Text = "Вставить";
            this.InsertB.UseVisualStyleBackColor = false;
            this.InsertB.Click += new System.EventHandler(this.InsertB_Click);
            // 
            // mastersTableAdapter
            // 
            this.mastersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.MastersTableAdapter = this.mastersTableAdapter;
            this.tableAdapterManager.ServiceRegistrationTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CosmeticRoom.CosmeticRoomDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mastersBindingNavigator
            // 
            this.mastersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mastersBindingNavigator.BindingSource = this.mastersBindingSource;
            this.mastersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mastersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mastersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.mastersBindingNavigatorSaveItem});
            this.mastersBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.mastersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mastersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mastersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mastersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mastersBindingNavigator.Name = "mastersBindingNavigator";
            this.mastersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mastersBindingNavigator.Size = new System.Drawing.Size(1105, 25);
            this.mastersBindingNavigator.TabIndex = 34;
            this.mastersBindingNavigator.Text = "bindingNavigator1";
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
            // mastersBindingNavigatorSaveItem
            // 
            this.mastersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mastersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mastersBindingNavigatorSaveItem.Image")));
            this.mastersBindingNavigatorSaveItem.Name = "mastersBindingNavigatorSaveItem";
            this.mastersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mastersBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.mastersBindingNavigatorSaveItem.Click += new System.EventHandler(this.mastersBindingNavigatorSaveItem_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBox4, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(117, 132);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(377, 100);
            this.tableLayoutPanel6.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CosmeticRoom.Properties.Resources.мастер1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CosmeticRoom.Properties.Resources.мастер3;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(199, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CosmeticRoom.Properties.Resources.мастер41;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(285, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(87, 94);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CosmeticRoom.Properties.Resources.мфстер2;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(106, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1105, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // MastersEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 617);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.mastersBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.InsertB);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MastersEditor";
            this.Text = "Редактирование мастеров";
            this.Load += new System.EventHandler(this.MastersEditor_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticRoomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingNavigator)).EndInit();
            this.mastersBindingNavigator.ResumeLayout(false);
            this.mastersBindingNavigator.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Button InsertB;
        private CosmeticRoomDataSet cosmeticRoomDataSet;
        private System.Windows.Forms.BindingSource mastersBindingSource;
        private CosmeticRoomDataSetTableAdapters.MastersTableAdapter mastersTableAdapter;
        private CosmeticRoomDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mastersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mastersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox masterNameTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}