using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Web_API.Models
{
    public class Model : DbContext
    {
        public Model(DbContextOptions<Model> options)
            : base(options)
        { }

        public DbSet<Notes> Notes { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Category> Category { get; set; }
    }

    public class Notes
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string CreatedOn { get; set; }
        public string CategoryId { get; set; }
        public string IsDeleted { get; set; }
        public int UserID { get; set; }
    }

    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string CreatedOn { get; set; }
    }

    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}

