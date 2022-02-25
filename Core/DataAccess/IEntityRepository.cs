using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint(generic kısıt)
    //class: referans tip
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new(): new'lenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //filtre vermek zorunlu değil. 
        T Get(Expression<Func<T, bool>> filter); //filtre vermek zorunlu
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAllByCategoryId(int categoryId);
    }
}
