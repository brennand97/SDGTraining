using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PeopleProTraining.Models
{
    public class Employee2
    {
        public int EmployeeId { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime startDate { get; set; }

        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public int? BuildingId { get; set; }
        public virtual Building OfficeBuilding { get; set; }
    }
}