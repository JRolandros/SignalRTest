using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SignalRSample.Models
{
    public class UserAccount
    {
        private int id;
        public int Id {
            get { return id; } 
            set { id = value; } 
        }

        private string nickName;

        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
            
    }


    public class UserDBContext : DbContext
    {
        public DbSet<UserAccount> userAccounts { get; set; }
    }
}