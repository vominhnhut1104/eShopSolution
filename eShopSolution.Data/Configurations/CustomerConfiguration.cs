using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).HasMaxLength(50).IsRequired();

            builder.Property(x => x.LastName).HasMaxLength(50).IsRequired();

            builder.Property(x => x.Email).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Phonenumber).HasMaxLength(200).IsRequired();

            

        }
    }
}
