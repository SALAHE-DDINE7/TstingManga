using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using TstingFrom.Data;
using TstingFrom.Model;

namespace TstingFrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadMangas();
        }

        // Load data into DataGridView
        private void LoadMangas()
        {
            try
            {
                using var context = new MangaDbContext();
                dataGridView.DataSource = context.Mangaka.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        // Add new Manga
        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nametextBox.Text) ||
                string.IsNullOrWhiteSpace(quantitytextBox.Text) ||
                string.IsNullOrWhiteSpace(pricetextBox.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(quantitytextBox.Text, out decimal quantity))
            {
                MessageBox.Show("Invalid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(pricetextBox.Text, out int price))
            {
                MessageBox.Show("Invalid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using var context = new MangaDbContext();
                var manga = new Manga
                {
                    Name = nametextBox.Text,
                    Quantity = quantity,
                    price = price
                };

                context.Mangaka.Add(manga);
                context.SaveChanges();
                MessageBox.Show("Manga added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMangas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding manga: " + ex.Message);
            }
        }

        // Update selected Manga
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idtextBox.Text) || !int.TryParse(idtextBox.Text, out int id))
            {
                MessageBox.Show("Please select or enter a valid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(quantitytextBox.Text, out decimal quantity))
            {
                MessageBox.Show("Invalid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(pricetextBox.Text, out int price))
            {
                MessageBox.Show("Invalid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using var context = new MangaDbContext();
                var manga = context.Mangaka.FirstOrDefault(m => m.Id == id);
                if (manga == null)
                {
                    MessageBox.Show("Manga not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                manga.Name = nametextBox.Text;
                manga.Quantity = quantity;
                manga.price = price;

                context.SaveChanges();
                MessageBox.Show("Manga updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMangas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating manga: " + ex.Message);
            }
        }

        // Delete selected Manga
        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idtextBox.Text) || !int.TryParse(idtextBox.Text, out int id))
            {
                MessageBox.Show("Please select a valid Manga to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var context = new MangaDbContext();
                var manga = context.Mangaka.FirstOrDefault(m => m.Id == id);
                if (manga == null)
                {
                    MessageBox.Show("Manga not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                context.Mangaka.Remove(manga);
                context.SaveChanges();
                MessageBox.Show("Manga deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMangas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting manga: " + ex.Message);
            }
        }

        // Search by name
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using var context = new MangaDbContext();
                var products = context.Mangaka
                    .Where(p => p.Name.Contains(searchtextBox.Text))
                    .ToList();
                dataGridView.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching manga: " + ex.Message);
            }
        }

        // Refresh DataGridView
        private void loadatabutton_Click(object sender, EventArgs e) => LoadMangas();

        // Fill textboxes on DataGridView click



        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // avoid header click crash

            idtextBox.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value?.ToString();
            nametextBox.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value?.ToString();
            pricetextBox.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value?.ToString();
            quantitytextBox.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value?.ToString();
        }
    }
}
