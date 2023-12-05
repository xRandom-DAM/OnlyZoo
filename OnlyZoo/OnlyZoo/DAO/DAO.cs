using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.DAO
{
    public interface DAO<T> where T : class
    {
        public List<T> GetAll(Object obj);
        public T SelectObject(Guid uuid);
        public bool InsertObject(T obj);
        public T UpdateObject(T obj);
    }
}
