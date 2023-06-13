namespace LibraryApp
{
    partial class AdminPanel
    {
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUsername;

        private void InitializeComponent()
        {
            // Diğer bileşenlerin tanımlamaları

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(100, 50);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 0;

            // btnDeleteUser
            this.btnDeleteUser.Location = new System.Drawing.Point(150, 100);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteUser.TabIndex = 1;
            this.btnDeleteUser.Text = "Kullanıcı Sil";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);

            // btnLogout
            this.btnLogout.Location = new System.Drawing.Point(340, 300);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Çıkış";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Kullanıcı Adı:";

            // Form özellikleri ve düzenlemeleri
        }
    }
}
