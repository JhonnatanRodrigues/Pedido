using Pedido.Dominio.Padrao;

namespace Pedido.Dominio.Carrinhos
{
    public class Carrinho : EntEmp
    {
        public EnumStatusCarrinho Status { get; set; }
        public decimal ValorTotal { get; set; }
        public int CodigoEmpTablet { get; set; }
    }

    public enum EnumStatusCarrinho
    {
        Pendente = 0,
        Finalizado = 1,
        Cancelado = 2
    }
}
