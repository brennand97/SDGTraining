using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PeopleProTraining.Models
{
    public class Building
    {
        public int BuildingId { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        public string Address { get; set; }
    }
}