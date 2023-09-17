using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.DAL
{
    internal interface IDal<T>              //Data Access Layer
        {
            public List<T> findAll();
            public T findById(int id);
            public bool create(T obj);
            public bool insert(T obj);
            public bool update(T obj);
            public bool delete(int id);
        }
    }

}
}
