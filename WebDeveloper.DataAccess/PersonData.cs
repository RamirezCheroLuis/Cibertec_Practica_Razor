﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class PersonData : BaseDataAccess<Person>
    {
        public Person GetPerson(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Persons.FirstOrDefault(x => x.BusinessEntityID == id);
            }
        }
    }
}
