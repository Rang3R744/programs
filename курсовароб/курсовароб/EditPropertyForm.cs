using course.Models;
using System;
using System.Windows.Forms;

namespace course
{
    public partial class EditPropertyForm : Form
    {
        private Property property;

        public EditPropertyForm(Property p)
        {
            InitializeComponent();
            property = p;

            txtAddress.Text = p.Address;
            txtArea.Text = p.Area.ToString();
            txtPrice.Text = p.Price.ToString();
            comboStatus.Text = p.Status;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            property.Address = txtAddress.Text;
            if (int.TryParse(txtArea.Text, out int area))
                property.Area = area;
            if (double.TryParse(txtPrice.Text, out double price))
                property.Price = price;

            property.Status = comboStatus.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
