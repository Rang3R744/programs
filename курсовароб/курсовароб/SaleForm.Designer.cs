using System.Drawing;
using System.Windows.Forms;

namespace course
{
    partial class SaleForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblInfo = new Label();
            // Buyer
            lblBuyer = new Label();
            txtBuyerName = new TextBox();
            txtBuyerContact = new TextBox();
            // Seller
            lblSeller = new Label();
            txtSellerName = new TextBox();
            txtSellerContact = new TextBox();
            // Agent
            lblAgent = new Label();
            txtAgentName = new TextBox();
            txtAgency = new TextBox();
            txtCommission = new TextBox();
            // Final price
            lblFinalPrice = new Label();
            txtFinalPrice = new TextBox();
            // Buttons
            btnOK = new Button();
            btnCancel = new Button();

            SuspendLayout();

            // lblInfo
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInfo.Location = new Point(20, 15);
            lblInfo.Size = new Size(350, 23);
            lblInfo.Text = "Продаж";

            // Buyer labels/fields
            lblBuyer.AutoSize = true;
            lblBuyer.Location = new Point(20, 50);
            lblBuyer.Text = "Покупець (Ім'я, Контакт):";

            txtBuyerName.Location = new Point(20, 72);
            txtBuyerName.Size = new Size(330, 27);
            txtBuyerName.PlaceholderText = "ПІБ покупця";

            txtBuyerContact.Location = new Point(20, 102);
            txtBuyerContact.Size = new Size(330, 27);
            txtBuyerContact.PlaceholderText = "Контакт покупця";

            // Seller
            lblSeller.AutoSize = true;
            lblSeller.Location = new Point(20, 140);
            lblSeller.Text = "Продавець (Ім'я, Контакт):";

            txtSellerName.Location = new Point(20, 162);
            txtSellerName.Size = new Size(330, 27);

            txtSellerContact.Location = new Point(20, 192);
            txtSellerContact.Size = new Size(330, 27);

            // Agent
            lblAgent.AutoSize = true;
            lblAgent.Location = new Point(20, 230);
            lblAgent.Text = "Агент (Ім'я, Агенція, Комісія):";

            txtAgentName.Location = new Point(20, 252);
            txtAgentName.Size = new Size(220, 27);
            txtAgentName.PlaceholderText = "Ім'я агента";

            txtAgency.Location = new Point(20, 282);
            txtAgency.Size = new Size(220, 27);
            txtAgency.PlaceholderText = "Агенція";

            txtCommission.Location = new Point(250, 252);
            txtCommission.Size = new Size(100, 27);
            txtCommission.PlaceholderText = "Комісія %";

            // Final price
            lblFinalPrice.AutoSize = true;
            lblFinalPrice.Location = new Point(20, 320);
            lblFinalPrice.Text = "Ціна продажу:";

            txtFinalPrice.Location = new Point(20, 342);
            txtFinalPrice.Size = new Size(330, 27);

            // Buttons
            btnOK.Location = new Point(20, 380);
            btnOK.Size = new Size(160, 36);
            btnOK.Text = "Зберегти продаж";
            btnOK.Click += new System.EventHandler(this.btnOK_Click);

            btnCancel.Location = new Point(190, 380);
            btnCancel.Size = new Size(160, 36);
            btnCancel.Text = "Скасувати";
            btnCancel.Click += (s, e) => Close();

            // Form
            ClientSize = new Size(380, 430);
            Controls.Add(lblInfo);
            Controls.Add(lblBuyer);
            Controls.Add(txtBuyerName);
            Controls.Add(txtBuyerContact);
            Controls.Add(lblSeller);
            Controls.Add(txtSellerName);
            Controls.Add(txtSellerContact);
            Controls.Add(lblAgent);
            Controls.Add(txtAgentName);
            Controls.Add(txtAgency);
            Controls.Add(txtCommission);
            Controls.Add(lblFinalPrice);
            Controls.Add(txtFinalPrice);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "SaleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Оформлення продажу";

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblInfo;
        private Label lblBuyer;
        private TextBox txtBuyerName;
        private TextBox txtBuyerContact;
        private Label lblSeller;
        private TextBox txtSellerName;
        private TextBox txtSellerContact;
        private Label lblAgent;
        private TextBox txtAgentName;
        private TextBox txtAgency;
        private TextBox txtCommission;
        private Label lblFinalPrice;
        private TextBox txtFinalPrice;
        private Button btnOK;
        private Button btnCancel;
    }
}
