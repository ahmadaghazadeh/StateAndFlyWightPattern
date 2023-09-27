using System.Collections.Concurrent;

namespace StateAndFlyWightPattern
{
    public static class RequestStateFactory<TGeneric>
    {
        private static readonly ConcurrentDictionary<string, TGeneric> States = new ();

        public static T? GetState<T>() where T : class, TGeneric, new()
        {
            var nameOfType = typeof(T).Name;
            return States.GetOrAdd(nameOfType, (key) => new T()) as T;
        }
    }
}