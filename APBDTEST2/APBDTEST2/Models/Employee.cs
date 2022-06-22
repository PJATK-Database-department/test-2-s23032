using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APBDTEST2.Models
{
    public class Employee
    {
        [Key]
        public int IdEmployee { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(60)]
        public string LastName { get; set; }

        public virtual ICollection<ClientOrder> Orders { get; set; }
    }
}
