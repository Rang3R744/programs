using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace TabletApp
{
    public partial class Form1 : Form
    {
        private List<Tablet> tablets = new List<Tablet>();
        public Form1()
        {
            InitializeComponent();

            btnAddTablet.Click += btnAddTablet_Click;
            lbTablets.SelectedIndexChanged += lbTablets_SelectedIndexChanged;
        }
        private void btnAddTablet_Click(object sender, EventArgs e)
        {
            using (var form = new TabletForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    tablets.Add(form.TabletData);
                    lbTablets.Items.Add($"{form.TabletData.Brand} {form.TabletData.Model}");
                }
            }
        }
        private void lbTablets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTablets.SelectedIndex >= 0)
            {
                tbInfo.Text = tablets[lbTablets.SelectedIndex].ToString();
            }
        }
    }
}