using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Tq.Intranet.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int FieldExperience { get; set; }

        public string Details { get; set; }

    }
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string UserName { get; set; }
        [Required]
        public int Password { get; set; }
    }
}