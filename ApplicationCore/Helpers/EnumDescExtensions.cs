using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Helpers
{
    public static class EnumDescExtensions
    {
        public static string ToDescriptionString<T>(this T val) where T : struct
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType().GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
