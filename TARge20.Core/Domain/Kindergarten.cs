using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Kindergarten
    {
        [ForeignKey("Id")]
        [Key]
        public Guid Id { get; set; }
        public int RegisterNumber { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Address { get; set; }
        public string ContactList { get; set; }
        public int ContactNumber { get; set; }
        public string ContactEmail { get; set; }

        public List<Absent> Absents { get; set; }
        public List<Queue> queues { get; set; }
        public List<Employee> Employee { get; set; }

    }
}
