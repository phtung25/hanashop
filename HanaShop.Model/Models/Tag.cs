using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HanaShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public int ID { set; get; }

        [MaxLength(50)]
        [Required]
        public string Name { set; get; }

        [MaxLength(50)]
        [Required]
        public string Type { set; get; }

        //public virtual IEnumerable<PostTag> PostTags { set; get; }
    }
}