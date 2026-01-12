namespace course
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            listBoxProperties = new ListBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSale = new Button();
            btnReport = new Button();
            btnSave = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // listBoxProperties
            // 
            listBoxProperties.FormattingEnabled = true;
            listBoxProperties.ItemHeight = 15;
            listBoxProperties.Location = new Point(20, 32);
            listBoxProperties.Margin = new Padding(3, 2, 3, 2);
            listBoxProperties.Name = "listBoxProperties";
            listBoxProperties.Size = new Size(438, 199);
            listBoxProperties.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(481, 31);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 30);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(481, 65);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(131, 30);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Редагувати";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(481, 99);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 30);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSale
            // 
            btnSale.Location = new Point(481, 133);
            btnSale.Margin = new Padding(3, 2, 3, 2);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(131, 30);
            btnSale.TabIndex = 4;
            btnSale.Text = "Продаж";
            btnSale.UseVisualStyleBackColor = true;
            btnSale.Click += btnSale_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(481, 167);
            btnReport.Margin = new Padding(3, 2, 3, 2);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(131, 30);
            btnReport.TabIndex = 5;
            btnReport.Text = "Звіт";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(481, 201);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 30);
            btnSave.TabIndex = 6;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(202, 25);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Список нерухомості";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 263);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            Controls.Add(btnReport);
            Controls.Add(btnSale);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(listBoxProperties);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Продаж нерухомості";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProperties;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
    }
}
