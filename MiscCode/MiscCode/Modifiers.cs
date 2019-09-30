using System;
using System.Collections.Generic;
using System.Text;

namespace MiscCode
{
    public static class Modifiers
    {
        public static void DoStuff()
        {
            Base b = new Base();
            b.SomeMethod();

            Base d = new Derived();
            d.SomeMethod();

            Derived dd = new Derived();
            dd.SomeMethod();

            DerivedNew dn = new DerivedNew();
            dn.SomeMethod();
        }
    }

    public class Base
    {
        public virtual void SomeMethod()
        {
            Console.WriteLine("Base:SomeMethod");
        }
    }

    public class Derived : Base
    {
        public override void SomeMethod()
        {
            Console.WriteLine("Derived:SomeMethod");
        }
    }
    public class DerivedNew : Base
    {
        //  if you use the new keyword instead of override, the method in the derived class doesn't override the method in the base class, it merely hides it.
        public new void SomeMethod()
        {
            Console.WriteLine("DerivedNew:SomeMethod");
        }
    }
}
