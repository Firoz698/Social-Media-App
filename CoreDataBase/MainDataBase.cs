using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDataBase
{
    public class MainDataBase : DbContext
    {
        public MainDataBase(DbContextOptions<MainDataBase> options) : base(options) { }


        public DbSet<UserInfo> userInfos { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<FileTabel> FileTabel { get; set; }


    }
}
