using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace shiki_server.Models
{
    public class ShikiContext : DbContext
    {
        public ShikiContext(DbContextOptions<ShikiContext> options) : base(options) {}

        public DbSet<Content> Contents { get; set; }
        public DbSet<File> Files { get; set; }
    }
}
