using System;
using System.Collections.Generic;

namespace Shareaton.Models.Database
{
    public class UserDbMethod : IDbMethod<User>
    {
        public void Delete(User item)
        {
            throw new NotImplementedException();
        }

        public User GetOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save(User item)
        {
            throw new NotImplementedException();
        }

        public void SaveAll(IEnumerable<User> items)
        {
            throw new NotImplementedException();
        }

        public void SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}