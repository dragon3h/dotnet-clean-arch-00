using System;

namespace CleanApp.Domain.Entities
{
    public class RentOrderDetails
    {
        public int Id { get; set; }
        public int RentOrderId { get; set; }
        public int MascotId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Deposit { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public RentOrder RentOrder { get; set; }
        public Mascot Mascot { get; set; }
    }
}
