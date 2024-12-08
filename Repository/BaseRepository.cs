using System.Collections.Generic;
using sistema_vendas_TP1.model;

namespace sistema_vendas_TP1.repository
{
    public abstract class BaseRepository<T> where T : IGenericProps
    {
        protected List<T> items = new List<T>();

        public void Create(T item)
        {
            items.Add(item);
        }

        public List<T> GetAll()
        {
            return [.. items];
        }

        public T GetByCode(string code)
        {
            return items.Find(item => item.Code == code);
        }

        public bool DeleteByCode(string code)
        {
            T item = GetByCode(code);
            if (item != null)
            {
                items.Remove(item);
                return true;
            }
            return false;
        }
    }
}