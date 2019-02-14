using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsUserCollection
    {
        public List<clsUser> UserList { get; set; }
        public clsUser ThisUser { get; set; }
        public int Count { get; set; }

        public int Add()
        {
            throw new NotImplementedException();
        }
    }
}