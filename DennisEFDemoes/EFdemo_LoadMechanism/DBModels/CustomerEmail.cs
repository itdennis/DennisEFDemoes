//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFdemo_LoadMechanism.DBModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerEmail
    {
        public int CustomerEmailId { get; set; }
        public string CustomerId { get; set; }
        public string Email { get; set; }
        public int CustomerCustomerId { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
