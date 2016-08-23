using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shareaton.Models.Database
{
    interface IDbMethod<T>
    {
        T GetAll();
        T GetOneById(int id);
    }
}
