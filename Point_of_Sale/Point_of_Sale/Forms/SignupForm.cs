using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point_of_Sale.DAO;

namespace Point_of_Sale.Forms
{
    public partial class SignupForm : Form
    {
        EmployeeDAO employeeDAO = new EmployeeDAO();
        string[] roles;
        public SignupForm()
        {
            InitializeComponent();
            roles = new string[] { "Owner" , "Cashier" , "Inventory Manager"};
            role_combobox.Items.AddRange(roles);
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            if(username_textbox.Text.Trim() != "" && password_textbox.Text.Trim() != "" && retype_password_textbox.Text.Trim() != "" && role_combobox.Text.Trim() != "")
            {
                if(password_textbox.Text.Trim() != retype_password_textbox.Text.Trim())
                {
                    MessageBox.Show("Re-Type Password did not match");
                }
                else
                {
                    employeeDAO.Insert_Employee(username_textbox.Text.Trim() , role_combobox.Text.Trim() , password_textbox.Text.Trim() , DateTimePick.Value.ToString("dd/MM/yyyy"));
                    this.Hide();
                }
            }
            else { MessageBox.Show("Any of your field is Empty"); }

        }
    }
}
