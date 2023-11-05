using System.Collections;

namespace Memory
{
    public sealed class ModelCache
    {
        public static string? StateName 
        { 
            get
            {
                if (_stateName == null)
                {
                    return "Not working on any file.";
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

        public static IEnumerable? Current()
        {
            lock (_lockObject)
            {
                if (StateName != null && _cache.ContainsKey(StateName))
                {
                    return _cache[StateName];
                }
                return null;
            }
        }

        public static void Override(string name, IEnumerable collection)
        {
            lock (_lockObject)
            {
                if (_cache.ContainsKey(name))
                {
                    _cache[name] = collection;
                }
            }
        }

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

        public static string Remove(string name)
        {
            lock (_lockObject)
            {
                if (_cache.ContainsKey(name))
                {
                    if (StateName == name)
                    {
                        StateName = null;
                    }
                    _cache.Remove(name);
                    return $"{name} removed.";
                }
                return $"{name} didn't exist.";
            }
        }
    }
}
