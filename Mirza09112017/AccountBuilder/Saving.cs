using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.AccountBuilder
{
        public class Saving : Account
        {
            public bool HasLowBalance { get; set; }

            public override void ApplySurcharge(ref decimal cost)
            {
                cost += HasLowBalance ? 10 : 0;
            }

            public override string ToString()
            {
                return base.ToString() + (HasLowBalance ? " (has LowBalance)" : "");
            }
        }

    
}
