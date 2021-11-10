using System;
using System.Collections.Generic;

#nullable disable

namespace _3_ScaffoldingDatabase.Data.Lily
{
    public partial class OrderDetailsStatus
    {
        public OrderDetailsStatus()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
