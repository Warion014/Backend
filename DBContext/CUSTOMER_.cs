//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Backend.DBContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUSTOMER_
    {
        internal int id;

        public double CustomerID { get; set; }
        public string Company_Name { get; set; }
        public string Firstname_Lastname { get; set; }
        public string Email { get; set; }
        public Nullable<double> Address { get; set; }
        public string Phone { get; set; }
    }
}
