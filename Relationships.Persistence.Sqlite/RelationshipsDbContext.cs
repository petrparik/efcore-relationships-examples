using Microsoft.EntityFrameworkCore;
using Relationships.Domain.ManyToMany;
using Relationships.Domain.OneToMany;
using Relationships.Domain.OneToManyStandalone;
using Relationships.Domain.OneToOne;
using Relationships.Domain.ManyToManyWithPayload;

namespace Relationships.Persistence.Sqlite
{
    public class RelationshipsDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PhoneExtension> PhoneExtensions { get; set; }
        public DbSet<Person> Persons  {get;set;}
        public DbSet<Position> Positions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=Relationships.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>()
                .HasMany(pers => pers.Positions)
                .WithMany(pos => pos.Persons)
                .UsingEntity<PersonPosition>(
                    pp => pp.HasOne<Position>().WithMany(),
                    pp => pp.HasOne<Person>().WithMany()
                );
        }
    }
}