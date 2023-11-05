using System.Collections;

namespace Memory
{
    /// <summary>
    /// Stores obects and provides methods
    /// to read and modify them.
    /// </summary>
    public sealed class ModelCache
    {
        public static string? StateName 
        { 
            get
            {
                if (_stateName == null)
                {
                    return "Not working on any file, upload a file to start working.";
                }
                return $"Working on {_stateName}.";
            }
            private set
            {
                _stateName = value;
            }
        }

        private static string? _stateName;
        private static Dictionary<string, IEnumerable> _cache = new();
        private static readonly object _lockObject = new();
        ModelCache() { }

        /// <summary>
        /// Adds collection of objects into cache.
        /// </summary>
        /// <param name="name">Cache key</param>
        /// <param name="collection">Cache value</param>
        /// <returns>Message informing about adding state.</returns>
        public static string Add(string name, IEnumerable collection)
        {
            lock (_lockObject)
            {
                if (_cache.ContainsKey(name))
                {
                    return $"File named {name} already exists.";
                }
                _cache.Add(name, collection);
                StateName = name;
                return $"{name} added, now you're working on {name}.";
            }
        }

        /// <summary>
        /// Switches StateName
        /// </summary>
        /// <param name="name">Cache key</param>
        /// <returns>Message informing about switching state.</returns>
        public static string Switch(string name)
        {
            lock (_lockObject)
            {
                if (!_cache.ContainsKey(name))
                {
                    return $"File named {name} doesn't exist.";
                }
                StateName = name;
                return $"Switched to {name}.";
            }
        }

        /// <summary>
        /// Gets collection based on current StateName
        /// </summary>
        /// <returns>Collection of objects</returns>
        public static IEnumerable? Current()
        {
            lock (_lockObject)
            {
                if (_stateName != null && _cache.ContainsKey(_stateName))
                {
                    return _cache[_stateName];
                }
                return null;
            }
        }

        /// <summary>
        /// Overrides cached item
        /// </summary>
        /// <param name="name">Cache key to be overriden</param>
        /// <param name="collection">New cache value</param>
        public static void Override(IEnumerable collection)
        {
            lock (_lockObject)
            {
                if (_stateName != null && _cache.ContainsKey(_stateName))
                {
                    _cache[_stateName] = collection;
                }
            }
        }

        /// <summary>
        /// Gets collection based on key name
        /// </summary>
        /// <param name="name">Cache key</param>
        /// <returns>Collection of objects</returns>
        public static IEnumerable? Get(string name)
        {
            lock (_lockObject)
            {
                if (_cache.ContainsKey(name))
                {
                    return _cache[name];
                }
                return null;
            }
        }

        /// <summary>
        /// Removes item from cache
        /// </summary>
        /// <param name="name">Cache key</param>
        /// <returns>Message informing about deleting state.</returns>
        public static string Remove(string name)
        {
            lock (_lockObject)
            {
                if (_cache.ContainsKey(name))
                {
                    if (_stateName == name)
                    {
                        _stateName = null;
                    }
                    _cache.Remove(name);
                    return $"{name} removed.";
                }
                return $"{name} didn't exist.";
            }
        }
    }
}
