using System;

namespace Library.Models {
    public class Account {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Account(int Id, string username, string password) {
            this.Id = Id;
            this.UserName = username;
            this.Password = password;
        }
    }
}