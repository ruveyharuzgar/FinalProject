using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    //class:referans tip
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new(): new'lenebilir olmalı (IEntity newlenemiyodu ya)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        //burda productManager de ki getall ı çağırıyorduk ya, onun içerisine
        //istediğim filtreyi ayrı ayrı yazmamak için böyle yazıyorum.Hepsini görüntüle
        //aşağıda ki gibi de yazarsam filtre verdiysem öyle yaz
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        //List<T> GetAllByCategory(int categoryId);
    }
}
