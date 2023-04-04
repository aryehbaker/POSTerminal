using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace POSTerminal
{
    public partial class OrderEntry : Form
    {
        
        decimal? payed;
        decimal? amount;
        decimal? balance;
        int statusInt;
        bool upgrade = true;
        POSdbDataSetTableAdapters.PaymentsTableAdapter paymentsTA;
        POSdbDataSetTableAdapters.FullOrderProductsTableAdapter fullOrderProductsTA;
        POSdbDataSetTableAdapters.OrdersTableAdapter ordersTA;
        POSdbDataSet.OrdersDataTable ordersRows;
        POSdbDataSet.PaymentsDataTable PaymentsRows;
        int index = -1;
        public OrderEntry()
        {
            InitializeComponent();
           
        }

     

        public OrderEntry(int index)
        {
            this.index = index;
            InitializeComponent();
            SetFormForEditingAndProductSelection();
            this.ordersTableAdapter.Fill(this.pOSdbDataSet.Orders);

            GetOrderData();
            setAppearance(index);
        }
        private void InitializeAdapters()
        {
            paymentsTA = new POSdbDataSetTableAdapters.PaymentsTableAdapter();
            fullOrderProductsTA = new POSdbDataSetTableAdapters.FullOrderProductsTableAdapter();
            ordersTA = new POSdbDataSetTableAdapters.OrdersTableAdapter();
            ordersRows = new POSdbDataSet.OrdersDataTable();
            PaymentsRows = new POSdbDataSet.PaymentsDataTable();

        }

        private void setAppearance(int index)
        {
            lblOrderEntryOrderId.Text = "Order Id: " + index;
            btnOrderEntryStatus.Enabled = true;
            payed = 0;
            GetOrderProducts();
            fullOrderProductsDataGridView.Refresh();
            paymentsTA.Fill(PaymentsRows);
            try
            {
                var b = paymentsTA.SumPayed(index);
                if(b != null)
                {
                    payed = (decimal)paymentsTA.SumPayed(index);
                   
                }
               
                
            }
            catch (SqlException e) { MessageBox.Show(e.Message); }
            catch (System.NullReferenceException e) { MessageBox.Show(e.Message); }
            try
            {
                var b = fullOrderProductsTA.SumOrder(index);
                if (b != null)
                {
                    amount = (decimal)fullOrderProductsTA.SumOrder(index);
                }
            }
            catch (SqlException e) { MessageBox.Show(e.Message); }
            ordersRows = ordersTA.GetDataByOrderId(index);
            statusInt = ordersRows.FirstOrDefault().Status;
            balance = amount - payed;
            if (balance > 0)
            {
                upgrade = false;
            }else { upgrade = true; }
            if(upgrade == false)
            {
                btnOrderEntryStatus.Text = "Status cannot be changed to Paid until paid up.";
                btnOrderEntryStatus.Enabled = false;
                lblOrderEntryStatus.Text = "Status: New";
            }
            else
            {
                if (statusInt == 1)
                {
                    btnOrderEntryStatus.Text = "Set Status to Paid";
                    lblOrderEntryStatus.Text = "Status: New";
                }
                else if (statusInt == 2)
                {
                    btnOrderEntryStatus.Text = "Set Status to Ready";
                    lblOrderEntryStatus.Text = "Status: Paid";
                }
                else if(statusInt == 3)
                {
                    btnOrderEntryStatus.Text = "Set Status to Out For Delivery";
                    lblOrderEntryStatus.Text = "Status: Ready For Delivery";
                }
                else if (statusInt == 4)
                {
                    btnOrderEntryStatus.Text = "Set Status to Delivered";
                    lblOrderEntryStatus.Text = "Status: Out For Delivery";
                }
                else if (statusInt == 5)
                {
                    btnOrderEntryStatus.Text = "Delivered Already";
                    btnOrderEntryStatus.Enabled = false;
                    lblOrderEntryStatus.Text = "Status: Delivered";
                }
                else if (statusInt == 6)
                {
                    btnOrderEntryStatus.Text = "Canceled order cannot be changed";
                    lblOrderEntryStatus.Text = "Status: Cancelled";
                    btnOrderEntryStatus.Enabled = false;
                }
            }
        

           lblOrderEntrySumPaid.Text = "sum Paid: " + payed;
           lblOrderEntrySumItems.Text = "sum Amount: " + amount;
           lblOrderEntryBalance.Text = "Balance: " + balance;
            if (upgrade)
            {
                
            }
            
        }


        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pOSdbDataSet);

        }

        private void OrderEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSdbDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.pOSdbDataSet.Products);
            // TODO: This line of code loads data into the 'pOSdbDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.pOSdbDataSet.Orders);
            // TODO: This line of code loads data into the 'pOSdbDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.pOSdbDataSet.Customers);

        }

        private void btnOrderEntrySelectCustomer_Click(object sender, EventArgs e)
        {
            GetOrderData();

        }

        private void GetOrderData()
        {
            string Customer;
            int customerId;
            if (dgvOrderEntryCustomers.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow;

                selectedRow = dgvOrderEntryCustomers.SelectedRows[0];
                Customer =
                   selectedRow.Cells[0].Value.ToString()
                   + "\n" +
                    selectedRow.Cells[1].Value.ToString()
                   + "\n" +
                    selectedRow.Cells[2].Value.ToString()
                   + "\n" +
                    selectedRow.Cells[3].Value.ToString()
                   + "\n";
                customerId = (int)selectedRow.Cells[0].Value;
            }
            else if (index != -1)
            {
                POSdbDataSetTableAdapters.CustomerForOrderTableAdapter adapter =
                    new POSdbDataSetTableAdapters.CustomerForOrderTableAdapter();
                POSdbDataSet.CustomerForOrderDataTable customerForOrderDataTable =
                    new POSdbDataSet.CustomerForOrderDataTable();
                POSdbDataSet.CustomerForOrderRow customerForOrderRow;

                adapter.FillByOrderId(customerForOrderDataTable,index);
                customerForOrderRow = customerForOrderDataTable
                    .FirstOrDefault();
                Customer = customerForOrderRow.Id.ToString()
                   + "\n" +
                    customerForOrderRow.FirstName.ToString()
                    + " " + customerForOrderRow.LastName.ToString()
                     + "\n" +
                    customerForOrderRow.Address.ToString()
                    + "\n" +
                    customerForOrderRow.Phone.ToString();

                customerId = customerForOrderRow.Id;

            }
            else return;



                lblOrderEntryCustomer.Text = Customer;
                lblOrderEntryCustomer.Visible = true;


                POSdbDataSetTableAdapters.OrdersTableAdapter ta =
                    new POSdbDataSetTableAdapters.OrdersTableAdapter();
                POSdbDataSet.OrdersDataTable table = new POSdbDataSet.OrdersDataTable();
                DataRow row;
                ta.Fill(table);
                if (index == -1)
                {
                    row = table.NewRow();

                    row["CustomerId"] = customerId;
                    row["Status"] = 1;
                    table.Rows.Add(row);
                    ta.Update(table);

                    index = (int)row["Id"];
                }
                
               
                
                SetFormForEditingAndProductSelection();
                GetOrderProducts();

            
        }

        private void SetFormForEditingAndProductSelection()
        {
            dgvOrderEntryCustomers.Visible = false;
            btnOrderEntrySelectCustomer.Visible = false;
            lblOrderEntryCustomer.Visible = true;
            lblOrderEntryCustomer.Left = 5;
            lblOrderEntryCustomer.Top = 5;            
            btnOrderEntryAddItems.Visible = true;
            btnOrderEntryDelete.Visible = true;
            btnOrderEntrySetOrder.Visible = true;
            btnOrderEntryDeleteItem.Visible = true;
            btnOrderEntrySubmitPayment.Visible = true;
            dtpOrderEntryPaymentDate.Visible = true;
            btnOrderEntryCancelOrder.Visible = true;
            btnOrderEntryCancelOrder.Enabled = true;
            btnOrderEntryStatus.Visible = true;
            btnOrderEntryCancelOrder.Visible = true;
            fullOrderProductsDataGridView.Visible = true;
            txtOrderEntryPayment.Visible = true;
            productsDataGridView.Visible = true;
            lblOrderEntrySumPaid.Visible = true;
            lblOrderEntrySumItems.Visible = true;
            lblOrderEntryBalance.Visible = true;
            lblOrderEntryStatus.Visible = true;
            lblOrderEntryPaymentDate.Visible = true;
            lblOrderEntryPaymentAmount.Visible = true;
            lblOrderEntryOrderId.Visible = true;
            InitializeAdapters();
        }

        void GetOrderProducts()
        {
            try
            {

                this.fullOrderProductsTableAdapter.FillOrderProductsFull(this.pOSdbDataSet.FullOrderProducts, index);
                fullOrderProductsDataGridView.DataSource = this.pOSdbDataSet.FullOrderProducts;


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }


        private void btnOrderEntryAddItems_Click(object sender, EventArgs e)
        {
            if(productsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = productsDataGridView.SelectedRows[0];
                POSdbDataSetTableAdapters.OrdersProductsTableAdapter oa = 
                    new POSdbDataSetTableAdapters.OrdersProductsTableAdapter();
                oa.Insert(index,(int)selectedRow.Cells[0].Value);
                GetOrderProducts();
                fullOrderProductsDataGridView.Refresh();
                setAppearance(index);
                
            }
        }



        private void btnOrderEntryDelete_Click(object sender, EventArgs e)
        {
            POSdbDataSetTableAdapters.OrdersTableAdapter ota =
                new POSdbDataSetTableAdapters.OrdersTableAdapter();
            POSdbDataSet.OrdersDataTable table = new POSdbDataSet.OrdersDataTable();
            DataRow row;
            ota.Fill(table);
            row = table.FindById(index);
            ota.Delete((int)row["Id"],(int)row["CustomerId"],(int)row["Status"]);
            this.Close();

            }

        private void btnOrderEntryDeleteItem_Click(object sender, EventArgs e)
        {
            if (fullOrderProductsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = fullOrderProductsDataGridView.SelectedRows[0];
                POSdbDataSetTableAdapters.OrdersProductsTableAdapter ota =
                                new POSdbDataSetTableAdapters.OrdersProductsTableAdapter();
                POSdbDataSet.OrdersProductsDataTable table = new POSdbDataSet.OrdersProductsDataTable();
                DataRow row;
                ota.Fill(table);
                int i = (int)selectedRow.Cells[0].Value;
                row = table.FindById(i);
                ota.Delete((int)row["Id"], (int)row["OrderId"], (int)row["ProductId"]);
                GetOrderProducts();
                fullOrderProductsDataGridView.Refresh();
                setAppearance(index);
               // lblOrderEntrySumItems.Text = "sum Amount" + fad.SumOrder(index);
            }
        }



        private void btnOrderEntryStatus_Click(object sender, EventArgs e)
        {
            ordersRows = ordersTA.GetDataByOrderId(index);
            statusInt = ordersRows.FirstOrDefault().Status;
            int newStatus = statusInt + 1;

            ordersRows.FirstOrDefault()["Status"] = newStatus;
            ordersTA.Update(ordersRows);
            setAppearance(index);
        }


        private void btnOrderEntryChangeStatus_Click(object sender, EventArgs e)
        {
            ordersRows = ordersTA.GetDataByOrderId(index);
            statusInt = ordersRows.FirstOrDefault().Status;
            int newStatus = 6;
            
            ordersRows.FirstOrDefault()["Status"] = newStatus;
            ordersTA.Update(ordersRows);
           
            btnOrderEntryDeleteItem.Enabled = false;
            btnOrderEntryCancelOrder.Enabled = false;
            btnOrderEntryStatus.Enabled = false;
        }

        private void btnOrderEntrySubmitPayment_Click(object sender, EventArgs e)
        {
            decimal result;
            if (decimal.TryParse(txtOrderEntryPayment.Text, out result))
            {
                paymentsTA.Insert(index, result, dtpOrderEntryPaymentDate.Value);
                setAppearance(index);
            }
        }
    }
}
