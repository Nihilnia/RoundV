using System;
using System.Collections.Generic;

#nullable disable

namespace _3_ScaffoldingDatabase.Data.Lily
{
    public partial class PurchaseOrderStatus
    {
        public PurchaseOrderStatus()
        {
            PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
