using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Menu.Models
{
    public class Menu1
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "On vaja sisesta oma nime!!!")]
        public string Name { get; set; }
        public int Cost { get; set; }
    }
}