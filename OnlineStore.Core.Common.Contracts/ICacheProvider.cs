namespace OnlineStore.Core.Common.Contracts
{
    public interface ICacheProvider
    {
        void Set(string key, object value, int expireAsMinute);

        T Get<T>(string key);

        void Remove(string key);

        bool IsExist(string key);
    }
}
