//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produto
    {
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public int ProdutoCategoriaId { get; set; }
        public System.DateTime DataCadastro { get; set; }

        public virtual ProdutoCategoria ProdutoCategoria { get; set; }
    }
}
