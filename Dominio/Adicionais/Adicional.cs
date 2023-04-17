using Pedido.Dominio.Padrao;

namespace Pedido.Dominio.Adicionais
{
    public class Adicional : EntEmp
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
