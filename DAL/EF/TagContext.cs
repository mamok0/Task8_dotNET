using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task8_dotNET.Models;


namespace Task8_dotNET.Data
{
    public class TagContext : DbContext
    {
        public TagContext(DbContextOptions<TagContext> options)
            : base(options)
        {
        }

        public DbSet<Tag> Tags { get; set; }
    }
}
