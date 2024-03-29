﻿using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{//generic constraint 
    //class referanse tip
    //IEntity IEntity
    // new()=> Newlenebilir olması gerektiği kısıtını ekliyo
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//Bize LINQ ile gelen bi özellik. Buraya filtre yazabilmemizi sağlıyo.
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T  entity);
        void Update(T entity);
        void Delete(T entity);
        List<Product> GetAllByCategory(int categoryId);//Ürünleri kategorisine göre listele
    }
}
