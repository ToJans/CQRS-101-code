using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VisugDemo.Infrastructure;

namespace VisugDemo.Domain
{
    public class Account:AR
    {
        bool isRegistered = false;

        void RegisterAccount(string Ordername, string AccountNumber)
        {
            Guard.Against(isRegistered, "You can not register the same account twice");
            Apply.AccountRegistered(Ordername: Ordername, AccountNumber: AccountNumber, AccountId: Id );
        }

        void OnAccountRegistered(string Ordername, string AccountNumber)
        {
            isRegistered = true;
        }
    }
}
