using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreCurso.Model
{
    public class ShopCart
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<Item> Itens { get; set; } 
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}