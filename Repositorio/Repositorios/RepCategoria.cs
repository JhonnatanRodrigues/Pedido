using Microsoft.EntityFrameworkCore;
using Pedido.Dominio.Categorias;
using Pedido.Repositorio.Contexto;
using Pedido.Repositorio.Repositorios.Base;

namespace Pedido.Repositorio.Repositorios
{
    public class RepCategoria : RepBase<Categoria>, IRepCategoria
    {
        public RepCategoria(ContextoBanco contextoBanco)
        {
            _Db = contextoBanco;
        }

        public override DbSet<Categoria> Entidade()
        {
            return _Db.Categorias;
        }
    }
}
