using K2BlogApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2BlogApp.Data.Mappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("B573250C-2835-4AC0-B126-110C65748FFB"),
                Name = "Genel",
                CreatedBy = "Keno",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                

            });    
            
            
        }
    }
}
