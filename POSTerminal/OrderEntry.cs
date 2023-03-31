using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSTerminal
{
    public partial class OrderEntry : Form
    {
        
        decimal? payed;
        decimal amount;
        decimal balance;
        int statusInt;
        bool upgrade = true;
        string upgradeTo;
        POSdbDataSetTableAdapters.PaymentsTableAdapter ad;
        POSdbDataSetTableAdapters.FullOrderProductsTableAdapter fad;
        POSdbDataSetTableAdapters.OrdersTableAdapter ot;
        POSdbDataSet.OrdersDataTable ordersRows;
        POSdbDataSet.PaymentsDataTable PaymentsRows;
        int index = -1;
        public OrderEntry()
        {
            InitializeComponent();
           
        }

        private void InitializeAdapters()
        {
            ad = new POSdbDataSetTableAdapters.PaymentsTableAdapter();
            fad = new POSdbDataSetTableAdapters.FullOrderProductsTableAdapter();
            ot = new POSdbDataSetTableAdapters.OrdersTableAdapter();
            ordersRows = new POSdbDataSet.OrdersDataTable();
            PaymentsRows = new POSdbDataSet.PaymentsDataTable();
            
        }

        public OrderEntry(int index)
        {
            InitializeComponent();
            SetFormForEditingAndProductSelection();
            

            setAppearance(index);
        }

        private void setAppearance(int index)
        {
            btnOrderEntryStatus.Enabled = true;
            payed = 0;
            try
            {
                var b = ad.SumPayed(index);
                if(b != null)
                {
                    payed = (decimal)ad.SumPayed(index);
                }
               
                
            }
            catch (SqlException e) { MessageBox.Show(e.Message); }
            catch (System.NullReferenceException e) { MessageBox.Show(e.Message); }
            try
            {
                amount = (decimal)fad.SumOrder(index);
            }
            catch (SqlException e){ MessageBox.Show(e.Message); }
            ordersRows = ot.GetDataByOrderId(index);
            statusInt = ordersRows.FirstOrDefault().Status;
            //statusInt = ordersRows.
            balance = amount - balance;
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
                    btnOrderEntryStatus.Text = "Deliverd Already";
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
           lblOrderEntrySumItems.Text = "sum Amount" + fad.SumOrder(index);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvOrderEntryCustomers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvOrderEntryCustomers.SelectedRows[0];
                string Customer =
                    selectedRow.Cells[0].Value.ToString()
                    + "\n" +
                     selectedRow.Cells[1].Value.ToString()
                    + "\n" +
                     selectedRow.Cells[2].Value.ToString()
                    + "\n" +
                     selectedRow.Cells[3].Value.ToString()
                    + "\n";

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

                    row["CustomerId"] = (int)selectedRow.Cells[0].Value;
                    row["Status"] = 1;
                    table.Rows.Add(row);
                    ta.Update(table);

                    index = (int)row["Id"];
                }
                else
                {
                    row = table.FindById( index);
                    row["CustomerId"] = (int)selectedRow.Cells[0].Value;
                    ta.Update(table);
                }
                /* OrderEntryProducts p = new OrderEntryProducts(index);
                 p.ShowDialog();*/
                SetFormForEditingAndProductSelection();
                GetOrderProducts();

            }

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
            btnOrderEntryAddPayments.Visible = true;
            btnOrderEntryDeleteItem.Visible = true;
            btnOrderEntryChangeStatus.Visible = true;
            btnOrderEntryStatus.Visible = true;
            fullOrderProductsDataGridView.Visible = true;
            productsDataGridView.Visible = true;
            lblOrderEntrySumPaid.Visible = true;
            lblOrderEntrySumItems.Visible = true;
            lblOrderEntryBalance.Visible = true;
            lblOrderEntryStatus.Visible = true;
            InitializeAdapters();
        }

        void GetOrderProducts()
        {
            try
            {

                this.fullOrderProductsTableAdapter.FillOrderProductsFull(this.pOSdbDataSet.FullOrderProducts, index);
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
                //lblOrderEntrySumItems.Text = "sum Amount" + fad.SumOrder(index);
            }
        }

        private void fillOrderProductsFullToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void dgvOrderEntryCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOrderEntrySetOrder_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void fullOrderProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOrderEntryAddPayments_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment(index);
            payment.ShowDialog();
        }

        private void OrderEntry_Activated(object sender, EventArgs e)
        {
            
        }

        private void btnOrderEntryStatus_Click(object sender, EventArgs e)
        {
            Status status = new Status(index);
            status.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
