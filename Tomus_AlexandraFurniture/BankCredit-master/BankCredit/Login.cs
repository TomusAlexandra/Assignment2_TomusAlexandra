﻿using Furniture.BL;
using Furniture.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Furniture
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserOperations bl = new UserOperations();

            User user = bl.Login(txtUser.Text, txtPassword.Text);

            if (!user.IsAdmin)
            {
                AdminLogin adminForm = new AdminLogin();
                adminForm.Show();
            }
            else
            {
                EmployeeLogin employee = new EmployeeLogin();
                employee.Show();
             
            }
        }
    }
}
