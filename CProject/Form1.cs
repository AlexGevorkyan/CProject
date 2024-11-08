using CProject.Models;
using System.Diagnostics;

namespace CProject
{
    public partial class Form1 : Form
    {
        List<Phone> phones;
        List<Brand> brands;
        PhoneContext context;

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
            Phone phone = new Phone();
            {
                Model = tbModel.Text.Trim(),
                Brand = cbBrand.Text.Trim(),
                Price = tbPrice.Text.Trim(),
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
            BrandName = tbBrand.Text.Trim();
        }

        private void tbBrand_TextChanged(object sender, EventArgs e)
        {
            if (cbBrand.SelectedIndex == 0) return;
            selectedBrandId = ((Brand)cbBrand.SelectedItem).Id;
        }
    }
}
