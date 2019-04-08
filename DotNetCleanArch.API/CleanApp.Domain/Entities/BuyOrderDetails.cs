namespace CleanApp.Domain.Entities
{
    public class BuyOrderDetails
    {
        public int Id { get; set; }
        public int BuyOrderId { get; set; }
        public int MascotId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }

        public BuyOrder BuyOrder { get; set; }
        public Mascot Mascot { get; set; }
    }
}
