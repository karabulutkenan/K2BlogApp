using K2BlogApp.Core.Entities;
using K2BlogApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2BlogApp.Entity.Entities
{
    public class Article : EntityBase
    {
        public string Title { get; set; }
        public string? Content { get; set; }
        public Guid CategoryId { get; set; }
        public int ViewCount { get; set; }
        public Guid ImageId { get; set; }
        public Image Image { get; set; }
        public Category Category { get; set; }

       

    }
   
}

