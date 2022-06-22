using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APBDTEST2.Models
{
    public class ClientOrder
    {
        [Key]
        public int IdClientOrder { get; set; }
        
        public DateTime OrderDate { get; set; }

        public DateTime ?CompletionDate  { get; set; }
        [MaxLength(300)]
        public string ?Comments { get; set; }

        public int IdClient { get; set; }
        public int IdEmployee { get; set; }

        public virtual Client IdClientNav { get; set; }
        public virtual Employee IdEmployeeNav { get; set; }

        public virtual ICollection<Confectionery_ClientOrder> ConfOrders { get; set; }

    }
}
