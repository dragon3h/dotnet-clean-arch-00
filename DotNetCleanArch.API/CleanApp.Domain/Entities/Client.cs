using System;
using System.Collections;
using System.Collections.Generic;

namespace CleanApp.Domain.Entities
{
    public class Client
    {
        public Client()
        {
            RentOrders = new HashSet<RentOrder>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Messenger { get; set; }
        public int AddressId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public Address Address { get; set; }
        public ICollection<RentOrder> RentOrders { get; set; }
    }
}
