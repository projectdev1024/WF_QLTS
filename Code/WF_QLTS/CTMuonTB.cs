//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WF_QLTS
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTMuonTB
    {
        public int IDCTMuon { get; set; }
        public int IDMuonTB { get; set; }
        public int IDThietBi { get; set; }
        public string Note { get; set; }
        public Nullable<int> Total { get; set; }
        public Nullable<int> Bad { get; set; }
    
        public virtual MuonTB MuonTB { get; set; }
        public virtual ThietBi ThietBi { get; set; }
    }
}
