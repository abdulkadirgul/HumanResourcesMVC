using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.InterfaceRepo
{
   public interface IRepository<T> where T:BaseEntity
    {
        //List Commands
        List<T> GetAll();
        List<T> GetPassives();
        List<T> GetActives();
        List<T> GetModifieds();

        //Modification Commands
        void Add(T item);
        void AddList(List<T> item);
        void Delete(T item);
        void DeleteList(List<T> item);
        void Update(T item);
        void UpdateList(List<T> item);

        //Expression Commands

        List<T> Where(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        object Select(Expression<Func<T, object>> exp);
        IQueryable<X> Select<X>(Expression<Func<T, X>> exp);

        //Find Method

        T Find(int id);
        //Get Last Data
        T FindLastData();

        //Get First Data
        T FindFirstData();


    }
}
