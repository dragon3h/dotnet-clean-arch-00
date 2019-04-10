using System;

namespace CleanApp.Domain.Entities
{
    public class BuyOrderDetails
    {
        public int Id { get; set; }
        public int BuyOrderId { get; set; }
        public int MascotId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public BuyOrder BuyOrder { get; set; }
        public Mascot Mascot { get; set; }
    }
}
