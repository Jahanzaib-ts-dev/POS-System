using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point_of_Sale.Working;

namespace Point_of_Sale.Forms
{
    public partial class CashReturnForm : Form
    {
        HelpingFunction helpingFunction = new HelpingFunction();
        public CashReturnForm()
        {
            InitializeComponent();
        }

        public CashReturnForm(string total)
        {
            InitializeComponent();
            this.total_bill_count.Text = total;
        }

        private void end_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cash_received_textbox_TextChanged(object sender, EventArgs e)
        {
            if(cash_received_textbox.Text == "" || cash_received_textbox.Text == ".")
            {
                cash_return_count.Text = Convert.ToString(0.0);
            }
            else
            {
                cash_return_count.Text = Convert.ToString(Math.Round(-1 * (Convert.ToDouble(total_bill_count.Text) - Convert.ToDouble(cash_received_textbox.Text)) , 2));
            }
            
        }

        private void cash_received_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            helpingFunction.Only_Decimal_KeyPress(sender, e , cash_received_textbox.Text.Trim());
        }
    }
}
