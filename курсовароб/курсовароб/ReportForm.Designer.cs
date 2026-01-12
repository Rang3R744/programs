using System.Drawing;
using System.Windows.Forms;

namespace course
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private ListBox listBox;
        private Label lblTotal;
        private Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            listBox = new ListBox();
            lblTotal = new Label();
            btnClose = new Button();

            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(23, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 32);
            lblTitle.Text = "Звіт про продажі";

            // listBox
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 20;
            listBox.Location = new Point(23, 64);
            listBox.Size = new Size(520, 264);

            // lblTotal
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(23, 350);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(260, 21);
            lblTotal.Text = "Загальна сума продажів: 0$";

            // btnClose
            btnClose.Location = new Point(423, 390);
            btnClose.Size = new Size(120, 40);
            btnClose.Text = "Закрити";
            btnClose.Click += (s, e) => Close();

            // Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 450);
            Controls.Add(lblTitle);
            Controls.Add(listBox);
            Controls.Add(lblTotal);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ReportForm";
            Text = "Звіт про продажі";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
