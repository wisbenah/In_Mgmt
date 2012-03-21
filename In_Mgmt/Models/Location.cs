using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace In_Mgmt.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        [Required]
        public string LocationName { get; set; }
        [Required]
        public string LocationCode { get; set; }
        //foreign key
        public int ContainerID { get; set; }
        public virtual Container Container { get; set; }
       
    }
}