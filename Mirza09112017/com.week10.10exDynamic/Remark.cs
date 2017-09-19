using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.com.week10._10exDynamic
{
    [AttributeUsage(AttributeTargets.All)]
    public class RemarkAttribute : Attribute
    {
        string pri_remark;

        public RemarkAttribute(string comment)
        {
            pri_remark = comment;
        }

        public string Remark
        {
            get
            {
                return pri_remark;
            }
        }

    }
}
