using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _19_EntityFramework
{
    public class E_TradeContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
