using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HanaShop.Model.Models
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        public string Content { set; get; }

        [Required]
        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }
        public bool Status { set; get; }
    }
}