using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAuto.Models
{
    public class DataContext:DbContext
    {
        public DataContext(): base ("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<WebAuto.Models.Car> Cars { get; set; }
    }
}