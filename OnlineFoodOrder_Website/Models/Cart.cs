//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineFoodOrder_Website.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart
    {
        public int CartID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
