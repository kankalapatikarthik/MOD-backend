//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MOD_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SignupDtl
    {
        public int id { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public decimal contactNumber { get; set; }
        public string regCode { get; set; }
        public int role { get; set; }
        public string linkdinUrl { get; set; }
        public Nullable<int> yearOfExperience { get; set; }
        public bool active { get; set; }
        public Nullable<bool> confirmedSignUp { get; set; }
        public Nullable<System.DateTime> resetPasswordDate { get; set; }
        public Nullable<bool> resetPassword { get; set; }
        public string pictureUrl { get; set; }
        public string technology { get; set; }
    }
}
