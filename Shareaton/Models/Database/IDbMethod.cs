using System;
using System.Collections.Generic;

namespace Shareaton.Models.Database
{
    interface IDbMethod<T>
    {
        T GetOneById(Guid id);
        void Save(T item);
        void SaveAll(IEnumerable<T> items);
        void Update(T item);
        void Delete(T item);
        void SearchByName(string name);
    }
}
