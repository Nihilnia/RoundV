using System;
using System.Collections.Generic;

#nullable disable

namespace _4_LinQExercises.Lily.Data
{
    public partial class OrdersStatus
    {
        public OrdersStatus()
        {
            Orders = new HashSet<Order>();
        }

        public sbyte Id { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
