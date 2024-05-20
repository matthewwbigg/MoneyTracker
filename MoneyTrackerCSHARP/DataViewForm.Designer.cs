namespace MoneyTrackerCSHARP
{
    partial class DataViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewForm));
            System.Windows.Forms.Label transaction_IDLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label deposit_Label;
            System.Windows.Forms.Label datesLabel;
            System.Windows.Forms.Label categoryLabel;
            this.transactionsDataSet = new MoneyTrackerCSHARP.TransactionsDataSet();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTableAdapter = new MoneyTrackerCSHARP.TransactionsDataSetTableAdapters.TransactionsTableAdapter();
            this.tableAdapterManager = new MoneyTrackerCSHARP.TransactionsDataSetTableAdapters.TableAdapterManager();
            this.transactionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.transactionsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.transaction_IDTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.deposit_CheckBox = new System.Windows.Forms.CheckBox();
            this.datesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            transaction_IDLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            deposit_Label = new System.Windows.Forms.Label();
            datesLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingNavigator)).BeginInit();
            this.transactionsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // transactionsDataSet
            // 
            this.transactionsDataSet.DataSetName = "TransactionsDataSet";
            this.transactionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.transactionsDataSet;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TransactionsTableAdapter = this.transactionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = MoneyTrackerCSHARP.TransactionsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // transactionsBindingNavigator
            // 
            this.transactionsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.transactionsBindingNavigator.BindingSource = this.transactionsBindingSource;
            this.transactionsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.transactionsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.transactionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.transactionsBindingNavigatorSaveItem});
            this.transactionsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.transactionsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.transactionsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.transactionsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.transactionsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.transactionsBindingNavigator.Name = "transactionsBindingNavigator";
            this.transactionsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.transactionsBindingNavigator.Size = new System.Drawing.Size(425, 25);
            this.transactionsBindingNavigator.TabIndex = 0;
            this.transactionsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // transactionsBindingNavigatorSaveItem
            // 
            this.transactionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.transactionsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("transactionsBindingNavigatorSaveItem.Image")));
            this.transactionsBindingNavigatorSaveItem.Name = "transactionsBindingNavigatorSaveItem";
            this.transactionsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.transactionsBindingNavigatorSaveItem.Text = "Save Data";
            this.transactionsBindingNavigatorSaveItem.Click += new System.EventHandler(this.transactionsBindingNavigatorSaveItem_Click);
            // 
            // transaction_IDLabel
            // 
            transaction_IDLabel.AutoSize = true;
            transaction_IDLabel.Location = new System.Drawing.Point(119, 108);
            transaction_IDLabel.Name = "transaction_IDLabel";
            transaction_IDLabel.Size = new System.Drawing.Size(80, 13);
            transaction_IDLabel.TabIndex = 1;
            transaction_IDLabel.Text = "Transaction ID:";
            // 
            // transaction_IDTextBox
            // 
            this.transaction_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionsBindingSource, "Transaction ID", true));
            this.transaction_IDTextBox.Location = new System.Drawing.Point(205, 105);
            this.transaction_IDTextBox.Name = "transaction_IDTextBox";
            this.transaction_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.transaction_IDTextBox.TabIndex = 2;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(136, 146);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(46, 13);
            amountLabel.TabIndex = 3;
            amountLabel.Text = "Amount:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionsBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(188, 143);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 4;
            // 
            // deposit_Label
            // 
            deposit_Label.AutoSize = true;
            deposit_Label.Location = new System.Drawing.Point(131, 202);
            deposit_Label.Name = "deposit_Label";
            deposit_Label.Size = new System.Drawing.Size(52, 13);
            deposit_Label.TabIndex = 5;
            deposit_Label.Text = "Deposit?:";
            // 
            // deposit_CheckBox
            // 
            this.deposit_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.transactionsBindingSource, "Deposit?", true));
            this.deposit_CheckBox.Location = new System.Drawing.Point(189, 197);
            this.deposit_CheckBox.Name = "deposit_CheckBox";
            this.deposit_CheckBox.Size = new System.Drawing.Size(104, 24);
            this.deposit_CheckBox.TabIndex = 6;
            this.deposit_CheckBox.Text = "checkBox1";
            this.deposit_CheckBox.UseVisualStyleBackColor = true;
            // 
            // datesLabel
            // 
            datesLabel.AutoSize = true;
            datesLabel.Location = new System.Drawing.Point(90, 249);
            datesLabel.Name = "datesLabel";
            datesLabel.Size = new System.Drawing.Size(38, 13);
            datesLabel.TabIndex = 7;
            datesLabel.Text = "Dates:";
            // 
            // datesDateTimePicker
            // 
            this.datesDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transactionsBindingSource, "Dates", true));
            this.datesDateTimePicker.Location = new System.Drawing.Point(134, 245);
            this.datesDateTimePicker.Name = "datesDateTimePicker";
            this.datesDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datesDateTimePicker.TabIndex = 8;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(133, 296);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 9;
            categoryLabel.Text = "Category:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionsBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(191, 293);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryTextBox.TabIndex = 10;
            // 
            // DataViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 462);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(datesLabel);
            this.Controls.Add(this.datesDateTimePicker);
            this.Controls.Add(deposit_Label);
            this.Controls.Add(this.deposit_CheckBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(transaction_IDLabel);
            this.Controls.Add(this.transaction_IDTextBox);
            this.Controls.Add(this.transactionsBindingNavigator);
            this.Name = "DataViewForm";
            this.Text = "DataViewForm";
            this.Load += new System.EventHandler(this.DataViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingNavigator)).EndInit();
            this.transactionsBindingNavigator.ResumeLayout(false);
            this.transactionsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TransactionsDataSet transactionsDataSet;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private TransactionsDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private TransactionsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator transactionsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton transactionsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox transaction_IDTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.CheckBox deposit_CheckBox;
        private System.Windows.Forms.DateTimePicker datesDateTimePicker;
        private System.Windows.Forms.TextBox categoryTextBox;
    }
}