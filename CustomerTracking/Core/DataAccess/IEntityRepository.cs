using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAcsess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GettAll(Expression<Func<T, bool>> filter = null); // Filtre vermesende olur Tüm datayı İstiyo
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
