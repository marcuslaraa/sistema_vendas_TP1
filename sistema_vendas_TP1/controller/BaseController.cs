using sistema_vendas_TP1.repository;
using sistema_vendas_TP1.model;
using System.Collections.Generic;

namespace sistema_vendas_TP1.controller
{
    public abstract class BaseController<T> where T : IGenericProps
    {
        protected readonly BaseRepository<T> repository;

        protected BaseController(BaseRepository<T> repository)
        {
            this.repository = repository;
        }

        public void Create(T item)
        {
            repository.Create(item);
        }

        public List<T> GetAll()
        {
            return repository.GetAll();
        }

        public T GetByCode(string code)
        {
            return repository.GetByCode(code);
        }

        public bool DeleteByCode(string code)
        {
            return repository.DeleteByCode(code);
        }
    }
}