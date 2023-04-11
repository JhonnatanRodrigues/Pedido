using System.Linq.Expressions;

namespace Pedido.Dominio.Cardapios.CardapioCategorias
{
    public interface IRepCardapioCategoria
    {
        Task Inserir(CardapioCategoria cardapioCategoria);
        List<CardapioCategoria>? Listar();
        IQueryable<CardapioCategoria>? Where(Expression<Func<CardapioCategoria, bool>> func);
        void SaveChanges();
    }
}
