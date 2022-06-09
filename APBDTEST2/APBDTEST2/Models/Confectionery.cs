using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APBDTEST2.Models
{
    public class Confectionery
    {
        [Key]
        public int IdConfectionery { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public float PricePerOne { get; set; }

        public virtual ICollection<Confectionery_ClientOrder> ConfOrders { get; set; }
    }
}
