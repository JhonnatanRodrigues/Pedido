using Pedido.Dominio.Categorias.Produtos;
using Pedido.Repositorio.Contexto;
using Pedido.Repositorio.Repositorios.Base;

namespace Pedido.Repositorio.Repositorios
{
    public class RepProduto : RepBase<Produto>, IRepProduto
    {
        public RepProduto(ContextoBanco contextoBanco)
        {
            _Db = contextoBanco;
            Ent = contextoBanco.Produtos;
        }
    }
}
