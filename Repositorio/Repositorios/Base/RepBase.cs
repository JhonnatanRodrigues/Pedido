using Microsoft.EntityFrameworkCore;
using Pedido.Repositorio.Contexto;
using System.Linq.Expressions;

namespace Pedido.Repositorio.Repositorios.Base
{
    public class RepBase<TEnt>
        where TEnt : class
    {
        public ContextoBanco _Db;
        public DbSet<TEnt> Ent;

        public async Task Inserir(TEnt ent)
        {
            try
            {
                await Ent.AddAsync(ent);
                _Db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public DbSet<TEnt> Listar()
        {
            return Ent;
        }
        public void SaveChanges()
        {
            _Db.SaveChanges();
        }
    }
}
