using Pedido.Dominio.Carrinhos.CarrinhoProdutos;
using Pedido.Repositorio.Contexto;
using Pedido.Repositorio.Repositorios.Base;

namespace Pedido.Repositorio.Repositorios
{
    public class RepCarrinhoProduto : RepBase<CarrinhoProduto>, IRepCarrinhoProduto
    {
        public RepCarrinhoProduto(ContextoBanco db)
        {
            _Db = db;
            Ent = db.CarrinhoProdutos;
        }
    }
}
