using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace MetricInfrastructure.Storage.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void LoadDb();
        void Add(T entity);
        void Delete(T entity);
        long Count { get; }
        void Commit();
        ObservableCollection<T> GetAll();
        ObservableCollection<T> GetAll(int startPosition, int count);
        ObservableCollection<T> Local { get; }
        ObservableCollection<T> Where(Expression<Func<T, bool>> predicate);
        ObservableCollection<T> Where(Expression<Func<T, bool>> predicate, Expression<Func<T, string>> order);
    }
}
