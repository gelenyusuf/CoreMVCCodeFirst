﻿namespace CoreMVCCodeFirst.Models.Entıtıes
{
    public class AppUserProfile:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties

        public virtual AppUser AppUser { get; set; }
    }
}
