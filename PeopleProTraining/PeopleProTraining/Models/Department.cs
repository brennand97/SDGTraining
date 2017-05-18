using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PeopleProTraining.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        public int? EmployeeId { get; set; }
        public virtual Employee Director { get; set; }

        public virtual ICollection<Building> Buildings { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}