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
    public partial class AddItems : Form
    {
        int orderId;
        public AddItems(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pOSdbDataSet);

        }

        private void AddItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSdbDataSet.OrdersProducts' table. You can move, or remove it, as needed.
            this.ordersProductsTableAdapter.Fill(this.pOSdbDataSet.OrdersProducts);
            // TODO: This line of code loads data into the 'pOSdbDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.pOSdbDataSet.Products);

        }
    }
}
