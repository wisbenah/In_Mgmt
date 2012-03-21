using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace In_Mgmt.Models
{
    public class UOM_Type
    {
        public int UOM_TypeID { get; set; }
        public string UOM_Type_Name { get; set; }
        
        public virtual ICollection<UOM> UOMs { get; set; }

    }
}