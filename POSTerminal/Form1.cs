using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSTerminal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.ShowDialog();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ShowDialog();
        }

        private void btnAddOrders_Click(object sender, EventArgs e)
        {
            OrderEntry orderEntry = new OrderEntry();
            orderEntry.Show();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pOSdbDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSdbDataSet.OrdersAndAmounts' table. You can move, or remove it, as needed.
            this.ordersAndAmountsTableAdapter.Fill(this.pOSdbDataSet.OrdersAndAmounts);
            // TODO: This line of code loads data into the 'pOSdbDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.pOSdbDataSet.Orders);

        }


        private void btnOrderReview_Click(object sender, EventArgs e)
        {
            if(ordersAndAmountsDataGridView.SelectedRows.Count == 1) {
                int index = (int)ordersAndAmountsDataGridView.SelectedRows[0].Cells[0].Value;
                OrderEntry order = new OrderEntry(index);
                order.ShowDialog();
            }

        }
    }
}
