using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCM.MIT.Data.Enums
{
    public enum TransStatus
    {
        [Description("New bill")]
        New,
        [Description("In Progress")]
        InProgress,
        [Description("Returned")]
        Returned,
        [Description("Cancelled")]
        Cancelled,
        [Description("Completed")]
        Completed
    }
}
