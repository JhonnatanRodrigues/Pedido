using Microsoft.EntityFrameworkCore;
using Pedido.Dominio.Adicionais;
using Pedido.Repositorio.Contexto;
using Pedido.Repositorio.Repositorios.Base;

namespace Pedido.Repositorio.Repositorios
{
    public class RepAdicional : RepBase<Adicional>, IRepAdicional
    {
        public RepAdicional(ContextoBanco db)
        {
            _Db = db;
        }

        public override DbSet<Adicional> Entidade()
        {
            return _Db.Adicionais;
        }
    }
}
