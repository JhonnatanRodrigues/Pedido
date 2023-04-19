using Microsoft.EntityFrameworkCore;
using Pedido.Dominio.Carrinhos;
using Pedido.Repositorio.Contexto;
using Pedido.Repositorio.Repositorios.Base;

namespace Pedido.Repositorio.Repositorios
{
    public class RepCarrinho : RepBase<Carrinho>, IRepCarrinho
    {
        public RepCarrinho(ContextoBanco db) 
        { 
            _Db = db;
        }

        public override DbSet<Carrinho> Entidade()
        {
            return _Db.Carrinhos;
        }
    }
}
