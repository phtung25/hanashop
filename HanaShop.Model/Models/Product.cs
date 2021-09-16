using HanaShop.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace HanaShop.Model.Models
{
    [Table("Products")]
    public class Product : tables
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
        [Required]
        public int CategoryID { set; get; }
        [MaxLength(256)]
        public string Images { set; get; }
        [Column(TypeName = "xml")]
        public XElement MoreImages { set; get;}
        [Required]
        public decimal Price { set; get; }
        public decimal? Promotion { set; get; }
        public int? Warranty { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
        [ForeignKey("CategoryID")]
        public virtual ProductCategories ProductCategories { set; get; }
    }
}