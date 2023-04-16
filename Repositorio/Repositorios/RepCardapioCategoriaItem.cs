using Pedido.Dominio.Cardapios.CardapioCategorias.CardapioCategoriaItens;
using Pedido.Repositorio.Contexto;
using Pedido.Repositorio.Repositorios.Base;

namespace Pedido.Repositorio.Repositorios
{
    public class RepCardapioCategoriaItem : RepBase<CardapioCategoriaItem>, IRepCardapioCategoriaItem
    {
        public RepCardapioCategoriaItem(ContextoBanco contextoBanco)
        {
            _Db = contextoBanco;
            Ent = contextoBanco.CardapioCategoriaItems;
        }
    }
}
