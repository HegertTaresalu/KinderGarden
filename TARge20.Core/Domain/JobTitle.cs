using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class JobTitle
    {
        [ForeignKey("Id")]
        [Key]
        public Guid Id { get; set; }
        public string Occupation { get; set; }
        public string Division { get; set; }
    }
}
