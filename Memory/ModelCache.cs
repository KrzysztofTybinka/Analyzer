using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Memory
{
    public sealed class ModelCache
    {
        public static string StateName { get; private set; } = "Not working on any file";
        private static Dictionary<string, IEnumerable> _cache = new Dictionary<string, IEnumerable>();
        private static readonly object _lockObject = new object();
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
                return $"Working on {name}.";
            }
        }

        public static IEnumerable? Current()
        {
            lock (_lockObject)
            {
                if (!_cache.ContainsKey(StateName))
                {
                    return _cache[StateName];
                }
                return null;
            }
        }

        public static IEnumerable? Get(string name)
        {
            lock (_lockObject)
            {
                if (!_cache.ContainsKey(name))
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
                        StateName = "Not working on any file";
                    }
                    _cache.Remove(name);
                    return $"{name} removed.";
                }
                return $"{name} didn't exist.";
            }
        }
    }
}
