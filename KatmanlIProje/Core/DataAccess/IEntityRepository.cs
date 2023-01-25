using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //CORE KATMANI DİĞER KATMANLARI REFERANS ALMAZ
    public interface IEntityRepository<T> where T: class,IEntity,new()  //referans tip ve IEntityden new lenecek olur sadece
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null); //filtre vemeyebilirsin

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       
    }
}
