using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Pedido.Dominio.Base
{
    public interface IRepBase<TEnt>
        where TEnt : class
    {
        Task Inserir(TEnt ent);
        DbSet<TEnt>? Listar();
        void SaveChanges();
    }
}
