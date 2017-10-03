using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.AccountBuilder
{
    public class Checking : Account
    {
        public bool HasOverDraft { get; set; }

        public override void ApplySurcharge(ref decimal cost)
        {
            cost += HasOverDraft ? 20 : 0;
        }

        public override string ToString()
        {
            return base.ToString() + (HasOverDraft ? " (has OverDraft)" : "");
        }
    }

}
