namespace TabletApp
{
    partial class TabletForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbScreenSize;
        private System.Windows.Forms.TextBox tbStorage;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbRefreshRate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tbBrand = new TextBox();
            tbModel = new TextBox();
            tbScreenSize = new TextBox();
            tbStorage = new TextBox();
            tbPrice = new TextBox();
            tbRefreshRate = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // tbBrand
            // 
            tbBrand.Location = new Point(250, 20);
            tbBrand.Name = "tbBrand";
            tbBrand.Size = new Size(100, 23);
            tbBrand.TabIndex = 6;
            // 
            // tbModel
            // 
            tbModel.Location = new Point(250, 60);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(100, 23);
            tbModel.TabIndex = 7;
            // 
            // tbScreenSize
            // 
            tbScreenSize.Location = new Point(250, 97);
            tbScreenSize.Name = "tbScreenSize";
            tbScreenSize.Size = new Size(100, 23);
            tbScreenSize.TabIndex = 8;
            // 
            // tbStorage
            // 
            tbStorage.Location = new Point(250, 140);
            tbStorage.Name = "tbStorage";
            tbStorage.Size = new Size(100, 23);
            tbStorage.TabIndex = 9;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(250, 180);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(100, 23);
            tbPrice.TabIndex = 10;
            // 
            // tbRefreshRate
            // 
            tbRefreshRate.Location = new Point(250, 220);
            tbRefreshRate.Name = "tbRefreshRate";
            tbRefreshRate.Size = new Size(100, 23);
            tbRefreshRate.TabIndex = 11;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(120, 310);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(85, 34);
            btnOK.TabIndex = 12;
            btnOK.Text = "OK";
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(237, 310);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(89, 34);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Бренд:";
            // 
            // label2
            // 
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "Модель:";
            // 
            // label3
            // 
            label3.Location = new Point(20, 100);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Розмір екрану (дюйм):";
            // 
            // label4
            // 
            label4.Location = new Point(20, 140);
            label4.Name = "label4";
            label4.Size = new Size(136, 40);
            label4.TabIndex = 3;
            label4.Text = "Обсяг пам'яті (ГБ):";
            // 
            // label5
            // 
            label5.Location = new Point(20, 180);
            label5.Name = "label5";
            label5.Size = new Size(185, 40);
            label5.TabIndex = 4;
            label5.Text = "Ціна (долари):";
            // 
            // label6
            // 
            label6.Location = new Point(20, 220);
            label6.Name = "label6";
            label6.Size = new Size(200, 40);
            label6.TabIndex = 5;
            label6.Text = "Частота оновлення екрану (ГЦ):";
            // 
            // TabletForm
            // 
            ClientSize = new Size(446, 385);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(tbBrand);
            Controls.Add(tbModel);
            Controls.Add(tbScreenSize);
            Controls.Add(tbStorage);
            Controls.Add(tbPrice);
            Controls.Add(tbRefreshRate);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Name = "TabletForm";
            Text = "Введення даних про планшет";
            ResumeLayout(false);
            PerformLayout();

        }
    }
}