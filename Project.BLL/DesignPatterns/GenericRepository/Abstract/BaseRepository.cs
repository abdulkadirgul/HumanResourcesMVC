using Project.BLL.DesignPatterns.GenericRepository.InterfaceRepo;
using Project.BLL.SingletonPatterns;
using Project.DAL.Context;
using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.BaseRepo
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        AppDbContext db = Singleton.Context;

        public string Add(T model)
        {
            try
            {
                model.ID = new int();
                db.Set<T>().Add(model);
                db.SaveChanges();
                return $"Veri Eklendi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string Add(List<T> models)
        {
            try
            {
                foreach (T item in models)
                {
                    item.ID = new int();
                    db.Set<T>().Add(item);
                    db.SaveChanges();
                }
                
                return "Liste Eklendi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Any(exp);
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public List<T> GetDefault(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Where(exp).ToList();
        }

        public List<T> GetList()
        {
            return db.Set<T>().ToList();
        }

        public void RemoveForce(T model)
        {
            try
            {
                if (model.ID != null)
                {
                    T deleted = GetById(model.ID);
                    db.Set<T>().Remove(deleted);
                    db.SaveChanges();
                }
                else
                {
                    return;
                }


            }
            catch (Exception ex)
            {

                return;

            }
        }

        public string Update(T model)
        {
            try
            {
                T entity = GetById(model.ID);
                var entry = db.Entry(entity);
                switch (model.Status)
                {
                    case ENTİTİES.Enums.DataStatus.None:
                        entity.Status = ENTİTİES.Enums.DataStatus.None;
                        entry.CurrentValues.SetValues(model);
                        db.SaveChanges();
                        break;
                    case ENTİTİES.Enums.DataStatus.Active:
                        entity.Status = ENTİTİES.Enums.DataStatus.Active;
                        entry.CurrentValues.SetValues(model);
                        db.SaveChanges();
                        break;
                    case ENTİTİES.Enums.DataStatus.Deleted:
                        entity.Status = ENTİTİES.Enums.DataStatus.Deleted;
                        entry.CurrentValues.SetValues(entity);
                        db.SaveChanges();
                        break;
                    case ENTİTİES.Enums.DataStatus.Updated:
                        entity.Status = ENTİTİES.Enums.DataStatus.Updated;
                        entry.CurrentValues.SetValues(model);
                        db.SaveChanges();
                        break;
                }
                return "Veri Güncellendi!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
