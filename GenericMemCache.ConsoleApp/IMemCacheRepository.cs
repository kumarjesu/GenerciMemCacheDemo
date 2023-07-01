namespace GenericMemCache.ConsoleApp
{
    internal interface IMemCacheRepository
    {
        void SaveMemCache<T>(string key, T value) where T : class;
    }
}