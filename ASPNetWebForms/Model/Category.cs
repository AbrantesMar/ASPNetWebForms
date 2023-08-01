using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPNetWebForms.Model
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Product Description")]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}