﻿using K2BlogApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2BlogApp.Entity.Entities
{
    public class Category : EntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection <Article> Articles { get; set; }
    }
}
