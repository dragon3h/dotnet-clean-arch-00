﻿using System;

namespace CleanApp.Domain.Entities
{
    public class RentOrder
    {
        public int Id { get; set; }
        public int MascotId { get; set; }
        public decimal Price { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal Deposit { get; set; }
        public decimal ShippingPrice { get; set; }
        public DateTime PaymentDate { get; set; }
        public int ClientId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}