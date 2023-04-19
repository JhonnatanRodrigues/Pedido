using Microsoft.EntityFrameworkCore;
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
        }

        public override DbSet<CarrinhoProduto> Entidade()
        {
            return _Db.CarrinhoProdutos;
        }
    }
}
