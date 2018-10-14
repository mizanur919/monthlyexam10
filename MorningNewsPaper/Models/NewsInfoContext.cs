using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorningNewsPaper.Models
{
    public class NewsInfoContext: DbContext
    {
        public NewsInfoContext(DbContextOptions<NewsInfoContext> option) : base(option)
        {

        }
        public DbSet<NewsInfo> NewsInfos { get; set; }
    }
}
