using System;
using System.Collections.Generic;

#nullable disable

namespace _1_sqlCommandsAtCSharp.Lily.Data
{
    public partial class EmployeePrivilege
    {
        public int EmployeeId { get; set; }
        public int PrivilegeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Privilege Privilege { get; set; }
    }
}
