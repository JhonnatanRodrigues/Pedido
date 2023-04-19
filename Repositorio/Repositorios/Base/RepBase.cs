using Microsoft.EntityFrameworkCore;
using Pedido.Repositorio.Contexto;
using System.Linq.Expressions;

namespace Pedido.Repositorio.Repositorios.Base
{
    public abstract class RepBase<TEnt>
        where TEnt : class
    {
        public abstract DbSet<TEnt> Entidade();

        public ContextoBanco _Db;

        public async Task Inserir(TEnt ent)
        {
            try
            {
                await Entidade().AddAsync(ent);
                _Db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public DbSet<TEnt> Listar()
        {
            return Entidade();
        }
        public void SaveChanges()
        {
            _Db.SaveChanges();
        }
    }
}
