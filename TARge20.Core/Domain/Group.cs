using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
     public class Group
    {
        [ForeignKey("Id")]
        [Key]
        public Guid Id { get; set; }
        public int FreeSpace { get; set; }
        public string GroupType { get; set; }
        public string GroupLeader { get; set; }
    }
}
