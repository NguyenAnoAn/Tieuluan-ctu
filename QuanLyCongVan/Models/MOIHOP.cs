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
    
    public partial class MOIHOP
    {
        public int ID { get; set; }
        public int NGUOINHAN { get; set; }
        public int KEHOACHHOP { get; set; }
        public short QUYETDINH { get; set; }
        public string LYDOQUYETDINH { get; set; }
        public Nullable<bool> DAQUYETDINH { get; set; }
        public Nullable<bool> COHIEULUC { get; set; }
    
        public virtual CANBO CANBO { get; set; }
        public virtual KEHOACHHOP KEHOACHHOP1 { get; set; }
        public virtual QUYETDINHCUANGUOINHAN QUYETDINHCUANGUOINHAN { get; set; }
    }
}
