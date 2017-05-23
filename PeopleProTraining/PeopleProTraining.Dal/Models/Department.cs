using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Script.Serialization;

namespace PeopleProTraining.Dal.Models
{
    [MetadataType(typeof(DepartmentMetaData))]
    public partial class Department
    {
    }
    public class DepartmentMetaData
    {
        [Required]
        public string Name;
    }
}