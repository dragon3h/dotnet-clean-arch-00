using System;
using System.Collections;
using System.Collections.Generic;

namespace CleanApp.Domain.Entities
{
    public class Address
    {
        public Address()
        {
            Clients = new HashSet<Client>();
        }

        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string ProvinceState { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public ICollection<Client> Clients { get; private set; }
    }
}
