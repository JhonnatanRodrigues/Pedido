using Microsoft.EntityFrameworkCore;
using Pedido.Dominio.Carrinhos.CarrinhoProdutos.CarrinhoProdutoAdicionais;
using Pedido.Repositorio.Contexto;
using Pedido.Repositorio.Repositorios.Base;

namespace Pedido.Repositorio.Repositorios
{
    public class RepCarrinhoProdutoAdicional : RepBase<CarrinhoProdutoAdicional>, IRepCarrinhoProdutoAdicional
    {
        public RepCarrinhoProdutoAdicional(ContextoBanco db)
        {
            _Db = db;
        }

        public override DbSet<CarrinhoProdutoAdicional> Entidade()
        {
            return _Db.CarrinhoProdutoAdicionais;
        }
    }
}
