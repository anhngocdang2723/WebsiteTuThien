using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebsiteTuThien.Models;

namespace WebsiteTuThien.Data
{
    public class WebsiteTuThienContext : DbContext
    {
        public WebsiteTuThienContext (DbContextOptions<WebsiteTuThienContext> options)
            : base(options)
        {
        }

        public DbSet<WebsiteTuThien.Models.Kind> Kind { get; set; } = default!;

        public DbSet<WebsiteTuThien.Models.Account>? Account { get; set; }

        public DbSet<WebsiteTuThien.Models.Blog>? Blog { get; set; }

        public DbSet<WebsiteTuThien.Models.Donation>? Donation { get; set; }

        public DbSet<WebsiteTuThien.Models.Request>? Request { get; set; }

        public DbSet<WebsiteTuThien.Models.School>? School { get; set; }

        public DbSet<WebsiteTuThien.Models.User>? User { get; set; }



    }
}
