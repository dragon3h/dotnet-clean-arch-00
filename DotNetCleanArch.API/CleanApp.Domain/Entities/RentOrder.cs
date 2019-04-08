using System;
using System.Collections.Generic;

namespace CleanApp.Domain.Entities
{
    public class RentOrder
    {
        public RentOrder()
        {
            RentOrderDetails = new HashSet<RentOrderDetails>();
        }
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal ShippingPrice { get; set; }
        public DateTime PaymentDate { get; set; }
        public int ClientId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public ICollection<RentOrderDetails> RentOrderDetails { get; private set; }
    }
}
