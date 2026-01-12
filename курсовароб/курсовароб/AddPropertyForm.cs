using course.Models;
using course.Models;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace course
{
    public partial class AddPropertyForm : Form
    {
        public Property CreatedProperty { get; private set; }

        public bool IsApartment { get; set; }

        public AddPropertyForm()
        {
            InitializeComponent(null);
        }

        public AddPropertyForm(Button btnCancel)
        {
            InitializeComponent(btnCancel);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Введіть адресу");
                return;
            }

            if (!int.TryParse(txtArea.Text, out int area))
            {
                MessageBox.Show("Невірна площа");
                return;
            }

            if (!double.TryParse(txtPrice.Text, out double price))
            {
                MessageBox.Show("Невірна ціна");
                return;
            }

            string address = txtAddress.Text;

            if (IsApartment)
            {
                if (!int.TryParse(txtExtra.Text, out int floor))
                {
                    MessageBox.Show("Невірний поверх");
                    return;
                }

                Apartment apartment =
                    new Apartment(address, area, price, floor);

                apartment.Price = apartment.CalculateValue();

                CreatedProperty = apartment;
            }
            else
            {
                if (!double.TryParse(txtExtra.Text, out double landArea))
                {
                    MessageBox.Show("Невірна площа ділянки");
                    return;
                }

                House house =
                    new House(address, area, price, landArea);

                house.Price = house.CalculateValue();

                CreatedProperty = house;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
