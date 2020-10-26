using System.Collections.Generic;

namespace OnlineStore.Core.Common.Contracts.ResponseMessages
{
    public class UserResponse
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Fullname { get; set; }

        public string Mail { get; set; }

        public Dictionary<int, string> AllowedCategories { get; set; }
    }
}
