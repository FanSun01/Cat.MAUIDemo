using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cat.MauiDemo.Services
{
    public interface IKeyValueStorage
    {
        string Get(string key, string defaultValue);
        void Set(string key, string value);

    }
}
