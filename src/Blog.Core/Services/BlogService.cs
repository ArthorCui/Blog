using OnePiece.Framework.SubSonic;
using StructureMap;
using SubSonic.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core
{
    public class BlogService : IBlogService
    {
        public IBlogDbContext dbContext
        {
            get
            {
                if (_dbContext == null)
                {
                    _dbContext = ObjectFactory.GetInstance<IBlogDbContext>();
                }
                return _dbContext;
            }
        } private IBlogDbContext _dbContext;

        #region DB Repository

        public IQueryable<T> All<T>() where T : EntityBase, new()
        {
            return dbContext.All<T>();
        }

        public IQueryable<T> Where<T>(Expression<Func<T, bool>> expression) where T : EntityBase, new()
        {
            return dbContext.Where<T>(expression);
        }

        public IList<T> All<T>(Expression<Func<T, bool>> expression) where T : EntityBase, new()
        {
            return dbContext.All<T>(expression);
        }

        public IList<T> Where<T>(Expression<Func<T, bool>> dbSearchExpression, Predicate<T> inMemorySearchExpression) where T : EntityBase, new()
        {
            return dbContext.Where<T>(dbSearchExpression, inMemorySearchExpression);
        }

        public T Single<T>(int id) where T : EntityBase, new()
        {
            return dbContext.Single<T>(id);
        }

        public T Single<T>(Expression<Func<T, bool>> expression) where T : EntityBase, new()
        {
            return dbContext.Single<T>(expression);
        }

        public object Add<T>(T model, Action<T> addedAction = null) where T : EntityBase, new()
        {
            return dbContext.Add<T>(model, addedAction);
        }

        public void Add<T>(IEnumerable<T> models) where T : EntityBase, new()
        {
            dbContext.Add<T>(models);
        }

        public int Update<T>(T model, Action<T> updatedAction) where T : EntityBase, new()
        {
            return dbContext.Update<T>(model, updatedAction);
        }

        public int Update<T>(T model, bool getOrigin = true) where T : EntityBase, new()
        {
            return dbContext.Update<T>(model, getOrigin);
        }

        public int Update<T>(IEnumerable<T> models) where T : EntityBase, new()
        {
            return dbContext.Update<T>(models);
        }

        public int Delete<T>(int id, Action deletedAction = null) where T : EntityBase, new()
        {
            return dbContext.Delete<T>(id, deletedAction);
        }

        public int Delete<T>(IEnumerable<T> models) where T : EntityBase, new()
        {
            return dbContext.Delete<T>(models);
        }

        public int Delete<T>(Expression<Func<T, bool>> expression) where T : EntityBase, new()
        {
            return dbContext.Delete<T>(expression);
        }

        public bool Exists<T>(Expression<Func<T, bool>> expression) where T : EntityBase, new()
        {
            return dbContext.Exists<T>(expression);
        }

        public IList<T> Find<T>(Expression<Func<T, bool>> expression) where T : EntityBase, new()
        {
            return dbContext.Find<T>(expression);
        }

        public PagedList<T> GetPaged<T>(int pageIndex, int pageSize) where T : EntityBase, new()
        {
            return dbContext.GetPaged<T>(pageIndex, pageSize);
        }

        public PagedList<T> GetPaged<T>(string sortBy, int pageIndex, int pageSize) where T : EntityBase, new()
        {
            return dbContext.GetPaged<T>(sortBy, pageIndex, pageSize);
        }

        public int Count<T>() where T : EntityBase, new()
        {
            return dbContext.Count<T>();
        }

        public List<T> Top<T, TOrder>(int topCount, Expression<Func<T, bool>> where, bool isDesc, params Expression<Func<T, TOrder>>[] orderByColumnExps) where T : EntityBase, new()
        {
            return dbContext.Top<T, TOrder>(topCount, where, isDesc, orderByColumnExps);
        }

        public T Save<T>(Expression<Func<T, bool>> expression, T model) where T : EntityBase, new()
        {
            return dbContext.Save<T>(expression, model);
        }

        #endregion
    }
}
