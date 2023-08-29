using BackendApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApp.Types
{
    internal class Windows : OS, IOS
    {
        public Windows(string userFullName) : base(userFullName) 
        {
        
        }

        public string ShowOSType()
        {
            return $"Welcome {UserFullName} to Windows, running from backend!";
        }
    }
}
