using System;

namespace CleanApp.Domain.Entities
{
    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int AddressId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
