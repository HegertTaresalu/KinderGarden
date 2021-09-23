using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Queue
    {
        [ForeignKey("Id")]
        [Key]
        public Guid Id { get; set; }
        public int QueueLength { get; set; }
        public int QueuePriority { get; set; }

        public List<Child> Child { get; set; }
    }
}
