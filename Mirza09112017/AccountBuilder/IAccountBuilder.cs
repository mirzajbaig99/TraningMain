using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.AccountBuilder
{
    public interface IAccountBuilder
    {
        IAccountBuilder setName(string Name);
        IAccountBuilder setYear(int year);
        IAccountBuilder setState(string state);
        IAccountBuilder setHasOverDraft(bool hasOverdraft);
        IAccountBuilder setHasLowBalance(bool hasLowBalance);

        Account GetAccount { get; }
    }
}
