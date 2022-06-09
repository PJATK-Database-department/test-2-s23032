using APBDTEST2.Models;
using System;
using System.Collections.Generic;

namespace APBDTEST2.DTO_s
{
    public class OrdersDto
    {
        public int IdClientOrder { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Comments { get; set; }

        public List<Confectionery_ClientOrder> Confectioneries { get; set; }
    }
}
