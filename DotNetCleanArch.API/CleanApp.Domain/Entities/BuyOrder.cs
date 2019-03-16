using System;

namespace CleanApp.Domain.Entities
{
    public class BuyOrder
    {
        public int Id { get; set; }
        public int MascotId { get; set; }
        public int MakeId { get; set; }
        public decimal Price { get; set; }
        public decimal ShippingPrice { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
