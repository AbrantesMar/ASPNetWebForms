using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreCurso.Model
{
    public class Store : BaseClass
    {

        public string Description { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        public bool Valid { get; set; }

        public virtual List<Person> Employers { get; set; }
        public virtual List<Item> Itens { get; set; }

        public Store() : base(0, "")
        {
        }
    }
}