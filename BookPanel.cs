using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class BookPanel : Form
    {
        private DatabaseManager dbManager; // Veritabanı yöneticisi nesnesi

        public BookPanel()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            LoadBooks();
        }

        private void LoadBooks()
        {
            // Kitapları veritabanından yükle ve DataGridView'e ekle
            DataTable books = dbManager.GetAllBooks();
            dgvBooks.DataSource = books;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            string bookId = txtBookId.Text;
            string userId = txtUserId.Text;

            // Kitap ödünç alma işlemini gerçekleştir
            if (dbManager.BorrowBook(bookId, userId))
            {
                MessageBox.Show("Kitap ödünç alındı!");
                txtBookId.Text = "";
                txtUserId.Text = "";
                LoadBooks();
            }
            else
            {
                MessageBox.Show("Kitap ödünç alınamadı!");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string bookId = txtBookId.Text;

            // Kitap iade işlemini gerçekleştir
            if (dbManager.ReturnBook(bookId))
            {
                MessageBox.Show("Kitap iade edildi!");
                txtBookId.Text = "";
                LoadBooks();
            }
            else
            {
                MessageBox.Show("Kitap iade edilemedi!");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Çıkış yap ve giriş ekranını göster
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }
    }
}
