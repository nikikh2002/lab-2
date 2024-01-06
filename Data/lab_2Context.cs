using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab_2.Models;

namespace lab_2.Data
{
    public class lab_2Context : DbContext
    {
        public lab_2Context (DbContextOptions<lab_2Context> options)
            : base(options)
        {
        }

        public DbSet<lab_2.Models.Book> Book { get; set; } = default!;
    }
}
