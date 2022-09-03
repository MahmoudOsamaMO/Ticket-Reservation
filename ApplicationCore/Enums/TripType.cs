using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Enums
{
    public enum TripType
    {
        [Description("Cairo-Aswan")]
        Short,
        [Description("Cairo-Alexandria")]
        Long,
    }
}
