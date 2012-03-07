using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisugDemo.Viewmodel
{
    public class AccountListHandler
    {
        private Dictionary<string, string> state;

        public AccountListHandler(Dictionary<string, string> state)
        {
            // TODO: Complete member initialization
            this.state = state;
        }

        public void OnAccountRegistered()
        {
            state.Add(Guid.NewGuid().ToString(),"Blah");
        }
    }
}
