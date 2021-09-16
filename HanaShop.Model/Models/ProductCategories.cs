using HanaShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanaShop.Model.Models
{
    [Table("ProductCategoriess")]
   public abstract class ProductCategories: tables
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOder { set; get; }
        [MaxLength(256)]
        public string Images { set; get; }
        public bool? HomeFlag { set; get; }
        public virtual IEnumerable<Product> Products { set; get; }
    }
}
