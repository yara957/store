using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorSystem.dto
{
    class m_product
    {
        public int prod_id { get; set; }
        public string prod_aname { get; set; }
        public string prod_ename { get; set; }
        public Nullable<int> prod_type { get; set; }
        public Nullable<int> prod_catgry { get; set; }
        public string prod_desc { get; set; }
        public int prod_status { get; set; }
        public string prod_img { get; set; }
        public string prod_othrs { get; set; }
        public decimal prod_dflt_price { get; set; }
    }
}
