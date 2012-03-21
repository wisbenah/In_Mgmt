using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;

namespace In_Mgmt.Models
{
    public class Container
    {
        
        public int ContainerID { get; set; }
        
        [Required(ErrorMessage = "Code is required")]
        public string ContainerCode { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Max Capacity is required")]
        public string Max_Capacity { get; set; }
        [Timestamp]
        public DateTime? DateCreated { get; set; }
        //[Required(ErrorMessage = "UOM is required")]
        //public string UnitOfM { get; set; }
        
        //Foriegn key
        [Required(ErrorMessage = "UOM is required")]
        public int UOMID { get; set; }
        public virtual UOM UOM { get; set; }
    }
    
}