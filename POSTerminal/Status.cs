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
    public partial class Status : Form
    {
        int index;
        decimal payed;
        decimal amount;
        decimal balance;
        int statusInt;
        bool upgrade = true;
        POSdbDataSetTableAdapters.PaymentsTableAdapter ad;
        POSdbDataSetTableAdapters.FullOrderProductsTableAdapter fad;
        POSdbDataSetTableAdapters.OrdersTableAdapter ot;
        public Status(int index)
        {
            InitializeComponent();
            this.index = index;
            POSdbDataSet.OrdersDataTable dt = new POSdbDataSet.OrdersDataTable();
            dt = ot.GetDataByOrderId(index);
            statusInt = dt.FirstOrDefault().Status;
            if(statusInt == 1) { 
            ad =
               new POSdbDataSetTableAdapters.PaymentsTableAdapter();
            fad = new POSdbDataSetTableAdapters.FullOrderProductsTableAdapter();
            ot = new POSdbDataSetTableAdapters.OrdersTableAdapter();
            
            payed = (decimal)ad.SumPayed(index);
            amount = (decimal)fad.SumOrder(index);
            balance = amount - balance;
                if(balance > 0)
                {
                    upgrade = false;
                }
            }
        }

        private void Status_Load(object sender, EventArgs e)
        {
            if(upgrade == false)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
