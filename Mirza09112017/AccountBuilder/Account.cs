using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.AccountBuilder
{
    public abstract class Account
    {

        public int Year { get; set; }
        public string Name { get; set; }

        public enum StateEnum
        {
            MD,
            VA
        }

        protected StateEnum state { get; set; }

        public string State
        {
            get { return state.ToString(); }
            set
            {
                state = (StateEnum)Enum.Parse(typeof(StateEnum), value);
            }
        }

        public override string ToString()
        {
            return "" + Year + " " + Name + " " + " ( " + State + " : " + " )";
        }

        public abstract void ApplySurcharge(ref decimal cost);
    }

}
