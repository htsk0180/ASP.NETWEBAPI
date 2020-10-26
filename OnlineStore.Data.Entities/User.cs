using System.Collections.Generic;

namespace OnlineStore.Data.Entities
{
    public class User : EntityBase<int>
    {
        public User()
        {
            AllowedCategories = new List<Category>();
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Fullname { get; set; }

        public string Mail { get; set; }

        public virtual ICollection<Category> AllowedCategories { get; set; } 
    }
}
