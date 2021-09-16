using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanaShop.Model.Abstract
{
    public abstract class tablepost: Itablepost
    {
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public bool Status { set; get; }
    }
}
