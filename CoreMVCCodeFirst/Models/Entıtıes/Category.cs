﻿namespace CoreMVCCodeFirst.Models.Entıtıes
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Relational Properties

        public virtual ICollection<Product> Products { get; set; }
    }
}
