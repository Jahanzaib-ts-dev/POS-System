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
using Point_of_Sale.Entities;

namespace Point_of_Sale.Forms
{
    public partial class LoginForm : Form
    {
        EmployeeDAO employeeDAO = new EmployeeDAO();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Employees employees = employeeDAO.Select_by_username_and_password(username_textbox.Text.Trim(), password_textbox.Text.Trim());
            if(employees != null)
            {
                PointofSaleForm pointofSaleForm = new PointofSaleForm(employees.Username.Trim() , employees.Role.Trim());
                pointofSaleForm.Show();
                username_textbox.Text = ""; password_textbox.Text = "";
            }
            else { MessageBox.Show("Incorrect Username or Password!"); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_label_Click(object sender, EventArgs e)
        {

        }

        private void username_label_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_LABEL_Click(object sender, EventArgs e)
        {

        }

        private void PointofSale_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
