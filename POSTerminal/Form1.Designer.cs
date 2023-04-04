
namespace POSTerminal
{
    partial class Form1
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnAddOrders = new System.Windows.Forms.Button();
            this.btnOrderReview = new System.Windows.Forms.Button();
            this.pOSdbDataSet = new POSTerminal.POSdbDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new POSTerminal.POSdbDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new POSTerminal.POSdbDataSetTableAdapters.TableAdapterManager();
            this.ordersAndAmountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersAndAmountsTableAdapter = new POSTerminal.POSdbDataSetTableAdapters.OrdersAndAmountsTableAdapter();
            this.ordersAndAmountsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pOSdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersAndAmountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersAndAmountsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(13, 13);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(150, 34);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add a Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(13, 54);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(150, 29);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add a Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnAddOrders
            // 
            this.btnAddOrders.Location = new System.Drawing.Point(13, 89);
            this.btnAddOrders.Name = "btnAddOrders";
            this.btnAddOrders.Size = new System.Drawing.Size(150, 29);
            this.btnAddOrders.TabIndex = 2;
            this.btnAddOrders.Text = "Add an Order";
            this.btnAddOrders.UseVisualStyleBackColor = true;
            this.btnAddOrders.Click += new System.EventHandler(this.btnAddOrders_Click);
            // 
            // btnOrderReview
            // 
            this.btnOrderReview.Location = new System.Drawing.Point(13, 125);
            this.btnOrderReview.Name = "btnOrderReview";
            this.btnOrderReview.Size = new System.Drawing.Size(192, 34);
            this.btnOrderReview.TabIndex = 3;
            this.btnOrderReview.Text = "Review Order Selected";
            this.btnOrderReview.UseVisualStyleBackColor = true;
            this.btnOrderReview.Click += new System.EventHandler(this.btnOrderReview_Click);
            // 
            // pOSdbDataSet
            // 
            this.pOSdbDataSet.DataSetName = "POSdbDataSet";
            this.pOSdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.pOSdbDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.OrdersProductsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.StatusesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = POSTerminal.POSdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordersAndAmountsBindingSource
            // 
            this.ordersAndAmountsBindingSource.DataMember = "OrdersAndAmounts";
            this.ordersAndAmountsBindingSource.DataSource = this.pOSdbDataSet;
            // 
            // ordersAndAmountsTableAdapter
            // 
            this.ordersAndAmountsTableAdapter.ClearBeforeFill = true;
            // 
            // ordersAndAmountsDataGridView
            // 
            this.ordersAndAmountsDataGridView.AutoGenerateColumns = false;
            this.ordersAndAmountsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ordersAndAmountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersAndAmountsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.ordersAndAmountsDataGridView.DataSource = this.ordersAndAmountsBindingSource;
            this.ordersAndAmountsDataGridView.Location = new System.Drawing.Point(211, 12);
            this.ordersAndAmountsDataGridView.Name = "ordersAndAmountsDataGridView";
            this.ordersAndAmountsDataGridView.RowHeadersWidth = 62;
            this.ordersAndAmountsDataGridView.RowTemplate.Height = 28;
            this.ordersAndAmountsDataGridView.Size = new System.Drawing.Size(1059, 586);
            this.ordersAndAmountsDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Order_Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Order_Id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 108;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Order_Amount";
            this.dataGridViewTextBoxColumn6.HeaderText = "Order_Amount";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Amount_Paid";
            this.dataGridViewTextBoxColumn7.HeaderText = "Amount_Paid";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 141;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Customer_Name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Customer_Name";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 165;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn9.HeaderText = "Status";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 92;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 610);
            this.Controls.Add(this.ordersAndAmountsDataGridView);
            this.Controls.Add(this.btnOrderReview);
            this.Controls.Add(this.btnAddOrders);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Load);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pOSdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersAndAmountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersAndAmountsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnAddOrders;
        private System.Windows.Forms.Button btnOrderReview;
        private POSdbDataSet pOSdbDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private POSdbDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private POSdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource ordersAndAmountsBindingSource;
        private POSdbDataSetTableAdapters.OrdersAndAmountsTableAdapter ordersAndAmountsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView ordersAndAmountsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}

