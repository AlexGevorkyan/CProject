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
        }

        private void DgvCatalog_RowHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedPhoneId = Convert.ToInt32(dgvCatalog.Rows[e.RowIndex].Cells["Id"].Value);
            // Cells["Id"] дозволяє звернутися до конкретної комірки, яка має назву "Id".
            //MessageBox.Show(selectedPhoneId.ToString());
            Info info = new Info(selectedPhoneId);
            info.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void dgvCatalog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
