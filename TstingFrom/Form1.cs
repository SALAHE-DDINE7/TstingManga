using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using TstingFrom.Data;
using TstingFrom.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace TstingFrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Kan-tأكدوا bli l-ID dkhl mzyan o machi khawi
            if (string.IsNullOrWhiteSpace(idtextBox.Text))
            {
                MessageBox.Show("Please select or enter an ID to update.");
                return;
            }

            try
            {
                using (var context = new MangaDbContext())
                {
                    // 2. Kan-qalbo 3la l-Manga f database b-ID dyalo
                    int id = int.Parse(idtextBox.Text);
                    var manga = context.Mangaka.FirstOrDefault(m => m.Id == id);

                    if (manga != null)
                    {
                        // 3. Kan-bdlo l-m3loumat l-kdima b-dakchi li f l-inputs
                        manga.Name = nametextBox.Text;
                        manga.Quantity = decimal.Parse(quantitytextBox.Text);
                        manga.price = int.Parse(pricetextBox.Text);

                        // 4. Kan-sajlo l-taghyirat
                        context.SaveChanges();

                        MessageBox.Show("Manga updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 5. Re-fresh l-GridView bach tban l-khidma
                        LoadMangas();
                    }
                    else
                    {
                        MessageBox.Show("Manga not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        //Load Data
        private void LoadMangas()
        {
            try
            {
                using (var context = new MangaDbContext())
                {
                    var mangas = context.Mangaka.ToList();
                    dataGridView.DataSource = mangas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void loadatabutton_Click(object sender, EventArgs e)
        {

            LoadMangas();

        }

        // Add Data to DataBase
        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nametextBox.Text) ||
                string.IsNullOrWhiteSpace(quantitytextBox.Text) ||
                string.IsNullOrWhiteSpace(pricetextBox.Text))
            {
                MessageBox.Show(
                    "There is an error",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            using (var context = new MangaDbContext())
            {
                var manga = new Manga
                {
                    Name = nametextBox.Text,
                    Quantity = int.Parse(quantitytextBox.Text),
                    price = int.Parse(pricetextBox.Text)
                };

                context.Mangaka.Add(manga);
                int ret = context.SaveChanges();
                if (ret == 0)
                {
                    MessageBox.Show("Error occured while adding product");
                    LoadMangas();
                }
            }

            LoadMangas();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idtextBox.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            nametextBox.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            pricetextBox.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            quantitytextBox.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            using (var context = new MangaDbContext())
            {
                var product = context.Mangaka.FirstOrDefault(p => p.Id == int.Parse(idtextBox.Text));
                if (product != null)
                {
                    context.Mangaka.Remove(product);
                    int ret = context.SaveChanges();
                    if (ret == 0)
                    {
                        MessageBox.Show("Error occured while modifing product");
                        loadatabutton.PerformClick();

                    }

                }
                LoadMangas();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new MangaDbContext())
            {
                var products = context.Mangaka.Where(p => p.Name.Contains(searchtextBox.Text)).ToList();
                dataGridView.DataSource = products;
            }
        }
    }
}
