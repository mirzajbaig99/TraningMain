using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirza09112017.AccountBuilder
{
    public static class AccountBuilderOrchestrator
    {
       public static Account Build(string accountString)
        {
            IAccountBuilder builder;
            var tokens = accountString.Split();
            if (tokens.Length < 4 || tokens.Length > 5)
            {
                throw new FormatException("Invalid Account");
            }
            switch (tokens[0].ToLower())
            {
                case "c":
                case "checking":
                    builder = new CheckingBuilder();
                    break;
                case "s":
                case "savings":
                    builder = new SavingBuilder();
                    break;
                default:
                    throw new FormatException("Account must begin with 'checking' or 'saving'.");
            }
            builder.setYear(Convert.ToInt32(tokens[1]))
            .setName(tokens[2])
            .setState(tokens[3]);
            if (tokens.Length == 5)
            {
                switch (tokens[4].ToLower())
                {
                    case "o":
                    case "overdraft":
                        builder.setHasOverDraft(true);
                        break;
                    case "l":
                    case "lowbalance":
                        builder.setHasLowBalance(true);
                        break;
                    default:
                        throw new FormatException("If 5th token provided, must be 'overdraft' or 'lowbalance'.");
                }
            }

            return builder.GetAccount;

        }
    }
}
