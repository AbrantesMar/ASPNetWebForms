using System.ComponentModel.DataAnnotations;

namespace ASPNetWebForms.Model
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string Name { get; set; }
        [Required, StringLength(1000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}