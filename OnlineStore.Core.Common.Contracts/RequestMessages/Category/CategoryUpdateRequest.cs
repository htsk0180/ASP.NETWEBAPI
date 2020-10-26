namespace OnlineStore.Core.Common.Contracts.RequestMessages
{
    public class CategoryUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
    }
}