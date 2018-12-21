﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Webapp.Starter.Data.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get(
           Expression<Func<TEntity, bool>> filter = null,
           Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
           string includeProperties = ""
           );

        TEntity GetById(object id);

        void Insert(TEntity entity);

        void Update(TEntity entityToUpdate);

        void Delete(TEntity entityToDelete);
    }
}
