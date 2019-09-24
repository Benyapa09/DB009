using System;
using System.Collections.Generic;
using System.Text;
using DataBase2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataBase2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Book> Books { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
