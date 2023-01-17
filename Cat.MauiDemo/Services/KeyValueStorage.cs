using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat.MauiDemo.Services
{
    public class KeyValueStorage : IKeyValueStorage
    {
        public string Get(string key, string defaultValue)
        {
            return Preferences.Get(key, defaultValue);
        }

        public void Set(string key, string value)
        {
            Preferences.Set(key, value);
        }
    }
}
