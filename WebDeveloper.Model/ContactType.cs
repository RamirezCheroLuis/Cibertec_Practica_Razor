using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    

    [Table("Person.ContactType")]
    public partial class ContactType
    {
        
        public ContactType()
        {
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
        }
        
        public int ContactTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ModifiedDate { get; set; } 

        
        public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }
    }
}
