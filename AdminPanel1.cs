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
    public partial class AdminPanel : Form
    {
        private DatabaseManager dbManager; // Veritabanı yöneticisi nesnesi

        public AdminPanel()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;

            // Kullanıcı hesabını sil
            if (dbManager.DeleteUser(username))
            {
                MessageBox.Show("Kullanıcı hesabı silindi!");
                txtUsername.Text = "";
            }
            else
            {
                MessageBox.Show("Kullanıcı hesabı bulunamadı!");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Çıkış yap ve giriş ekranını göster
            Form1 loginForm = new Form1();
            loginForm.Show();
            Close();
        }
    }
}