using System;
using System.Collections.Generic;

namespace CleanApp.Domain.Entities
{
    public class Mascot
    {
        public Mascot()
        {
            BuyOrderDetails = new HashSet<BuyOrderDetails>();
            RentOrderDetails = new HashSet<RentOrderDetails>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int MakeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public Make Make { get; set; }
        public ICollection<BuyOrderDetails> BuyOrderDetails { get; set; }
        public ICollection<RentOrderDetails> RentOrderDetails { get; set; }

    }
}
