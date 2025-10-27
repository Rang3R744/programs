using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab04
{
    public partial class fMain : Form
    {
        private BindingSource bindSrcTablets = new BindingSource();
        private List<Tablet> tablets = new List<Tablet>();

        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            bindSrcTablets.DataSource = tablets;
            gvTablets.DataSource = bindSrcTablets;

            tablets.Add(new Tablet("Samsung", "Galaxy Tab S9", 11.0, 256, true, 899, 12, 120));
            bindSrcTablets.ResetBindings(false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fTablet dlg = new fTablet();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                bindSrcTablets.Add(dlg.TabletData);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bindSrcTablets.Current is Tablet tablet)
            {
                fTablet dlg = new fTablet(tablet);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    bindSrcTablets.ResetBindings(false);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bindSrcTablets.Current != null)
                bindSrcTablets.RemoveCurrent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tablets.Clear();
            bindSrcTablets.ResetBindings(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}