using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task19_12_2021.Models;

namespace Task19_12_2021.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<About> Abouts{ get; set; }
        public DbSet<Accordion> Accordions { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Message> Messages{ get; set; }
        public DbSet<Our_team> Our_Teams{ get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<Specialty> Specialties{ get; set; }
    }
}
