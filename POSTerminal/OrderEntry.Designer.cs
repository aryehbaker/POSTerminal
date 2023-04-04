
namespace POSTerminal
{
    partial class OrderEntry
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
            this.dgvOrderEntryCustomers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSdbDataSet = new POSTerminal.POSdbDataSet();
            this.btnOrderEntrySelectCustomer = new System.Windows.Forms.Button();
            this.lblOrderEntryCustomer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrderEntryAddItems = new System.Windows.Forms.Button();
            this.fullOrderProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullOrderProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOrderEntryDelete = new System.Windows.Forms.Button();
            this.btnOrderEntrySetOrder = new System.Windows.Forms.Button();
            this.btnOrderEntryDeleteItem = new System.Windows.Forms.Button();
            this.lblOrderEntrySumPaid = new System.Windows.Forms.Label();
            this.lblOrderEntrySumItems = new System.Windows.Forms.Label();
            this.btnOrderEntryStatus = new System.Windows.Forms.Button();
            this.btnOrderEntryCancelOrder = new System.Windows.Forms.Button();
            this.lblOrderEntryBalance = new System.Windows.Forms.Label();
            this.lblOrderEntryStatus = new System.Windows.Forms.Label();
            this.customersTableAdapter = new POSTerminal.POSdbDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new POSTerminal.POSdbDataSetTableAdapters.TableAdapterManager();
            this.ordersTableAdapter = new POSTerminal.POSdbDataSetTableAdapters.OrdersTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullOrderProductsTableAdapter = new POSTerminal.POSdbDataSetTableAdapters.FullOrderProductsTableAdapter();
            this.productsTableAdapter = new POSTerminal.POSdbDataSetTableAdapters.ProductsTableAdapter();
            this.dtpOrderEntryPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblOrderEntryPaymentDate = new System.Windows.Forms.Label();
            this.txtOrderEntryPayment = new System.Windows.Forms.TextBox();
            this.lblOrderEntryPaymentAmount = new System.Windows.Forms.Label();
            this.btnOrderEntrySubmitPayment = new System.Windows.Forms.Button();
            this.lblOrderEntryOrderId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderEntryCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullOrderProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullOrderProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderEntryCustomers
            // 
            this.dgvOrderEntryCustomers.AutoGenerateColumns = false;
            this.dgvOrderEntryCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderEntryCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvOrderEntryCustomers.DataSource = this.customersBindingSource;
            this.dgvOrderEntryCustomers.Location = new System.Drawing.Point(12, 25);
            this.dgvOrderEntryCustomers.MultiSelect = false;
            this.dgvOrderEntryCustomers.Name = "dgvOrderEntryCustomers";
            this.dgvOrderEntryCustomers.ReadOnly = true;
            this.dgvOrderEntryCustomers.RowHeadersWidth = 62;
            this.dgvOrderEntryCustomers.RowTemplate.Height = 28;
            this.dgvOrderEntryCustomers.Size = new System.Drawing.Size(1273, 118);
            this.dgvOrderEntryCustomers.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.pOSdbDataSet;
            // 
            // pOSdbDataSet
            // 
            this.pOSdbDataSet.DataSetName = "POSdbDataSet";
            this.pOSdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOrderEntrySelectCustomer
            // 
            this.btnOrderEntrySelectCustomer.Location = new System.Drawing.Point(12, 149);
            this.btnOrderEntrySelectCustomer.Name = "btnOrderEntrySelectCustomer";
            this.btnOrderEntrySelectCustomer.Size = new System.Drawing.Size(321, 37);
            this.btnOrderEntrySelectCustomer.TabIndex = 1;
            this.btnOrderEntrySelectCustomer.Text = "Select This Customer";
            this.btnOrderEntrySelectCustomer.UseVisualStyleBackColor = true;
            this.btnOrderEntrySelectCustomer.Click += new System.EventHandler(this.btnOrderEntrySelectCustomer_Click);
            // 
            // lblOrderEntryCustomer
            // 
            this.lblOrderEntryCustomer.AutoSize = true;
            this.lblOrderEntryCustomer.Location = new System.Drawing.Point(41, 259);
            this.lblOrderEntryCustomer.Name = "lblOrderEntryCustomer";
            this.lblOrderEntryCustomer.Size = new System.Drawing.Size(0, 20);
            this.lblOrderEntryCustomer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // btnOrderEntryAddItems
            // 
            this.btnOrderEntryAddItems.Location = new System.Drawing.Point(338, 382);
            this.btnOrderEntryAddItems.Name = "btnOrderEntryAddItems";
            this.btnOrderEntryAddItems.Size = new System.Drawing.Size(247, 40);
            this.btnOrderEntryAddItems.TabIndex = 4;
            this.btnOrderEntryAddItems.Text = "Add Selected Item To the Order";
            this.btnOrderEntryAddItems.UseVisualStyleBackColor = true;
            this.btnOrderEntryAddItems.Visible = false;
            this.btnOrderEntryAddItems.Click += new System.EventHandler(this.btnOrderEntryAddItems_Click);
            // 
            // fullOrderProductsDataGridView
            // 
            this.fullOrderProductsDataGridView.AllowUserToAddRows = false;
            this.fullOrderProductsDataGridView.AutoGenerateColumns = false;
            this.fullOrderProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fullOrderProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.fullOrderProductsDataGridView.DataSource = this.fullOrderProductsBindingSource;
            this.fullOrderProductsDataGridView.Location = new System.Drawing.Point(12, 440);
            this.fullOrderProductsDataGridView.Name = "fullOrderProductsDataGridView";
            this.fullOrderProductsDataGridView.RowHeadersWidth = 62;
            this.fullOrderProductsDataGridView.RowTemplate.Height = 28;
            this.fullOrderProductsDataGridView.Size = new System.Drawing.Size(1259, 220);
            this.fullOrderProductsDataGridView.TabIndex = 6;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Products";
            this.dataGridViewTextBoxColumn6.HeaderText = "Products";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn7.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn8.HeaderText = "Price";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // fullOrderProductsBindingSource
            // 
            this.fullOrderProductsBindingSource.DataMember = "FullOrderProducts";
            this.fullOrderProductsBindingSource.DataSource = this.pOSdbDataSet;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(12, 192);
            this.productsDataGridView.MultiSelect = false;
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 62;
            this.productsDataGridView.RowTemplate.Height = 28;
            this.productsDataGridView.ShowEditingIcon = false;
            this.productsDataGridView.Size = new System.Drawing.Size(1259, 171);
            this.productsDataGridView.TabIndex = 7;
            this.productsDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn9.HeaderText = "Id";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Products";
            this.dataGridViewTextBoxColumn10.HeaderText = "Products";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn11.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn12.HeaderText = "Price";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.pOSdbDataSet;
            // 
            // btnOrderEntryDelete
            // 
            this.btnOrderEntryDelete.Location = new System.Drawing.Point(717, 61);
            this.btnOrderEntryDelete.Name = "btnOrderEntryDelete";
            this.btnOrderEntryDelete.Size = new System.Drawing.Size(257, 40);
            this.btnOrderEntryDelete.TabIndex = 8;
            this.btnOrderEntryDelete.Text = "Delete Order";
            this.btnOrderEntryDelete.UseVisualStyleBackColor = true;
            this.btnOrderEntryDelete.Visible = false;
            this.btnOrderEntryDelete.Click += new System.EventHandler(this.btnOrderEntryDelete_Click);
            // 
            // btnOrderEntrySetOrder
            // 
            this.btnOrderEntrySetOrder.Location = new System.Drawing.Point(964, 124);
            this.btnOrderEntrySetOrder.Name = "btnOrderEntrySetOrder";
            this.btnOrderEntrySetOrder.Size = new System.Drawing.Size(321, 40);
            this.btnOrderEntrySetOrder.TabIndex = 9;
            this.btnOrderEntrySetOrder.Text = "Set Order";
            this.btnOrderEntrySetOrder.UseVisualStyleBackColor = true;
            this.btnOrderEntrySetOrder.Visible = false;
            // 
            // btnOrderEntryDeleteItem
            // 
            this.btnOrderEntryDeleteItem.Location = new System.Drawing.Point(2, 382);
            this.btnOrderEntryDeleteItem.Name = "btnOrderEntryDeleteItem";
            this.btnOrderEntryDeleteItem.Size = new System.Drawing.Size(321, 40);
            this.btnOrderEntryDeleteItem.TabIndex = 11;
            this.btnOrderEntryDeleteItem.Text = "Delete Item";
            this.btnOrderEntryDeleteItem.UseVisualStyleBackColor = true;
            this.btnOrderEntryDeleteItem.Visible = false;
            this.btnOrderEntryDeleteItem.Click += new System.EventHandler(this.btnOrderEntryDeleteItem_Click);
            // 
            // lblOrderEntrySumPaid
            // 
            this.lblOrderEntrySumPaid.AutoSize = true;
            this.lblOrderEntrySumPaid.Location = new System.Drawing.Point(606, 25);
            this.lblOrderEntrySumPaid.Name = "lblOrderEntrySumPaid";
            this.lblOrderEntrySumPaid.Size = new System.Drawing.Size(82, 20);
            this.lblOrderEntrySumPaid.TabIndex = 12;
            this.lblOrderEntrySumPaid.Text = "sum Paid: ";
            this.lblOrderEntrySumPaid.Visible = false;
            // 
            // lblOrderEntrySumItems
            // 
            this.lblOrderEntrySumItems.AutoSize = true;
            this.lblOrderEntrySumItems.Location = new System.Drawing.Point(778, 25);
            this.lblOrderEntrySumItems.Name = "lblOrderEntrySumItems";
            this.lblOrderEntrySumItems.Size = new System.Drawing.Size(107, 20);
            this.lblOrderEntrySumItems.TabIndex = 13;
            this.lblOrderEntrySumItems.Text = "sum of items: ";
            this.lblOrderEntrySumItems.Visible = false;
            // 
            // btnOrderEntryStatus
            // 
            this.btnOrderEntryStatus.Location = new System.Drawing.Point(431, 61);
            this.btnOrderEntryStatus.Name = "btnOrderEntryStatus";
            this.btnOrderEntryStatus.Size = new System.Drawing.Size(257, 40);
            this.btnOrderEntryStatus.TabIndex = 14;
            this.btnOrderEntryStatus.Text = "Status: ";
            this.btnOrderEntryStatus.UseVisualStyleBackColor = true;
            this.btnOrderEntryStatus.Visible = false;
            this.btnOrderEntryStatus.Click += new System.EventHandler(this.btnOrderEntryStatus_Click);
            // 
            // btnOrderEntryCancelOrder
            // 
            this.btnOrderEntryCancelOrder.Location = new System.Drawing.Point(998, 61);
            this.btnOrderEntryCancelOrder.Name = "btnOrderEntryCancelOrder";
            this.btnOrderEntryCancelOrder.Size = new System.Drawing.Size(257, 40);
            this.btnOrderEntryCancelOrder.TabIndex = 15;
            this.btnOrderEntryCancelOrder.Text = "Cancel Order";
            this.btnOrderEntryCancelOrder.UseVisualStyleBackColor = false;
            this.btnOrderEntryCancelOrder.Visible = false;
            this.btnOrderEntryCancelOrder.Click += new System.EventHandler(this.btnOrderEntryChangeStatus_Click);
            // 
            // lblOrderEntryBalance
            // 
            this.lblOrderEntryBalance.AutoSize = true;
            this.lblOrderEntryBalance.Location = new System.Drawing.Point(972, 25);
            this.lblOrderEntryBalance.Name = "lblOrderEntryBalance";
            this.lblOrderEntryBalance.Size = new System.Drawing.Size(73, 20);
            this.lblOrderEntryBalance.TabIndex = 16;
            this.lblOrderEntryBalance.Text = "balance: ";
            this.lblOrderEntryBalance.Visible = false;
            // 
            // lblOrderEntryStatus
            // 
            this.lblOrderEntryStatus.AutoSize = true;
            this.lblOrderEntryStatus.Location = new System.Drawing.Point(1095, 25);
            this.lblOrderEntryStatus.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblOrderEntryStatus.Name = "lblOrderEntryStatus";
            this.lblOrderEntryStatus.Size = new System.Drawing.Size(200, 20);
            this.lblOrderEntryStatus.TabIndex = 17;
            this.lblOrderEntryStatus.Text = "Status: ";
            this.lblOrderEntryStatus.Visible = false;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.OrdersProductsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.StatusesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = POSTerminal.POSdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.pOSdbDataSet;
            // 
            // fullOrderProductsTableAdapter
            // 
            this.fullOrderProductsTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // dtpOrderEntryPaymentDate
            // 
            this.dtpOrderEntryPaymentDate.Location = new System.Drawing.Point(376, 134);
            this.dtpOrderEntryPaymentDate.Name = "dtpOrderEntryPaymentDate";
            this.dtpOrderEntryPaymentDate.Size = new System.Drawing.Size(200, 26);
            this.dtpOrderEntryPaymentDate.TabIndex = 18;
            this.dtpOrderEntryPaymentDate.Visible = false;
            // 
            // lblOrderEntryPaymentDate
            // 
            this.lblOrderEntryPaymentDate.AutoSize = true;
            this.lblOrderEntryPaymentDate.Location = new System.Drawing.Point(376, 104);
            this.lblOrderEntryPaymentDate.Name = "lblOrderEntryPaymentDate";
            this.lblOrderEntryPaymentDate.Size = new System.Drawing.Size(151, 20);
            this.lblOrderEntryPaymentDate.TabIndex = 19;
            this.lblOrderEntryPaymentDate.Text = "enter payment date:";
            this.lblOrderEntryPaymentDate.Visible = false;
            // 
            // txtOrderEntryPayment
            // 
            this.txtOrderEntryPayment.Location = new System.Drawing.Point(592, 133);
            this.txtOrderEntryPayment.Name = "txtOrderEntryPayment";
            this.txtOrderEntryPayment.Size = new System.Drawing.Size(100, 26);
            this.txtOrderEntryPayment.TabIndex = 20;
            this.txtOrderEntryPayment.Visible = false;
            // 
            // lblOrderEntryPaymentAmount
            // 
            this.lblOrderEntryPaymentAmount.AutoSize = true;
            this.lblOrderEntryPaymentAmount.Location = new System.Drawing.Point(592, 104);
            this.lblOrderEntryPaymentAmount.Name = "lblOrderEntryPaymentAmount";
            this.lblOrderEntryPaymentAmount.Size = new System.Drawing.Size(176, 20);
            this.lblOrderEntryPaymentAmount.TabIndex = 21;
            this.lblOrderEntryPaymentAmount.Text = "Enter Payment amount:";
            this.lblOrderEntryPaymentAmount.Visible = false;
            // 
            // btnOrderEntrySubmitPayment
            // 
            this.btnOrderEntrySubmitPayment.Location = new System.Drawing.Point(717, 133);
            this.btnOrderEntrySubmitPayment.Name = "btnOrderEntrySubmitPayment";
            this.btnOrderEntrySubmitPayment.Size = new System.Drawing.Size(157, 31);
            this.btnOrderEntrySubmitPayment.TabIndex = 22;
            this.btnOrderEntrySubmitPayment.Text = "Submit Payment";
            this.btnOrderEntrySubmitPayment.UseVisualStyleBackColor = true;
            this.btnOrderEntrySubmitPayment.Visible = false;
            this.btnOrderEntrySubmitPayment.Click += new System.EventHandler(this.btnOrderEntrySubmitPayment_Click);
            // 
            // lblOrderEntryOrderId
            // 
            this.lblOrderEntryOrderId.AutoSize = true;
            this.lblOrderEntryOrderId.Location = new System.Drawing.Point(427, 25);
            this.lblOrderEntryOrderId.Name = "lblOrderEntryOrderId";
            this.lblOrderEntryOrderId.Size = new System.Drawing.Size(75, 20);
            this.lblOrderEntryOrderId.TabIndex = 23;
            this.lblOrderEntryOrderId.Text = "Order Id: ";
            this.lblOrderEntryOrderId.Visible = false;
            // 
            // OrderEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 680);
            this.Controls.Add(this.lblOrderEntryOrderId);
            this.Controls.Add(this.btnOrderEntrySubmitPayment);
            this.Controls.Add(this.lblOrderEntryPaymentAmount);
            this.Controls.Add(this.txtOrderEntryPayment);
            this.Controls.Add(this.lblOrderEntryPaymentDate);
            this.Controls.Add(this.dtpOrderEntryPaymentDate);
            this.Controls.Add(this.lblOrderEntryStatus);
            this.Controls.Add(this.lblOrderEntryBalance);
            this.Controls.Add(this.btnOrderEntryCancelOrder);
            this.Controls.Add(this.btnOrderEntryStatus);
            this.Controls.Add(this.lblOrderEntrySumItems);
            this.Controls.Add(this.lblOrderEntrySumPaid);
            this.Controls.Add(this.btnOrderEntryDeleteItem);
            this.Controls.Add(this.btnOrderEntrySetOrder);
            this.Controls.Add(this.btnOrderEntryDelete);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.fullOrderProductsDataGridView);
            this.Controls.Add(this.btnOrderEntryAddItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrderEntryCustomer);
            this.Controls.Add(this.btnOrderEntrySelectCustomer);
            this.Controls.Add(this.dgvOrderEntryCustomers);
            this.Name = "OrderEntry";
            this.Text = "OrderEntry";
            this.Load += new System.EventHandler(this.OrderEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderEntryCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullOrderProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullOrderProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private POSdbDataSet pOSdbDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private POSdbDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private POSdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvOrderEntryCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnOrderEntrySelectCustomer;
        private System.Windows.Forms.Label lblOrderEntryCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrderEntryAddItems;
        private POSdbDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.BindingSource fullOrderProductsBindingSource;
        private POSdbDataSetTableAdapters.FullOrderProductsTableAdapter fullOrderProductsTableAdapter;
        private System.Windows.Forms.DataGridView fullOrderProductsDataGridView;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private POSdbDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button btnOrderEntryDelete;
        private System.Windows.Forms.Button btnOrderEntrySetOrder;
        private System.Windows.Forms.Button btnOrderEntryDeleteItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label lblOrderEntrySumPaid;
        private System.Windows.Forms.Label lblOrderEntrySumItems;
        private System.Windows.Forms.Button btnOrderEntryStatus;
        private System.Windows.Forms.Button btnOrderEntryCancelOrder;
        private System.Windows.Forms.Label lblOrderEntryBalance;
        private System.Windows.Forms.Label lblOrderEntryStatus;
        private System.Windows.Forms.DateTimePicker dtpOrderEntryPaymentDate;
        private System.Windows.Forms.Label lblOrderEntryPaymentDate;
        private System.Windows.Forms.TextBox txtOrderEntryPayment;
        private System.Windows.Forms.Label lblOrderEntryPaymentAmount;
        private System.Windows.Forms.Button btnOrderEntrySubmitPayment;
        private System.Windows.Forms.Label lblOrderEntryOrderId;
    }
}