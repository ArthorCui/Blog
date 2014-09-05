using OnePiece.Framework.SubSonic;
using SubSonic.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core
{
    public interface IBlogRepository
    {
        IQueryable<T> All<T>() where T : EntityBase, new();
        IQueryable<T> Where<T>(Expression<Func<T, bool>> expression) where T : EntityBase, new();
        IList<T> All<T>(Expression<Func<T, bool>> expression) where T : EntityBase, new();
        IList<T> Where<T>(Expression<Func<T, bool>> dbSearchExpression, Predicate<T> inMemorySearchExpression) where T : EntityBase, new();
        T Single<T>(int id) where T : EntityBase, new();
        T Single<T>(Expression<Func<T, bool>> expression) where T : EntityBase, new();
        object Add<T>(T model, Action<T> addedAction = null) where T : EntityBase, new();
        void Add<T>(IEnumerable<T> models) where T : EntityBase, new();
        int Update<T>(T model, Action<T> updatedAction) where T : EntityBase, new();
        int Update<T>(T model, bool getOrigin = true) where T : EntityBase, new();
        int Update<T>(IEnumerable<T> models) where T : EntityBase, new();
        int Delete<T>(int id, Action deletedAction = null) where T : EntityBase, new();
        int Delete<T>(IEnumerable<T> models) where T : EntityBase, new();
        int Delete<T>(Expression<Func<T, bool>> expression) where T : EntityBase, new();
        bool Exists<T>(Expression<Func<T, bool>> expression) where T : EntityBase, new();
        IList<T> Find<T>(Expression<Func<T, bool>> expression) where T : EntityBase, new();
        PagedList<T> GetPaged<T>(int pageIndex, int pageSize) where T : EntityBase, new();
        PagedList<T> GetPaged<T>(string sortBy, int pageIndex, int pageSize) where T : EntityBase, new();
        int Count<T>() where T : EntityBase, new();
        List<T> Top<T, TOrder>(int topCount, Expression<Func<T, bool>> where, bool isDesc, params Expression<Func<T, TOrder>>[] orderByColumnExps) where T : EntityBase, new();
        T Save<T>(Expression<Func<T, bool>> expression, T model) where T : EntityBase, new();
    }
}
