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