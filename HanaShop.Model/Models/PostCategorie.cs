using HanaShop.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HanaShop.Model.Models
{
    [Table("PostCategories")]
    public abstract class PostCategorie : tablepost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }


        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        public string Alias { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOder { set; get; }

        [MaxLength(256)]
        public string Images { set; get; }

        public bool? HomeFlag { set; get; }
        public virtual IEnumerable<Post> Posts { set; get; }
    }
}