using Pedido.Dominio.Categorias.Itens;
using Pedido.Repositorio.Contexto;
using Pedido.Repositorio.Repositorios.Base;

namespace Pedido.Repositorio.Repositorios
{
    public class RepItem : RepBase<Item>, IRepItem
    {
        public RepItem(ContextoBanco contextoBanco)
        {
            _Db = contextoBanco;
            Ent = contextoBanco.Items;
        }
    }
}
