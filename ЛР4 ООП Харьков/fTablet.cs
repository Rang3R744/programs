using System;
using System.Windows.Forms;

namespace Lab04
{
    public partial class fTablet : Form
    {
        public Tablet TabletData { get; private set; }

        public fTablet()
        {
            InitializeComponent();
            TabletData = new Tablet();
        }

        public fTablet(Tablet existingTablet) : this()
        {
            if (existingTablet != null)
            {
                TabletData = existingTablet;
                tbBrand.Text = existingTablet.Brand;
                tbModel.Text = existingTablet.Model;
                numScreen.Value = (decimal)existingTablet.ScreenSize;
                numStorage.Value = existingTablet.Storage;
                cbMobile.Checked = existingTablet.HasMobileNetwork;
                numPrice.Value = (decimal)existingTablet.Price;
                numBattery.Value = (decimal)existingTablet.BatteryLife;
                numRefresh.Value = existingTablet.RefreshRate;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbBrand.Text) || string.IsNullOrWhiteSpace(tbModel.Text))
            {
                MessageBox.Show("Будь ласка, заповніть поля «Бренд» і «Модель».", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TabletData.Brand = tbBrand.Text;
            TabletData.Model = tbModel.Text;
            TabletData.ScreenSize = (double)numScreen.Value;
            TabletData.Storage = (int)numStorage.Value;
            TabletData.HasMobileNetwork = cbMobile.Checked;
            TabletData.Price = (double)numPrice.Value;
            TabletData.BatteryLife = (double)numBattery.Value;
            TabletData.RefreshRate = (int)numRefresh.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
