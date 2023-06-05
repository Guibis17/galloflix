using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalloFlix.interfaces
{
    public interface IRepository<T> where T : class
    {
        void create(T model);

        List<T> readAll();

        T readyById(int? id);

        void update(T model);
        void Delete(int? id);
    }
}