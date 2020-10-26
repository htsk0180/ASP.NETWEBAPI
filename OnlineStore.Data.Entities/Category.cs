using System.Collections.Generic;

namespace OnlineStore.Data.Entities
{
    public class Category : EntityBase<int>
    {
        public Category()
        {
            AssignedUsers = new List<User>();
            Products = new List<Product>();
        }

        public string Name { get; set; }

        public int Rank { get; set; }

        public virtual ICollection<User> AssignedUsers { get; set; }
        public virtual ICollection<Product> Products  { get; set; }
    }
}
