namespace TabletApp
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lbTablets;
        private System.Windows.Forms.Button btnAddTablet;
        private System.Windows.Forms.TextBox tbInfo;

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
            this.lbTablets = new System.Windows.Forms.ListBox();
            this.btnAddTablet = new System.Windows.Forms.Button();
            this.tbInfo = new System.Windows.Forms.TextBox();

            this.SuspendLayout();
            // 
            // lbTablets
            // 
            this.lbTablets.FormattingEnabled = true;
            this.lbTablets.ItemHeight = 16;
            this.lbTablets.Location = new System.Drawing.Point(20, 20);
            this.lbTablets.Name = "lbTablets";
            this.lbTablets.Size = new System.Drawing.Size(500, 180);
            this.lbTablets.TabIndex = 0;
            // 
            // btnAddTablet
            // 
            this.btnAddTablet.Location = new System.Drawing.Point(20, 300);
            this.btnAddTablet.Name = "btnAddTablet";
            this.btnAddTablet.Size = new System.Drawing.Size(150, 35);
            this.btnAddTablet.TabIndex = 1;
            this.btnAddTablet.Text = "Додати планшет";
            this.btnAddTablet.UseVisualStyleBackColor = true;
            this.btnAddTablet.Click += new System.EventHandler(this.btnAddTablet_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(20, 210);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInfo.Size = new System.Drawing.Size(500, 80);
            this.tbInfo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 360);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.btnAddTablet);
            this.Controls.Add(this.lbTablets);
            this.Name = "Form1";
            this.Text = "Перелік планшетів";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
