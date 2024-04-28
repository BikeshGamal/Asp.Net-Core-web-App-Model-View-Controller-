using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvc_crud.Models;

namespace mvc_crud.Data
{
    public class mvc_crudContext : DbContext
    {
        public mvc_crudContext (DbContextOptions<mvc_crudContext> options)
            : base(options)
        {
        }

        public DbSet<mvc_crud.Models.student> student { get; set; } = default!;
    }
}
