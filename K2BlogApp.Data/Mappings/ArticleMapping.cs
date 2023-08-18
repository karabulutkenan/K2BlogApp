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
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {

            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Deneme Makalesi1",
                Content = "LoremIpsum Dolor Sitamet Kontent Yazılsın",
                ViewCount = 15,
                CategoryId = Guid.Parse("B573250C-2835-4AC0-B126-110C65748FFB"),
                ImageId = Guid.Parse("C9ED2A27-292D-489E-A726-9BC75ABD0BAC"),
                CreatedBy = "Keno",
                CreatedDate = DateTime.Now,
                IsDeleted = false,


            });

        }


    }
}
