using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCargaison.dao
{
    interface ISystem<T>
    {
        List<T> getAll();
        bool add(T objet);
        T getById(int id);
    }
}
