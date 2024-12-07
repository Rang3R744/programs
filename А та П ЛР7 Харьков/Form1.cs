using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbX1.Text) || string.IsNullOrEmpty(tbX2.Text))
            {
                tbY.Text = "Не введено даних!";
                return;
            }
            try
            {
                double x1 = double.Parse(tbX1.Text);
                double x2 = double.Parse(tbX2.Text);
                if (Math.Cos(x2) == 0)
                {
                    MessageBox.Show("Значення x2 не повинно призводити до ділення на нуль (cos(x2) = 0)!", "Помилка обчислення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double avg = (x1 + x2) / 2;
                double numerator = x2;
                double denominator = x1 + 53 * Math.Pow(x2, 2);
                double y = Math.Pow(Math.Sin(x1 * (numerator / denominator)), 2);
                tbY.Text = y.ToString("F4");
                MessageBox.Show($"Середнє арифметичне: {avg.ToString("F4")}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення!", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Text = string.Empty;
            tbX2.Text = string.Empty;
            tbY.Text = string.Empty;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}