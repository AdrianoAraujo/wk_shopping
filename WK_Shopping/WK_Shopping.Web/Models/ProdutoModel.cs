namespace WK_Shopping.Web.Models
{
    public class ProdutoModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string CategoriaNome { get; set; }
        public string ImagemURL { get; set; }

        public string SubstringNome()
        {
            if (Nome.Length < 24) return Nome;
            return $"{ Nome.Substring(0, 21) } ...";
        }

        public string SubstringDescricao()
        {
            if (Descricao.Length < 355) return Descricao;
            return $"{ Descricao.Substring(0, 352) } ...";
        }
    }
}
