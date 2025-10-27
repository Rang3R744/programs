using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Lab04
{
    partial class fTablet : Form
    {
        private IContainer components = null;

        private TextBox tbBrand;
        private TextBox tbModel;
        private NumericUpDown numScreen;
        private NumericUpDown numStorage;
        private CheckBox cbMobile;
        private NumericUpDown numPrice;
        private NumericUpDown numBattery;
        private NumericUpDown numRefresh;
        private Button btnOK;
        private Button btnCancel;
        private Label lblBrand;
        private Label lblModel;
        private Label lblScreen;
        private Label lblStorage;
        private Label lblMobile;
        private Label lblPrice;
        private Label lblBattery;
        private Label lblRefresh;

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
            components = new Container();

            tbBrand = new TextBox();
            tbModel = new TextBox();
            numScreen = new NumericUpDown();
            numStorage = new NumericUpDown();
            cbMobile = new CheckBox();
            numPrice = new NumericUpDown();
            numBattery = new NumericUpDown();
            numRefresh = new NumericUpDown();
            btnOK = new Button();
            btnCancel = new Button();

            lblBrand = new Label();
            lblModel = new Label();
            lblScreen = new Label();
            lblStorage = new Label();
            lblMobile = new Label();
            lblPrice = new Label();
            lblBattery = new Label();
            lblRefresh = new Label();

            ((ISupportInitialize)(numScreen)).BeginInit();
            ((ISupportInitialize)(numStorage)).BeginInit();
            ((ISupportInitialize)(numPrice)).BeginInit();
            ((ISupportInitialize)(numBattery)).BeginInit();
            ((ISupportInitialize)(numRefresh)).BeginInit();

            // Form
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(440, 380);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Дані про планшет";

            int leftLabel = 16;
            int leftControl = 160;
            int top = 16;
            int vGap = 34;
            int labelWidth = 140;
            int controlWidth = 200;

            // lblBrand
            lblBrand.Text = "Бренд:";
            lblBrand.AutoSize = true;
            lblBrand.SetBounds(leftLabel, top, labelWidth, 23);
            tbBrand.SetBounds(leftControl, top - 3, controlWidth, 23);

            // lblModel
            top += vGap;
            lblModel.Text = "Модель:";
            lblModel.AutoSize = true;
            lblModel.SetBounds(leftLabel, top, labelWidth, 23);
            tbModel.SetBounds(leftControl, top - 3, controlWidth, 23);

            // lblScreen
            top += vGap;
            lblScreen.Text = "Розмір екрану (дюйми):";
            lblScreen.AutoSize = true;
            lblScreen.SetBounds(leftLabel, top, labelWidth, 23);
            numScreen.SetBounds(leftControl, top - 3, 120, 23);
            numScreen.DecimalPlaces = 1;
            numScreen.Minimum = 5;
            numScreen.Maximum = 30;
            numScreen.Value = 10;

            // lblStorage
            top += vGap;
            lblStorage.Text = "Обсяг пам'яті (ГБ):";
            lblStorage.AutoSize = true;
            lblStorage.SetBounds(leftLabel, top, labelWidth, 23);
            numStorage.SetBounds(leftControl, top - 3, 120, 23);
            numStorage.Minimum = 8;
            numStorage.Maximum = 4096;
            numStorage.Value = 64;
            numStorage.Increment = 8;

            // lblMobile
            top += vGap;
            lblMobile.Text = "Мобільна мережа:";
            lblMobile.AutoSize = true;
            lblMobile.SetBounds(leftLabel, top, labelWidth, 23);
            cbMobile.SetBounds(leftControl, top - 3, 120, 23);
            cbMobile.Text = "Підтримка моб. мережі";

            // lblPrice
            top += vGap;
            lblPrice.Text = "Ціна ($):";
            lblPrice.AutoSize = true;
            lblPrice.SetBounds(leftLabel, top, labelWidth, 23);
            numPrice.SetBounds(leftControl, top - 3, 120, 23);
            numPrice.DecimalPlaces = 2;
            numPrice.Minimum = 0;
            numPrice.Maximum = 10000;
            numPrice.Value = 300;

            // lblBattery
            top += vGap;
            lblBattery.Text = "Час роботи батареї (год):";
            lblBattery.AutoSize = true;
            lblBattery.SetBounds(leftLabel, top, labelWidth, 23);
            numBattery.SetBounds(leftControl, top - 3, 120, 23);
            numBattery.DecimalPlaces = 1;
            numBattery.Minimum = 1;
            numBattery.Maximum = 200;
            numBattery.Value = 8;

            // lblRefresh
            top += vGap;
            lblRefresh.Text = "Частота оновлення (Гц):";
            lblRefresh.AutoSize = true;
            lblRefresh.SetBounds(leftLabel, top, labelWidth, 23);
            numRefresh.SetBounds(leftControl, top - 3, 120, 23);
            numRefresh.Minimum = 30;
            numRefresh.Maximum = 240;
            numRefresh.Value = 60;

            // Buttons
            btnOK.Text = "OK";
            btnOK.SetBounds(120, top + 48, 90, 30);
            btnOK.Click += new EventHandler(this.btnOK_Click);

            btnCancel.Text = "Скасувати";
            btnCancel.SetBounds(240, top + 48, 90, 30);
            btnCancel.Click += new EventHandler(this.btnCancel_Click);

            this.Controls.AddRange(new Control[] {
                lblBrand, tbBrand,
                lblModel, tbModel,
                lblScreen, numScreen,
                lblStorage, numStorage,
                lblMobile, cbMobile,
                lblPrice, numPrice,
                lblBattery, numBattery,
                lblRefresh, numRefresh,
                btnOK, btnCancel
            });

            ((ISupportInitialize)(numScreen)).EndInit();
            ((ISupportInitialize)(numStorage)).EndInit();
            ((ISupportInitialize)(numPrice)).EndInit();
            ((ISupportInitialize)(numBattery)).EndInit();
            ((ISupportInitialize)(numRefresh)).EndInit();

            this.ResumeLayout(false);
        }
    }
}
