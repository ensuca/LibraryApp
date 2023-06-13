namespace LibraryApp
{
    partial class BookPanel
    {
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Button btnLogout;

        private void InitializeComponent()
        {
            // Diğer bileşenlerin tanımlamaları

            // btnBorrow
            this.btnBorrow.Location = new System.Drawing.Point(340, 200);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(100, 30);
            this.btnBorrow.TabIndex = 6;
            this.btnBorrow.Text = "Ödünç Al";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);

            // btnReturn
            this.btnReturn.Location = new System.Drawing.Point(340, 250);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 30);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "İade Et";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);

            // dgvBooks
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(20, 20);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(420, 150);
            this.dgvBooks.TabIndex = 0;

            // txtBookId
            this.txtBookId.Location = new System.Drawing.Point(100, 250);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(200, 20);
            this.txtBookId.TabIndex = 4;

            // txtUserId
            this.txtUserId.Location = new System.Drawing.Point(100, 300);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(200, 20);
            this.txtUserId.TabIndex = 5;

            // lblBookId
            this.lblBookId.AutoSize = true;
            this.lblBookId.Location = new System.Drawing.Point(20, 250);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(58, 13);
            this.lblBookId.TabIndex = 2;
            this.lblBookId.Text = "Kitap ID:";

            // lblUserId
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(20, 300);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(54, 13);
            this.lblUserId.TabIndex = 3;
            this.lblUserId.Text = "Kullanıcı ID:";

            // btnLogout
            this.btnLogout.Location = new System.Drawing.Point(340, 300);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Çıkış";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // Form özellikleri ve düzenlemeleri
        }
    }
}