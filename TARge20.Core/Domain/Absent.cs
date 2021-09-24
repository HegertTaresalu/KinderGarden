using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
   public class Absent
    {
        [Key]
        [ForeignKey("Id")]
        public Guid Id { get; set; }

        public string Reason { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid ChildId { get; set; }

    }
}
