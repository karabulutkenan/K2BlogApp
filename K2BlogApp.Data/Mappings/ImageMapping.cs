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
    public class ImageMapping : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("C9ED2A27-292D-489E-A726-9BC75ABD0BAC"),
                FileName = "images/testimage",
                FileType = "jpg",
                CreatedBy = "Keno",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            }
                );
        }

    }
}
