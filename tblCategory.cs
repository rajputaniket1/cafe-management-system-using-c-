//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPOS
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCategory
    {
        public tblCategory()
        {
            this.tblProduct = new HashSet<tblProduct>();
        }
    
        public int categoryId { get; set; }
        public string CategoryName { get; set; }
        public byte[] categoryImage { get; set; }
    
        public virtual ICollection<tblProduct> tblProduct { get; set; }
    }
}
