using System.ComponentModel.DataAnnotations;

namespace APBDTEST2.Models
{
    public class Confectionery_ClientOrder
    {
        public int IdClientOrder { get; set; }
        public int IdConfectionery  { get; set; }
        public int Amount { get; set; }
        [MaxLength(300)]
        public string ?Comments { get; set; }

        public virtual ClientOrder IdClientOrderNav { get; set; }
        public virtual Confectionery IdConfectioneryNav { get; set; }
    }
}
