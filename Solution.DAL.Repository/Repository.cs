using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Solution.DAL.EF;
namespace Solution.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly SolutionDBContext DBContext;



        public Repository(SolutionDBContext context)
        {
            DBContext = context;
        }



        public IQueryable<T> AsQueryble()
        {
            return DBContext.Set<T>().AsQueryable();
        }



        public void Commit()
        {
            DBContext.SaveChanges();
            //dBContext.Database.CloseConnection();
        }



        public void Delete(T entity)
        {

            try
            {
                DBContext.Entry<T>(entity).State = EntityState.Deleted;
            }
            catch (Exception ex)
            {

                throw;
            }

        }



        public IEnumerable<T> GetAll()
        {
            return DBContext.Set<T>();
        }
            public T GetOne(Expression<Func<T, bool>> predicado)
        {
            return DBContext.Set<T>().Where(predicado).FirstOrDefault();
        }


        public T GetOneById(int id)
        {
            return DBContext.Set<T>().Find(id);
        }




        public void Insert(T entity)
        {
            if (DBContext.Entry<T>(entity).State == EntityState.Detached)
            {
                DBContext.Entry<T>(entity).State = EntityState.Added;
            }
            else
            {
                DBContext.Set<T>().Add(entity);
            }
        }



        public IEnumerable<T> Search(Expression<Func<T, bool>> predicado)
        {
            return DBContext.Set<T>().Where(predicado);
        }

        public void Update(T entity)
        {
            if (DBContext.Entry<T>(entity).State == EntityState.Detached)
            {
                DBContext.Entry<T>(entity).State = EntityState.Modified;
            }
            else
            {
                DBContext.Set<T>().Add(entity);
            }
        }

    }
}
