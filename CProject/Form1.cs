using CProject.Models;

namespace CProject
{
    public partial class Form1 : Form
    {
        List<Phone> phones;
        List<Brand> brands;
        PhoneContext phoneContext;
        //int selectedPhoneId = 1;
        public Form1()
        {
            InitializeComponent();
            phoneContext = new PhoneContext();
            dgvCatalog.RowHeaderMouseClick += DgvCatalog_RowHeaderMouseClick;
            dgvCatalog.RowTemplate.Height = 45;

            cbBrand.DisplayMember = "BrandName";
            cbBrand.ValueMember = "Id";
            PopulateBrandList();
        }

        private void PopulateBrandList()
        {
            brands = phoneContext.Brand.ToList();
            cbBrand.DataSource = brands;
        }

        private void DgvCatalog_RowHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedPhoneId = Convert.ToInt32(dgvCatalog.Rows[e.RowIndex].Cells["Id"].Value);
            // Cells["Id"] дозволяє звернутися до конкретної комірки, яка має назву "Id".
            //MessageBox.Show(selectedPhoneId.ToString());
            Info info = new Info(selectedPhoneId);
            info.ShowDialog();
        }

        private void dgvCatalog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            PopulatePhoneList();
        }

        private void PopulatePhoneList()
        {
            // Завантажуємо дані з бази даних з використанням об'єднання таблиць
            var phones = phoneContext.Phone
                .Select(p => new
                {
                    p.Id,
                    p.Model,
                    Brand = p.Brand.BrandName,
                    p.Price,
                    p.Description,
                    p.Count

                })
                .ToList();

            // Встановлюємо DataSource для DataGridView
            dgvCatalog.DataSource = phones;
        }

        private void btBrand_Click(object sender, EventArgs e)
        {
            if (tbBrand.Text.Trim().Length == 0) return;
            Brand brand = new Brand()
            {
                BrandName = tbBrand.Text.Trim()
            };
            phoneContext.Brand.Add(brand);
            phoneContext.SaveChanges();
            PopulateBrandList();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbModel.Text.Trim().Length == 0) return;
            Phone phone = new Phone() { 
                Model = tbModel.Text.Trim(),
                BrandId = Convert.ToInt32(((Brand)cbBrand.SelectedItem).Id.ToString()),
                Price = Convert.ToInt32(tbPrice.Text.Trim()),
                Description = tbDescription.Text.Trim(),
                Picture = tbImage.Text.Trim(),
                Count = 1
            };
            phoneContext.Phone.Add(phone);
            phoneContext.SaveChanges();
            PopulatePhoneList();
        }
    }
}
