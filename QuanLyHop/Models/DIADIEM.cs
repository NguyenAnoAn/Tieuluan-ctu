//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyHop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DIADIEM
    {
        public DIADIEM()
        {
            this.KEHOACHHOPs = new HashSet<KEHOACHHOP>();
        }
    
        public int ID { get; set; }
        public string TENDIADIEM { get; set; }
        public string DIACHIDIADIEM { get; set; }
        public string MIEUTA { get; set; }
    
        public virtual ICollection<KEHOACHHOP> KEHOACHHOPs { get; set; }
    }
}
