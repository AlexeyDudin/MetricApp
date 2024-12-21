﻿using System.Collections.ObjectModel;
using System.Linq.Expressions;
using MetricInfrastructure.Storage.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MetricInfrastructure.Storage.Repositoryes
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly EfContext AppContext;

        public Repository(EfContext efContext)
        {
            AppContext = efContext;
        }

        public DbSet<T> Entities => AppContext.Set<T>();

        public long Count => Entities.Local.Count;

        public ObservableCollection<T> Local
        {
            get => new ObservableCollection<T>(Entities.ToList());
        }

        public void Add(T entity)
        {
            Entities.Add(entity);
        }

        public void Delete(T entity)
        {
            Entities.Remove(entity);
        }

        public void Commit()
        {
            AppContext.SaveChanges();
        }

        public ObservableCollection<T> GetAll()
        {
            return new ObservableCollection<T>(Entities);
        }

        public ObservableCollection<T> GetAll(int startPosition, int count)
        {
            var result = new ObservableCollection<T>(Entities.Skip(startPosition).Take(count));

            return result;
        }

        public void LoadDb()
        {
            Entities.Load();
        }

        public ObservableCollection<T> Where(Expression<Func<T, bool>> predicate)
        {
            return new ObservableCollection<T>(Entities.Where(predicate));
        }

        public ObservableCollection<T> Where(Expression<Func<T, bool>> predicate, Expression<Func<T, string>> order)
        {
            return new ObservableCollection<T>(Entities.Where(predicate).OrderBy(order));
        }

    }
}
