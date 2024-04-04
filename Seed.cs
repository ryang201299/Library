using System;
using Library.Models;
using System.Data.SqlClient;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Library {
    public class Seed {
        private readonly string ConnectionString = "Server=RYANPC\\SQLEXPRESS01;Database=library;Integrated Security=True";

        public void EnsureSeedData() {
            CreateDatabaseIfNotExists();

            if (!CheckIfAccountsExist()) {
                SeedAccounts();
            }

            if (!CheckIfBooksExist()) {
                SeedBooks();
            }
        }

        private void CreateDatabaseIfNotExists() {
            using (var connection = new SqlConnection(ConnectionString)) {
                connection.Open();

                var command = new SqlCommand("SELECT COUNT(*) FROM sys.databases WHERE name = 'Library'", connection);
                var databaseExists = (int)command.ExecuteScalar() > 0;

                if (!databaseExists) {
                    command.CommandText = "CREATE DATABASE Library";
                    command.ExecuteNonQuery();
                }
            }
        }

        private bool CheckIfAccountsExist() {
            using (var connection = new SqlConnection(ConnectionString)) {
                connection.Open();

                var command = new SqlCommand("SELECT COUNT(*) FROM Account", connection);

                Console.WriteLine("Result from account check: ", (int)command.ExecuteScalar() > 0);
                return (int)command.ExecuteScalar() > 0;
            }
        }

        private void SeedAccounts() {
            var accounts = new List<Account> {
                new Account(1, "user1", "pass1"),
                new Account(2, "user2", "pass2")
            };

            using (var connection = new SqlConnection(ConnectionString)) {
                connection.Open();

                var enableIdentityInsertCommand = new SqlCommand("SET IDENTITY_INSERT Account ON", connection);
                enableIdentityInsertCommand.ExecuteNonQuery();

                foreach(var account in accounts) {
                    var command = new SqlCommand("INSERT INTO Account (Id, Username, Password) VALUES (@Id, @Username, @Password)", connection);
                    command.Parameters.AddWithValue("@Id", account.Id);
                    command.Parameters.AddWithValue("@Username", account.Username);
                    command.Parameters.AddWithValue("@Password", account.Password);
                    command.ExecuteNonQuery();
                } 
            }
        }

        private bool CheckIfBooksExist() {
            using (var connection = new SqlConnection(ConnectionString)) {
                connection.Open();

                var command = new SqlCommand("SELECT COUNT(*) FROM Books", connection);
                return (int)command.ExecuteScalar() > 0;
            }
        }

        private void SeedBooks() {
            var books = new List<Book> {
                new Book(1, DateTime.Today, "book1", "author1"),
                new Book(2, DateTime.Today, "book2", "author2")
            };

            foreach (Book book in books) {
                Console.WriteLine("New book insertion ---------------------------");
                Console.WriteLine($"Id: {book.Id}, Year: {book.Year.ToString()}, Name: {book.Name}, sDesc: {book.ShortDescription}, lDesc: {book.LongDescription}, image: {book.Image}, imgL: {book.ImageLocation}, author: {book.Author}, CheckedOut: {book.CheckedOut}, checkedOutBy: {book.CheckedOutById}");
            }

            using (var connection = new SqlConnection(ConnectionString)) {
                connection.Open();

                var enableIdentityInsertCommand = new SqlCommand("SET IDENTITY_INSERT Books ON", connection);
                enableIdentityInsertCommand.ExecuteNonQuery();

                foreach(var book in books) {
                    var command = new SqlCommand("INSERT INTO Books (Id, Year, Name, Author, CheckedOut) VALUES (@Id, @Year, @Name, @Author, @CheckedOut)", connection);
                    command.Parameters.AddWithValue("@Id", book.Id);
                    command.Parameters.AddWithValue("@Year", book.Year);
                    command.Parameters.AddWithValue("@Name", book.Name);
                    command.Parameters.AddWithValue("@Author", book.Author);
                    command.Parameters.AddWithValue("@CheckedOut", book.CheckedOut);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
