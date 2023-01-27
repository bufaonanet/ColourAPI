using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColourAPI.Models
{
    public class ColourContext : DbContext
    {
        public ColourContext(DbContextOptions<ColourContext> options) 
            : base(options)        {        }

        public DbSet<Colour> ColoursItems { get; set; }
    }
}
