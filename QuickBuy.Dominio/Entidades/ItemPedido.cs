namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido :Entidade
    {
        public int Id { get; set; }

        public int PedidoId { get; set; }

        public int Quantidade { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
