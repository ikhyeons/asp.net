using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace dotnetMVC.Data
{
    public class dotnetMVCContext : DbContext
    {
        public dotnetMVCContext (DbContextOptions<dotnetMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
