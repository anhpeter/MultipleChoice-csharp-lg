using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.BLL
{
    abstract class BaseBUS <T>
    {
        public abstract BaseDAO<T> getMainDAO();

        //FETCHES
        public List<T> getAllForSelectData()
        {
            return getMainDAO().getAllForSelectData();
        }

        public List<T> getAll(Pagination p)
        {
            return getMainDAO().getAll(p);
        }
        public virtual int countAll()
        {
            return getMainDAO().countAll();
        }
        public virtual T getDetailsById(int id)
        {
            T item = getMainDAO().getByPK(id + "");
            return item;
        }

        //WRITE
        public virtual bool add(T item)
        {
            return getMainDAO().add(item) > 0;
        }
        public virtual int addMany(List<T> list)
        {
            int count = 0;
            foreach (var item in list)
            {
                if (add(item)) count++;
            }
            return count;
        }

        public virtual bool update(T item)
        {

            return getMainDAO().update(item);
        }

        public virtual bool delete(int id)
        {
            return getMainDAO().deleteByPK(id + "");
        }
    }
}
