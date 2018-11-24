using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASM_MVC_T1708M1.Models;

    public class MyDBContactContext : DbContext
    {
        public MyDBContactContext (DbContextOptions<MyDBContactContext> options)
            : base(options)
        {
        }

        public DbSet<ASM_MVC_T1708M1.Models.Product> Product { get; set; }

        public DbSet<ASM_MVC_T1708M1.Models.Category> Category { get; set; }
    }
