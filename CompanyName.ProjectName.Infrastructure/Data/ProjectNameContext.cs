using CompanyName.ProjectName.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Infrastructure.Data
{
    public class ProjectNameContext : DbContext
    {
        public ProjectNameContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<TestParent> TestParents { get; set; }
        public DbSet<TestChild> TestChilds { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TestParent>(ConfigureProduct);
            builder.Entity<TestChild>(ConfigureCategory);
        }

        private void ConfigureProduct(EntityTypeBuilder<TestParent> builder)
        {
            builder.ToTable("TestParent");

            builder.HasKey(ci => ci.Id);

            builder.Property(cb => cb.Name)
                .IsRequired()
                .HasMaxLength(100);
        }

        private void ConfigureCategory(EntityTypeBuilder<TestChild> builder)
        {
            builder.ToTable("TestChild");

            builder.HasKey(ci => ci.Id);

            builder.Property(cb => cb.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
