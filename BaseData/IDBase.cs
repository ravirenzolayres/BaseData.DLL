using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BaseData
{
    public interface IDBase<T> where T : class
    {
        Task Add(T entity);
        Task Edit(T entity);
        Task<T> Get(Func<T, bool> condition);
        Task<List<T>> GetAll();
        Task<List<T>> GetAll(Func<T,bool> condition);
        Task Delete(T entity);
        Task Complete();
    }
}
