using System.Collections.Concurrent;

namespace StateAndFlyWightPattern
{
    public static class RequestStateFactory
    {
        private static ConcurrentDictionary<string, RequestState> States =
         new ConcurrentDictionary<string, RequestState>();

        public static T? GetState<T>() where T : RequestState, new()
        {
            var nameOfType = typeof(T).Name;
            return States.GetOrAdd(nameOfType, (key) => new T()) as T;
        }
    }
}