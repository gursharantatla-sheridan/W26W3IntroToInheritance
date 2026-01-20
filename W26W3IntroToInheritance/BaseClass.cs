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

        // constructor
        public BaseClass()
        {
            Console.WriteLine("Base class constructor called");
        }

        public BaseClass(string msg)
        {
            Console.WriteLine("Base class constructor with message: " + msg);
        }
    }

    public class DerivedClass : BaseClass
    {
        public DerivedClass() : base("hello")
        {
            Console.WriteLine("Derived class constructor called");
        }

        public DerivedClass(string m1) : base(m1)
        {

        }

        public void MyMethod()
        {
            //myPrivateVar = 1;
            myProtectedVar = 2;
            myPublicVar = 3;
        }
    }
}
