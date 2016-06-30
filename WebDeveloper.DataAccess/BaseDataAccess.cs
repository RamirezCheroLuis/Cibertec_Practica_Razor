using System.Collections.Generic;
using System.Linq;

namespace WebDeveloper.DataAccess
{
    public class BaseDataAccess<T> : IDataAccess<T> where T: class
    {
        public int Add(T entity)
        {
            return 0;
        }

        public int Delete(T entity)
        {
            return 0;
        }

        public List<T> GetList()
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Set<T>().ToList();
            }
        }

        public int Update(T entity)
        {
            return 0;
        }
    }
}
