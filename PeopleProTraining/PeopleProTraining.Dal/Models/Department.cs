using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PeopleProTraining.Dal.Models
{
    [MetadataType(typeof(DepartmentMetaData))]
    public class Department
    {
        public int DepartmentId { get; set; }
        
        public string Name { get; set; }

        public virtual ICollection<Building> Buildings { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
    public class DepartmentMetaData
    {
        public int DepartmentId;

        [Required]
        public string Name;
    }
}