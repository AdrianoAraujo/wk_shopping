using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WK_Shopping.ProdutoAPI.Model.Base;

namespace WK_Shopping.ProdutoAPI.Model
{
    [Table("produto")]
    public class Produto : BaseEntity
    {
        [Column("nome")]
        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

        [Column("preco")]
        [Required]
        [Range(1, 10000)]
        public decimal Preco { get; set; }

        [Column("descricao")]
        [StringLength(500)]
        public string Descricao { get; set; }

        [Column("categoria_nome")]
        [StringLength(50)]
        public int CategoriaNome { get; set; }

        [Column("imagem_url")]
        [StringLength(300)]
        public string ImagemURL { get; set; }
    }
}