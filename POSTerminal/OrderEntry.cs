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
        POSdbDataSetTableAdapters.PaymentsTableAdapter ad;
        POSdbDataSetTableAdapters.FullOrderProductsTableAdapter fad;
        int index = -1;
        public OrderEntry()
        {
            InitializeComponent();
            ad =
               new POSdbDataSetTableAdapters.PaymentsTableAdapter();
            fad = new POSdbDataSetTableAdapters.FullOrderProductsTableAdapter();
        }
        public OrderEntry(int index)
        {
            InitializeComponent();
            SetFormForEditingAndProductSelection();
            ad =
                new POSdbDataSetTableAdapters.PaymentsTableAdapter();
            fad = new POSdbDataSetTableAdapters.FullOrderProductsTableAdapter();

            lblOrderEntrySumPaid.Text = "sum Paid: " + ad.SumPayed(index);
            lblOrderEntrySumItems.Text = "sum Amount" + fad.SumOrder(index);
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
            dgvOrderEntryCustomers.Enabled = false;
            btnOrderEntrySelectCustomer.Text = "Change Customer";
            btnOrderEntryAddItems.Visible = true;
            btnOrderEntryDelete.Visible = true;
            btnOrderEntrySetOrder.Visible = true;
            btnOrderEntryAddPayments.Visible = true;
            btnOrderEntryDeleteItem.Visible = true;
            fullOrderProductsDataGridView.Visible = true;
            productsDataGridView.Visible = true;
            lblOrderEntrySumPaid.Visible = true;
            lblOrderEntrySumItems.Visible = true;
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
                lblOrderEntrySumItems.Text = "sum Amount" + fad.SumOrder(index);
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
                lblOrderEntrySumItems.Text = "sum Amount" + fad.SumOrder(index);
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
            lblOrderEntrySumPaid.Text = "sum Paid: " + ad.SumPayed(index);
        }
    }
}
