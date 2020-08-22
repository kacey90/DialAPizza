using System.ComponentModel.DataAnnotations;

namespace BlazingPizza
{
    public class Address
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public string Street { get; set; }

        [MaxLength(100)]
        public string Street2 { get; set; }

        [Required, MaxLength(50)]
        public string City { get; set; }

        [MaxLength(20)]
        public string State { get; set; }

        [Required, MaxLength(20)]
        public string PostalCode { get; set; }
    }
}
