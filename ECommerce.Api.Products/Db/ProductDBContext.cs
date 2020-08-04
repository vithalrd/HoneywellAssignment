﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Api.Products.Db
{
    public class ProductDBContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductDBContext(DbContextOptions options):base(options)
        {

        }
    }
}
