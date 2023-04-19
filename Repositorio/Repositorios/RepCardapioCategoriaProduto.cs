using Microsoft.EntityFrameworkCore;
using Pedido.Dominio.Cardapios.CardapioCategorias.CardapioCategoriaProdutos;
using Pedido.Repositorio.Contexto;
using Pedido.Repositorio.Repositorios.Base;

namespace Pedido.Repositorio.Repositorios
{
    public class RepCardapioCategoriaProduto : RepBase<CardapioCategoriaProduto>, IRepCardapioCategoriaProdutos
    {
        public RepCardapioCategoriaProduto(ContextoBanco contextoBanco)
        {
            _Db = contextoBanco;
        }

        public override DbSet<CardapioCategoriaProduto> Entidade()
        {
            return _Db.CardapioCategoriaProdutos;
        }
    }
}
