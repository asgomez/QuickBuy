﻿namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (Id == 0)
                AdicionarCritica("Não foi identificado qual a referência do produto");

            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Produto não informado");
        }
    }
}
