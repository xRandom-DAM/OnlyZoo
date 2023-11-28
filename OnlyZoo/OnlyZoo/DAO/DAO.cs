using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.DAO
{
    public interface DAO<T> where T : class
    {
        public List<T> getAll(Object obj);
        public T selectObject(String uuid);
        public bool insertObject(T obj);
        public T updateObject(T obj);
    }
}
