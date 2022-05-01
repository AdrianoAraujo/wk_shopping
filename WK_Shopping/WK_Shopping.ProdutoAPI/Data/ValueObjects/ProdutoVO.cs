﻿namespace WK_Shopping.ProdutoAPI.Data.ValueObjects
{
    public class ProdutoVO
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string CategoriaNome { get; set; }
        public string ImagemURL { get; set; }
    }
}
