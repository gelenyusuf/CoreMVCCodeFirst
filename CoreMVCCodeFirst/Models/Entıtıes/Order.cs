﻿namespace CoreMVCCodeFirst.Models.Entıtıes
{
    public class Order:BaseEntity
    {
        public string ShippingAddress { get; set; }
        public int? AppUserID { get; set; }
        
        //Relational Properties

        public virtual AppUser AppUser { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
