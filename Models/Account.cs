using System;

namespace Library.Models {
    public class Account {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Account(int id, string username, string password) {
            this.Id = id;
            this.Username = username;
            this.Password = password;
        }
    }
}