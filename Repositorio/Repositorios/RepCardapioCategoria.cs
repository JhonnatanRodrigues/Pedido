using Microsoft.EntityFrameworkCore;
using Pedido.Dominio.Cardapios.CardapioCategorias;
using Pedido.Repositorio.Contexto;
using Pedido.Repositorio.Repositorios.Base;

namespace Pedido.Repositorio.Repositorios
{
    public class RepCardapioCategoria : RepBase<CardapioCategoria>, IRepCardapioCategoria
    {
        public RepCardapioCategoria(ContextoBanco db)
        {
            _Db = db;
        }

        public override DbSet<CardapioCategoria> Entidade()
        {
            return _Db.CardapioCategorias;
        }
    }
}
