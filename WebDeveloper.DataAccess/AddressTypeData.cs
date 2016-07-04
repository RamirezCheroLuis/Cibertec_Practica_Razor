using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class AddressTypeData : BaseDataAccess<AddressType>
    {
        public AddressType GetAddressType(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.AddressTypes.FirstOrDefault(x => x.AddressTypeID == id);
            }
        }
    }
}
