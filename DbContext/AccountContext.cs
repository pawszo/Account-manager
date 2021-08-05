using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountMaker.Models;
using AccountMaker.Models.Accounts;
using Microsoft.EntityFrameworkCore;

namespace AccountMaker.DbContext
{
    public class AccountContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> options) : base(options)
        {

        }

        public DbSet<InstagramAccount> InstagramAccounts { get; set; }
        public DbSet<OnetAccount> OnetAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OnetAccount>().HasData(
                new OnetAccount
                {
                    Id = 1,
                    Login = "accountmaster",
                    Email = "accountmaster@onet.pl",
                    Password = @"accountMajster1!"
                }
                );
            modelBuilder.Entity<InstagramAccount>().HasData(
                new InstagramAccount
                {
                    Id = 1,
                    Login = "jankowalski8080",
                    Email = "accountmaster@onet.pl",
                    Password = @"accountMajster1!",
                    Telephone = "731605099"
                }
                );


        }
    }
}
