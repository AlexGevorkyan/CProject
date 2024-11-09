using CProject.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.ComponentModel.Design.Serialization;
using System.Windows.Forms;

namespace CProject
{
    public partial class Form1 : Form
    {
        List<Phone> phones;
        List<Brand> brands;
        PhoneContext context;

        private int selectedBrandId;  // cтворила як змінну для зберігання обраного бренду в ComboBox

        public Form1()
        {
            InitializeComponent();

            context = new PhoneContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            phones = context.Phone.ToList();
            dgPhone.DataSource = phones;

            brands = context.Brand.ToList();
            cbBrand.DisplayMember = "BrandName";
            cbBrand.ValueMember = "id";
            cbBrand.DataSource = brands;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbModel.Text.Trim() == "" || cbBrand.Text.Trim() == "")
            {
                MessageBox.Show("");
                return;
            }
            Phone phone = new Phone
            {
                Model = tbModel.Text.Trim(),
                BrandId = selectedBrandId,
                Price = Convert.ToInt32(tbPrice.Text.Trim()),
                Description = tbDescription.Text.Trim()
            };
            context.Phone.Add(phone);
        }

        private void btBrand_Click(object sender, EventArgs e)
        {
            if (tbBrand.Text.Trim() == "")
            {
                MessageBox.Show("");
                return;
            }
            Brand brand = new Brand
            {
                BrandName = tbBrand.Text.Trim()
            };
        }

        private void tbBrand_TextChanged(object sender, EventArgs e)
        {
            if (cbBrand.SelectedIndex == 0) return;
            selectedBrandId = ((Brand)cbBrand.SelectedItem).Id;
        }
    }
}
