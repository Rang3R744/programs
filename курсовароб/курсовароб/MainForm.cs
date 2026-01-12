using course.Models;
using course.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace course
{
    public partial class MainForm : Form
    {
        private List<Property> properties;
        private List<Transaction> transactions;

        public MainForm()
        {
            InitializeComponent();
            properties = DataService.Load();
            transactions = DataService.LoadTransactions();
            RefreshList();
        }

        private void RefreshList()
        {
            listBoxProperties.Items.Clear();
            foreach (var p in properties)
                listBoxProperties.Items.Add(p);
        }

        // ✅ ВИБІР ТИПУ ПЕРЕД СТВОРЕННЯМ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show(
                "Додати квартиру?\n\nТак — Квартира\nНі — Будинок",
                "Тип нерухомості",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            AddPropertyForm form = new AddPropertyForm
            {
                IsApartment = (choice == DialogResult.Yes)
            };

            if (form.ShowDialog() == DialogResult.OK)
            {
                properties.Add(form.CreatedProperty);
                RefreshList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxProperties.SelectedItem is Property selected)
            {
                EditPropertyForm form = new EditPropertyForm(selected);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshList();
                }
            }
            else
            {
                MessageBox.Show("Виберіть об'єкт для редагування!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxProperties.SelectedItem is Property p)
            {
                var res = MessageBox.Show(
                    $"Видалити {p.Address}?",
                    "Підтвердження",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    properties.Remove(p);
                    RefreshList();
                }
            }
            else
            {
                MessageBox.Show("Виберіть об'єкт для видалення!");
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (listBoxProperties.SelectedItem is not Property p)
            {
                MessageBox.Show("Оберіть нерухомість!");
                return;
            }

            SaleForm form = new SaleForm(p);
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.CreatedTransaction != null)
                {
                    transactions.Add(form.CreatedTransaction);
                    p.Status = "Продано";
                    RefreshList();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataService.Save(properties);
            DataService.SaveTransactions(transactions);
            MessageBox.Show("Дані збережено!");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm(transactions);
            form.ShowDialog();
        }
    }
}

