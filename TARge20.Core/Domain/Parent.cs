using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Parent
    {
        [ForeignKey("Id")]
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid IdentityNumber { get; set; }
        public string ContactAddress { get; set; }
        public int ContactNumber { get; set; }
        public string ContactEmail { get; set; }
    }
}
