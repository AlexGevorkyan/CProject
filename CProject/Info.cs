using CProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CProject
{
    public partial class Info : Form
    {
        List<Phone> phones;
        List<Brand> brands;
        PhoneContext phoneContext;
        string imageUrl;
        public Info(int Id)
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //MessageBox.Show(Id.ToString());
            phoneContext = new PhoneContext();
            imageUrl = phoneContext.Phone
                .Where(p => p.Id == Id)
                .Select(p => p.Picture) // Отримуємо значення колонки Picture
                .FirstOrDefault(); // Беремо перше значення або null
        }

        private async void Info_Load(object sender, EventArgs e)
        {

        }

        private async void Info_Load_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(imageUrl))
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        // Завантажуємо зображення з URL
                        var response = await client.GetAsync(imageUrl);
                        response.EnsureSuccessStatusCode(); // Перевіряємо, чи успішний запит

                        // Отримуємо потік байтів
                        using (Stream imageStream = await response.Content.ReadAsStreamAsync())
                        {
                            pictureBox1.Image = System.Drawing.Image.FromStream(imageStream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не вдалося завантажити зображення: {ex.Message}");
                }
                pictureBox1.Load(imageUrl);
            }
            else
            {
                MessageBox.Show("URL зображення не знайдено.");
            }
        }
    }
}

