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
    
    public partial class tblTransaction
    {
        public tblTransaction()
        {
            this.tblTransactionItem = new HashSet<tblTransactionItem>();
        }
    
        public int transactionId { get; set; }
        public Nullable<System.DateTime> transactionDate { get; set; }
    
        public virtual ICollection<tblTransactionItem> tblTransactionItem { get; set; }
    }
}
