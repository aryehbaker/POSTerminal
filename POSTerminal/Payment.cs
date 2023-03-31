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
    public partial class Payment : Form
    {
        private int index;

        public Payment()
        {
            InitializeComponent();
        }

        public Payment(int index)
        {
            this.index = index;
            InitializeComponent();
        }

        private void paymentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pOSdbDataSet);

        }

        private void Payment_Load(object sender, EventArgs e)
        {
           

        }

        private void btnPaymentSubmit_Click(object sender, EventArgs e)
        {
            decimal result;
            if (decimal.TryParse(txtPaymentAmount.Text, out result)) { 
            POSdbDataSetTableAdapters.PaymentsTableAdapter pa =
                new POSdbDataSetTableAdapters.PaymentsTableAdapter();
                pa.Insert(index, result, dtPaymentDatPicker.Value);
                this.Close();
                    }

        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
