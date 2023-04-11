using Microsoft.EntityFrameworkCore;
using Pedido.Dominio.Cardapios.CardapioCategorias;
using Pedido.Repositorio.Contexto;
using System.Linq.Expressions;

namespace Pedido.Repositorio.Repositorios
{
    public class RepCardapioCategoria : IRepCardapioCategoria
    {
        public readonly ContextoBanco _Db;

        public RepCardapioCategoria(ContextoBanco db)
        {
            _Db = db;
        }

        public async Task Inserir(CardapioCategoria cardapioCategoria)
        {
            try
            {
                await _Db.CardapioCategoria.AddAsync(cardapioCategoria);
                _Db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public List<CardapioCategoria>? Listar()
        {
            return _Db.CardapioCategoria
                .Include("Categoria")
                .ToList();
        }
        public IQueryable<CardapioCategoria>? Where(Expression<Func<CardapioCategoria, bool>> func)
        {
            return _Db.CardapioCategoria.Where(func).Include("Categoria");
        }
        public void SaveChanges()
        {
            _Db.SaveChanges();
        }
    }
}
