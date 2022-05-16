using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Menu.Models
{
    public class Menu1DdInstalizer : CreateDatabaseIfNotExists<Menu1Context>
    {
        protected override void Seed(Menu1Context db)
        {
            base.Seed(db);
        }
    }
}