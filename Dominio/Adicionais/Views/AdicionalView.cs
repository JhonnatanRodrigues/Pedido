namespace Pedido.Dominio.Adicionais.Views
{
    public class AdicionalView
    {
        public int CodigoAdicional { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public AdicionalView NovoView(Adicional adicional)
        {
            if (adicional == null)
                return new AdicionalView();

            return new AdicionalView
            {
                CodigoAdicional = adicional.Id,
                Nome = adicional.Nome,
                Descricao = adicional.Descricao
            };
        }
    }
}
