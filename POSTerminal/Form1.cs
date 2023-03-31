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
    }
}
