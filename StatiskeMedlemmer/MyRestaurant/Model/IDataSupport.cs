using System;
using System.Collections.Generic;

namespace MyRestaurant.Data
{
    public interface IDataSupport<T>
    {
        event EventHandler CollectionChange;
        T this[int index] { get; }
        int Count { get; }
        void Clear();
        IEnumerator<T> GetEnumerator();
        T Insert(T menu);
        void Load(string path);
        void Remove(int id);
        void Save(string path);
        T Find(int id);
    }
}