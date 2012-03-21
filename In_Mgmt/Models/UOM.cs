using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace In_Mgmt.Models
{
    public class UOM
    {
        public int UOMID { get; set; }
        [Required(ErrorMessage="UOM Code is required")]
        public string UOM_Code { get; set; }
        [Required(ErrorMessage = "UOM Name is required")]
        public string UOM_Name { get; set; }
        [Required(ErrorMessage = "Factory is required")]
        public int Factor { get; set; }
        // Foreign key
        //[Required(ErrorMessage = "UOM Type is required")]
        //public string UOM_Type { get; set; }
        public int UOM_TypeID { get; set; }
        public virtual UOM_Type UOM_Type { get; set; }
                
        public virtual ICollection<Container> Containers { get; set; }

    }
}