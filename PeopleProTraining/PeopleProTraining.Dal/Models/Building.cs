using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PeopleProTraining.Dal.Models
{
    [MetadataType(typeof(BuildingMetaData))]
    public partial class Building
    {
        public int BuildingId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
    public class BuildingMetaData
    {
        public int BuildingId;

        [Required]
        public string Name;

        [Required]
        public string Address;
    }
}