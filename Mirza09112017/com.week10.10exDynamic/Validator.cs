using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.com.week10._10exDynamic
{
    public static class Validator
    {
        public static void ValidateNonNegative<T>(T data) where T:class
       {
            Type t = data.GetType();
            if(t.GetProperties().Where(w => w.GetCustomAttributesData()
            .Any(a => a.AttributeType == typeof(NonNegative)))
            .Any(x => Convert.ToInt32(x.GetValue(data)) > 0))
            {
                throw new ArgumentException(t.Name +
                            " has a property with a value < 0.");
            }

       }

        public static void ValidateNonNegative(this object data)
        {
            Type t = data.GetType();
            if (t.GetProperties().Where(w => w.GetCustomAttributesData()
             .Any(a => a.AttributeType == typeof(NonNegative)))
            .Any(x => Convert.ToInt32(x.GetValue(data)) > 0))
            {
                throw new ArgumentException(t.Name +
                            " has a property with a value < 0.");
            }

        }
    }
}
