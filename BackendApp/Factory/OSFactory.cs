using BackendApp.Interface;
using BackendApp.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApp.Factory
{
    internal class OSFactory
    {
        public IOS Identity(string minUserFolder)
        {
            if (minUserFolder.Contains("C:"))
            {
                return new Windows("Spiderman");
            }
            else if (minUserFolder.Contains("/"))
            {
                return new Linux("Batman");
            }
            else
                return null;
        }
    }
}
