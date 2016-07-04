using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ContactTypeData : BaseDataAccess<ContactType>
    {
        public ContactType GetContactType(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.ContactTypes.FirstOrDefault(x => x.ContactTypeID == id);
            }
        }
    }
}
