using System;
using System.Collections.Generic;
using System.Text;

namespace StarsFighters.Data.Models
{
    public class UsersAccounts
    {
        public int UserId { get; set; }
        public User User { get; set; }


        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
