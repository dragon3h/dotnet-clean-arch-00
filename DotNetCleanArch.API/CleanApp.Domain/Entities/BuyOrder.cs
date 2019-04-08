using System;
using System.Collections.Generic;

namespace CleanApp.Domain.Entities
{
    public class BuyOrder
    {
        public BuyOrder()
        {
            BuyOrderDetails = new HashSet<BuyOrderDetails>();
        }

        public int Id { get; set; }
        public decimal ShippingPrice { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public ICollection<BuyOrderDetails> BuyOrderDetails { get; private set; }
    }
}
