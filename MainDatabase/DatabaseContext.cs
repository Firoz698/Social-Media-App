using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDatabase
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<UserInfo> userInfos { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<ProfileImageClass> ProfileImage { get; set; }
        public DbSet<FileTabel> FileTabel { get; set; }


    }
}
