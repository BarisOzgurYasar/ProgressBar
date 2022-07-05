using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using toolbar.Entities;

namespace toolbar.DataAcses.EntityFramewor
{
    public class MytimesContext : DbContext
    {
        public DbSet<MyTimes> MyTimes { get; set; }
    }
}
