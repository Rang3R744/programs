namespace course
{
    partial class EditPropertyForm
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
            lblAddress = new System.Windows.Forms.Label();
            txtAddress = new System.Windows.Forms.TextBox();
            lblArea = new System.Windows.Forms.Label();
            txtArea = new System.Windows.Forms.TextBox();
            lblPrice = new System.Windows.Forms.Label();
            txtPrice = new System.Windows.Forms.TextBox();
            lblStatus = new System.Windows.Forms.Label();
            comboStatus = new System.Windows.Forms.ComboBox();
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();

            SuspendLayout();

            lblAddress.AutoSize = true;
            lblAddress.Location = new System.Drawing.Point(23, 28);
            lblAddress.Text = "Адреса:";

            txtAddress.Location = new System.Drawing.Point(150, 25);
            txtAddress.Size = new System.Drawing.Size(220, 27);

            lblArea.AutoSize = true;
            lblArea.Location = new System.Drawing.Point(23, 72);
            lblArea.Text = "Площа:";

            txtArea.Location = new System.Drawing.Point(150, 69);
            txtArea.Size = new System.Drawing.Size(220, 27);

            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(23, 116);
            lblPrice.Text = "Ціна:";

            txtPrice.Location = new System.Drawing.Point(150, 113);
            txtPrice.Size = new System.Drawing.Size(220, 27);

            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(23, 159);
            lblStatus.Text = "Статус:";

            comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboStatus.Items.AddRange(new object[] { "Продається", "Продано", "Заброньовано" });
            comboStatus.Location = new System.Drawing.Point(150, 155);
            comboStatus.Size = new System.Drawing.Size(220, 28);

            btnOK.Location = new System.Drawing.Point(150, 210);
            btnOK.Size = new System.Drawing.Size(100, 35);
            btnOK.Text = "OK";
            btnOK.Click += new System.EventHandler(this.btnOK_Click);

            btnCancel.Location = new System.Drawing.Point(270, 210);
            btnCancel.Size = new System.Drawing.Size(100, 35);
            btnCancel.Text = "Скасувати";
            btnCancel.Click += (s, e) => Close();

            ClientSize = new System.Drawing.Size(400, 270);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblArea);
            Controls.Add(txtArea);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblStatus);
            Controls.Add(comboStatus);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);

            Text = "Редагувати нерухомість";

            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
