﻿using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Entities;
using Solidariedade.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.DataAccess.Repositories
{
    public abstract class RepositorySqlBase<TId, T> : IRepository<TId, T> where T : TEntity<TId>
    {
        protected DbContext _context;
        public RepositorySqlBase(DbContext context)
        {
            _context = context;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public virtual T GetByID(TId id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual T Insert(T entity)
        {
            return _context.Set<T>().Add(entity).Entity;
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public virtual void Delete(TId id)
        {
            _context.Set<T>().Remove(GetByID(id));
        }
    }
}
