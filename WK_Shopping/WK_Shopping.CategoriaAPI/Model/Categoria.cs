using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WK_Shopping.CategoriaAPI.Model.Base;

namespace WK_Shopping.CategoriaAPI.Model
{
    [Table("categoria")]
    public class Categoria : BaseEntity
    {
        [Column("nome")]
        [Required]
        [StringLength(150)]
        public string Nome { get; set; }
    }
}
