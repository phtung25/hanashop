using System;
using System.ComponentModel.DataAnnotations;

namespace HanaShop.Model.Abstract
{
    public abstract class tables : Itable
    {
        public DateTime? CreatedDate { set; get; }
        [MaxLength(256)]
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        [MaxLength(256)]
        public string UpdatedBy { set; get; }

        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
    }
}