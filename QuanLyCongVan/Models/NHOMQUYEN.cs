//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCongVan.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHOMQUYEN
    {
        public NHOMQUYEN()
        {
            this.NHOMCOQUYENs = new HashSet<NHOMCOQUYEN>();
            this.TAIKHOANDANGNHAPs = new HashSet<TAIKHOANDANGNHAP>();
        }
    
        public int ID { get; set; }
        public string TENNHOM { get; set; }
    
        public virtual ICollection<NHOMCOQUYEN> NHOMCOQUYENs { get; set; }
        public virtual ICollection<TAIKHOANDANGNHAP> TAIKHOANDANGNHAPs { get; set; }
    }
}
