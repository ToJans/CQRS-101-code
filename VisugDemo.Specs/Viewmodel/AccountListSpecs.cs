using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisugDemo.Viewmodel;

namespace VisugDemo.Specs.Viewmodel
{
    [TestClass]
    public class AccountListSpecs
    {
        [TestMethod]
        public void PopulateAccountList()
        {
            var mvr = new VisugDemo.Infrastructure.MiniVanRegistry();
            var state = new Dictionary<string,string>();
            var SUT = new AccountListHandler(state);
            mvr.RegisterNonArInstance(SUT);

            var bus = new SpecBus(mvr);
            
            bus.Given(x=>x.AccountRegistered(Ordername: "Tom", AccountNumber: "1", AccountId: "act/1"));
            bus.Given(x=>x.AccountRegistered(Ordername: "Tom 2", AccountNumber: "2", AccountId: "act/2"));
            bus.Given(x=>x.AccountRegistered(Ordername: "Tom 3", AccountNumber: "3", AccountId: "act/3"));
            Assert.AreEqual(3, state.Count);
        
        }
    }
}
