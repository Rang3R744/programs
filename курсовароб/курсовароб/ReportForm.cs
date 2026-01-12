using course.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace course
{
    public partial class ReportForm : Form
    {
        public ReportForm(List<Transaction> transactions)
        {
            InitializeComponent();

            double total = transactions.Sum(t => t.FinalPrice);
            lblTotal.Text = $"Загальна сума продажів: {total}$";

            listBox.Items.Clear();
            foreach (var t in transactions)
                listBox.Items.Add(t.ToString());
        }
    }
}
