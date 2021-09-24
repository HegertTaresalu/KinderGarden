using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Child
    {
        [ForeignKey("Id")]
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid IdentityNumber { get; set; }
        public enum Gender {
            Male,
            Female,
            Unknown
        }
        public int Age { get; set; }
        public string StayingSince { get; set; }

        public List<Parent> Parent { get; set; }
        public List<Group> Group { get; set; }

    }
}
