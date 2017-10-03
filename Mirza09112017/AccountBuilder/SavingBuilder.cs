using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.AccountBuilder
{
    public class SavingBuilder : IAccountBuilder
    {
        public SavingBuilder()
        {
            this._saving = new Saving();
        }

        private Saving _saving;

        public Account GetAccount
        {
            get
            {
                return this._saving;
            }
        }

        public IAccountBuilder setName(string name)
        {
            this._saving.Name = name;
            return this;
        }
        public IAccountBuilder setYear(int year)
        {
            this._saving.Year = year;
            return this;
        }
        public IAccountBuilder setState(string state)
        {
            this._saving.State = state;
            return this;
        }
        public IAccountBuilder setHasOverDraft(bool hasOverdraft)
        {
            // TODO : throw unSupported exception
            return this;
        }
        public IAccountBuilder setHasLowBalance(bool hasLowBalance)
        {
            this._saving.HasLowBalance = hasLowBalance;
            return this;
        }
    }
}
