using Furniture.BL;
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
    public partial class FormXML : Form
    {
        public FormXML()
        {
            InitializeComponent();
        }

        private void FormXML_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            UserOperations ez = new UserOperations();
            ez.Raport(s);

        }
    }
}
