using System;
using System.Data;
using System.Data.SQLite;

namespace LibraryApp
{
    public class DatabaseManager
    {
        private SQLiteConnection connection;
        private SQLiteCommand command;

        public DatabaseManager()
        {
            connection = new SQLiteConnection("Data Source=veritabani.db;Version=3;");
            command = new SQLiteCommand(connection);
        }

        public bool ValidateUser(string username, string password, bool isAdmin)
        {
            connection.Open();
            command.Parameters.Clear();

            // Yönetici girişi ise admin tablosunu kontrol et
            if (isAdmin)
            {
                command.CommandText = "SELECT COUNT(*) FROM Admin WHERE Username = @username AND Password = @password";
            }
            else // Kullanıcı girişi ise users tablosunu kontrol et
            {
                command.CommandText = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
            }

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            return count > 0;
        }

        public bool DeleteUser(string username)
        {
            connection.Open();
            command.CommandText = "DELETE FROM Users WHERE Username = @username";
            command.Parameters.AddWithValue("@username", username);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }

        public DataTable GetAllBooks()
        {
            DataTable booksTable = new DataTable();
            connection.Open();
            command.CommandText = "SELECT * FROM Books";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(booksTable);
            connection.Close();

            return booksTable;
        }

        public bool BorrowBook(string bookId, string userId)
        {
            connection.Open();
            command.CommandText = "UPDATE Books SET IsBorrowed = 1, BorrowerId = @userId WHERE BookId = @bookId";
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@bookId", bookId);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }

        public bool ReturnBook(string bookId)
        {
            connection.Open();
            command.CommandText = "UPDATE Books SET IsBorrowed = 0, BorrowerId = NULL WHERE BookId = @bookId";
            command.Parameters.AddWithValue("@bookId", bookId);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }
    }
}