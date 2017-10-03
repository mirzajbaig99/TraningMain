using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.AccountBuilder
{
    public class CheckingBuilder : IAccountBuilder
    {
        public CheckingBuilder()
        {
            this._checking = new Checking();
        }

        private Checking _checking;

        public Account GetAccount {
                get{
                return this._checking;
                }
            }

        public IAccountBuilder setName(string name)
        {
            this._checking.Name = name;
            return this;
        }
        public IAccountBuilder setYear(int year)
        {
            this._checking.Year = year;
            return this;
        }
        public IAccountBuilder setState(string state)
        {
            this._checking.State = state;
            return this;
        }
        public IAccountBuilder setHasOverDraft(bool hasOverdraft)
        {
            this._checking.HasOverDraft = hasOverdraft;
            return this;
        }
        public IAccountBuilder setHasLowBalance(bool hasLowBalance)
        {
            // TODO : throw unSupported exception
            return this;
        }

        
    }
}
