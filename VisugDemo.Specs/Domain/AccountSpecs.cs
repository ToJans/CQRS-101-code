using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisugDemo.Domain;

namespace VisugDemo.Specs.Domain
{
    [TestClass]
    public class AccountSpecs
    {
        [TestMethod]
        public void RegisterAnAccount()
        {
            var mvr = new VisugDemo.Infrastructure.MiniVanRegistry();
            var cls = new //RegisterAccount
            {
                Ordername = "Tom",
                AccountNumber = "123-456789-01",
                AccountId = "account/1"
            };

            mvr.RegisterArType<Account>();
            var SUT = new SpecBus(mvr);

            SUT.When(x => x.RegisterAccount(Ordername: "Tom", AccountNumber: "123-456789-01", AccountId: "account/1"));
            SUT.Then(x => x.AccountRegistered(Ordername: "Tom", AccountNumber: "123-456789-01", AccountId: "account/1"));
        }

        [TestMethod]
        public void RegisterAnAccountTwiceShouldFail()
        {
            var mvr = new VisugDemo.Infrastructure.MiniVanRegistry();
            mvr.RegisterArType<Account>();
            var SUT = new SpecBus(mvr);

            SUT.Given(x => x.AccountRegistered(Ordername: "Tom", AccountNumber: "123-456789-01", AccountId: "account/1"));
            SUT.When(x => x.RegisterAccount(Ordername: "Tom", AccountNumber: "123-456789-01", AccountId: "account/1"));
            SUT.ThenException<InvalidOperationException>();
        }
    }
}