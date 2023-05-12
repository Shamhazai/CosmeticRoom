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
            System.Windows.Forms.Label masterIDLabel;
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
            this.masterIDTextBox = new System.Windows.Forms.TextBox();
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
            masterIDLabel = new System.Windows.Forms.Label();
            masterNameLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticRoomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingNavigator)).BeginInit();
            this.mastersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // masterIDLabel
            // 
            masterIDLabel.AutoSize = true;
            masterIDLabel.Location = new System.Drawing.Point(19, 16);
            masterIDLabel.Name = "masterIDLabel";
            masterIDLabel.Size = new System.Drawing.Size(56, 13);
            masterIDLabel.TabIndex = 0;
            masterIDLabel.Text = "Master ID:";
            // 
            // masterNameLabel
            // 
            masterNameLabel.AutoSize = true;
            masterNameLabel.Location = new System.Drawing.Point(19, 66);
            masterNameLabel.Name = "masterNameLabel";
            masterNameLabel.Size = new System.Drawing.Size(73, 13);
            masterNameLabel.TabIndex = 34;
            masterNameLabel.Text = "Master Name:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(19, 116);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 34;
            categoryLabel.Text = "Category:";
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
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 49);
            this.label1.TabIndex = 31;
            this.label1.Text = " ✏️ Редактирование мастеров";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.categoryTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(categoryLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.masterNameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(masterNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(masterIDLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.masterIDTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(114, 140);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 282);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mastersBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(125, 119);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 20);
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
            this.masterNameTextBox.Location = new System.Drawing.Point(125, 69);
            this.masterNameTextBox.Name = "masterNameTextBox";
            this.masterNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.masterNameTextBox.TabIndex = 35;
            // 
            // masterIDTextBox
            // 
            this.masterIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mastersBindingSource, "MasterID", true));
            this.masterIDTextBox.Location = new System.Drawing.Point(125, 19);
            this.masterIDTextBox.Name = "masterIDTextBox";
            this.masterIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.masterIDTextBox.TabIndex = 1;
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
            this.mastersBindingNavigator.Location = new System.Drawing.Point(0, 0);
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
            // MastersEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 617);
            this.Controls.Add(this.mastersBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.InsertB);
            this.Name = "MastersEditor";
            this.Text = "MastersEditor";
            this.Load += new System.EventHandler(this.MastersEditor_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticRoomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingNavigator)).EndInit();
            this.mastersBindingNavigator.ResumeLayout(false);
            this.mastersBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox masterIDTextBox;
    }
}