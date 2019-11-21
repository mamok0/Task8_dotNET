using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task8_dotNET.Models;


namespace Task8_dotNET.Data
{
    public class GifTagContext : DbContext
    {
        public GifTagContext(DbContextOptions<GifTagContext> options)
            : base(options)
        {
        }

        public DbSet<GifTag> GifTags { get; set; }
    }
}
