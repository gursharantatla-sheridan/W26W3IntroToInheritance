using System;
using System.Collections.Generic;
using System.Text;

namespace W26W3IntroToInheritance
{
    public class BaseClass
    {
        // fields
        private int myPrivateVar;
        protected int myProtectedVar;
        public int myPublicVar;
    }

    public class DerivedClass : BaseClass
    {
        public void MyMethod()
        {
            //myPrivateVar = 1;
            myProtectedVar = 2;
            myPublicVar = 3;
        }
    }
}
