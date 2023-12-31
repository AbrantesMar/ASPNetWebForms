﻿using System.Collections.Generic;

namespace ASPNetWebForms.Model
{
    public class CartItem
    {
        public string ItemId { get; set; }

        public string CartId { get; set; }

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int ProductId { get; set; }

        public int interval { get; set; }

        public virtual Product Product { get; set; }
    }
}