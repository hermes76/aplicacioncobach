
namespace aplicacioncobach.common.models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Description { get; set; }

        public Decimal Price { get; set; }

        public bool IsAvaliable { get; set; }

        public DateTime PublisOn { get; set; }

    }
}
