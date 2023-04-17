using Pedido.Dominio.Categorias.Produtos.ProdutoAdicionais;
using Pedido.Repositorio.Contexto;
using Pedido.Repositorio.Repositorios.Base;

namespace Pedido.Repositorio.Repositorios
{
    public class RepProdutoAdicional : RepBase<ProdutoAdicional>, IRepProdutoAdicional
    {
        public RepProdutoAdicional(ContextoBanco db)
        {
            _Db = db;
            Ent = db.ProdutoAdicionais;
        }
    }
}
