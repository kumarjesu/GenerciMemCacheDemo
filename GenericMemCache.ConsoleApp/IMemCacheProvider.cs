namespace GenericMemCache.ConsoleApp
{
    internal interface IMemCacheProvider
    {
        T GetCacheProvier<T>(string KEY) where T : class;
    }
}