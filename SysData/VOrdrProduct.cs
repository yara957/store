//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StorSystem.SysData
{
    using System;
    using System.Collections.Generic;
    
    public partial class VOrdrProduct
    {
        public int prod_id { get; set; }
        public string prod_aname { get; set; }
        public string prod_ename { get; set; }
        public string prod_desc { get; set; }
        public int prod_status { get; set; }
        public string type_name { get; set; }
        public string catgry_name { get; set; }
        public int ordr_id { get; set; }
        public Nullable<System.DateTime> ordr_dt { get; set; }
        public Nullable<int> ordr_usr { get; set; }
        public string ordr_dsc { get; set; }
        public int ordr_type { get; set; }
        public int ordr_status { get; set; }
        public string str_name { get; set; }
        public int rec_ser { get; set; }
        public int prod_qt { get; set; }
        public decimal prod_price { get; set; }
        public Nullable<System.DateTime> prod_exp_dt { get; set; }
        public Nullable<System.DateTime> prod_im_dt { get; set; }
        public string ordr_stat_name { get; set; }
    }
}
