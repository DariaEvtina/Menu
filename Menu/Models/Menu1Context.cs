using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Menu.Models
{
    public class Menu1Context : DbContext
    {
        public DbSet<Menu1> Menus1 { get; set; }
    }
}