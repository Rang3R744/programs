using course.Models;
using System;
using System.Windows.Forms;

namespace course
{
    public partial class SaleForm : Form
    {
        private Property property;
        public Transaction CreatedTransaction { get; private set; }

        public SaleForm(Property p)
        {
            InitializeComponent();
            property = p;
            lblInfo.Text = $"Продаж: {p.Type} - {p.Address}";
            txtFinalPrice.Text = p.Price.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var buyer = new Buyer(txtBuyerName.Text, txtBuyerContact.Text);
            var seller = new Seller(txtSellerName.Text, txtSellerContact.Text);
            if (!double.TryParse(txtCommission.Text, out double commission)) commission = 0;
            var agent = new Agent(txtAgentName.Text, txtAgency.Text, commission);
            if (!double.TryParse(txtFinalPrice.Text, out double finalPrice)) finalPrice = property.Price;

            CreatedTransaction = new Transaction(property, buyer, seller, agent, finalPrice);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
