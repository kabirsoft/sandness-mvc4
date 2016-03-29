using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using sandness_mvc4.Models;

namespace sandness_mvc4.Code
{
    public class Context : DbContext
    {
        public Context() : base("SolaBetong") { }
        public DbSet<User> User { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Orderval> Orderval { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<ProjectsEmail> ProjectsEmail { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Roll> Roll { get; set; }
        public DbSet<Felters> Felters { get; set; }
        public DbSet<Textcodes> Textcodes { get; set; }
        public DbSet<Infopages> Infopages { get; set; }
        public DbSet<Choices> Choices { get; set; }
        public DbSet<Dropdowns> Dropdowns { get; set; }
    }
}