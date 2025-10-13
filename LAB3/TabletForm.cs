using System;
using System.Windows.Forms;

namespace TabletApp
{
    public partial class TabletForm : Form
    {
        public Tablet TabletData { get; private set; }

        public TabletForm()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                TabletData = new Tablet
                {
                    Brand = tbBrand.Text,
                    Model = tbModel.Text,
                    ScreenSize = int.Parse(tbScreenSize.Text),
                    Storage = int.Parse(tbStorage.Text),
                    Price = int.Parse(tbPrice.Text),
                    RefreshRate = int.Parse(tbRefreshRate.Text),
                };
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка введення: " +  ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}