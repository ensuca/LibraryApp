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
    public partial class Form1 : Form
    {
        private DatabaseManager dbManager; // Veritabanı yöneticisi nesnesi
        private bool isAdmin; // Yönetici girişi kontrolü

        public Form1()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            isAdmin = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Kullanıcı veya yönetici girişini kontrol et
            if (dbManager.ValidateUser(username, password, isAdmin))
            {
                // Giriş başarılı
                MessageBox.Show("Giriş başarılı!");

                // Yönetici girişi ise yönetici panelini aç
                if (isAdmin)
                {
                    OpenAdminPanel();
                }
                else // Kullanıcı girişi ise kitap panelini aç
                {
                    OpenBookPanel();
                }
            }
            else
            {
                // Giriş başarısız
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
        }

        private void OpenAdminPanel()
        {
            // Yönetici panelini aç
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            Hide();
        }

        private void OpenBookPanel()
        {
            // Kitap panelini aç
            BookPanel bookPanel = new BookPanel();
            bookPanel.Show();
            Hide();
        }

        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Yönetici girişi için link etkinleştirildiğinde işlemleri gerçekleştir
            isAdmin = true;
            lblUsername.Text = "Yönetici Adı:";
            btnLogin.Text = "Yönetici Girişi";
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}