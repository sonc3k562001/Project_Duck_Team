using System.Collections.Generic;
using System.Linq;


namespace SecurityInASPNETCore.Models
{
    public class AccountModel
    {
        private List<Account> accounts;

        public AccountModel()
        {
            accounts = new List<Account>();

            accounts.Add(new Account()
            {
                Username = "acc1",
                Password = "123",
                Roles = new string[] {"superadmin","admin","employee"}
            });
            accounts.Add(new Account()
            {
                Username = "acc2",
                Password = "123",
                Roles = new string[] {"admin", "employee" }
            });
            accounts.Add(new Account()
            {
                Username = "acc3",
                Password = "123",
                Roles = new string[] {"employee"}
            });
        }

        public Account find(string username)
        {
            return accounts.SingleOrDefault(a => a.Username.Equals(username));
        }

        public Account login(string username , string password)
        {
            return accounts.SingleOrDefault(a => a.Username.Equals(username) && a.Password.Equals(password));
        }
    }
}
