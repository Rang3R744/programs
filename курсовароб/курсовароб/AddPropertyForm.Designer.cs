namespace course
{
    partial class AddPropertyForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Button GetBtnCancel()
        {
            return btnCancel;
        }

        #region Windows Form Designer code

        private void InitializeComponent(Button btnCancel)
        {
            lblAddress = new System.Windows.Forms.Label();
            lblArea = new System.Windows.Forms.Label();
            lblPrice = new System.Windows.Forms.Label();
            lblType = new System.Windows.Forms.Label();
            lblExtra = new System.Windows.Forms.Label();

            txtAddress = new System.Windows.Forms.TextBox();
            txtArea = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            txtExtra = new System.Windows.Forms.TextBox();

            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();

            SuspendLayout();
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new System.Drawing.Point(23, 28);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(62, 20);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Адреса:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(150, 25);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(220, 27);
            txtAddress.TabIndex = 1;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new System.Drawing.Point(23, 72);
            lblArea.Name = "lblArea";
            lblArea.Size = new System.Drawing.Size(60, 20);
            lblArea.TabIndex = 2;
            lblArea.Text = "Площа:";
            // 
            // txtArea
            // 
            txtArea.Location = new System.Drawing.Point(150, 69);
            txtArea.Name = "txtArea";
            txtArea.Size = new System.Drawing.Size(220, 27);
            txtArea.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(23, 116);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(44, 20);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Ціна:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(150, 113);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(220, 27);
            txtPrice.TabIndex = 5;
            // 
            // lblExtra
            // 
            lblExtra.AutoSize = true;
            lblExtra.Location = new System.Drawing.Point(23, 159);
            lblExtra.Name = "lblExtra";
            lblExtra.Size = new System.Drawing.Size(99, 20);
            lblExtra.TabIndex = 8;
            lblExtra.Text = "Поверх/Земля:";
            // 
            // txtExtra
            // 
            txtExtra.Location = new System.Drawing.Point(150, 156);
            txtExtra.Name = "txtExtra";
            txtExtra.Size = new System.Drawing.Size(220, 27);
            txtExtra.TabIndex = 9;
            // 
            // btnOK
            // 
            btnOK.Location = new System.Drawing.Point(150, 200);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(100, 35);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(270, 200);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(100, 35);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += (s, e) => Close();
            // 
            // AddPropertyForm
            // 
            ClientSize = new System.Drawing.Size(400, 250);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblArea);
            Controls.Add(txtArea);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblType);
            Controls.Add(comboType);
            Controls.Add(lblExtra);
            Controls.Add(txtExtra);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);

            Name = "AddPropertyForm";
            Text = "Додати нерухомість";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblExtra;

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtExtra;

        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
