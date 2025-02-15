﻿namespace CoreMVCCodeFirst.Models.Entıtıes
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        public int? CategoryID { get; set; }

        //Relational Properties

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
