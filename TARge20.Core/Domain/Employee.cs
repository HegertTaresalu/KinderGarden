using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TARge20.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid IdentityNumber { get; set; }
        public string ContactAddress { get; set; }
        public int ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public int WorkedSince { get; set; }
        public int WorkedUntil { get; set; }
        public string LoadCapacity { get; set; }



        public List<Group> Group { get; set; }
        public List<Kitchen> Kitchen { get; set; }
        public List<JobTitle> Jobtitle { get; set; }
      

    }
}
