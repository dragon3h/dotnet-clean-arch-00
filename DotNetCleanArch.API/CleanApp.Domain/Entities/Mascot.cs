using System;

namespace CleanApp.Domain.Entities
{
    public class Mascot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int MakeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public Make Make { get; set; }

    }
}
