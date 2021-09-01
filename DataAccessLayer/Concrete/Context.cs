using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<UserData> UserDatas { get; set; }
        public DbSet<Periyod> Periyods { get; set; }
        public DbSet<Traning> Tranings { get; set; }

        public DbSet<Traningİnfo> Traningİnfos  { get; set; }

        public DbSet<TraningType> TraningTypes { get; set; }
    }
}
