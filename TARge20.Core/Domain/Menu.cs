using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Menu
    {

        [Key]
        [ForeignKey("Id")]
        public Guid Id { get; set; }

        public string Breakfast {get;set;}
        public string Lunch { get; set; }

    }
}
