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
            Ent = db.CardapioCategorias;
        }
    }
}
