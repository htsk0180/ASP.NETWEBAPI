namespace OnlineStore.Core.Common.Contracts.RequestMessages
{
    public class UserCreateRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Fullname { get; set; }

        public string Mail { get; set; }
    }
}
