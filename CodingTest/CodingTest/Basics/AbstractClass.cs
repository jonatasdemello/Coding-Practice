using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Basics
{
    // Virtual methods have an implementation and provide the derived classes with the option of overriding it.
    // Abstract methods do not provide an implementation and force the derived classes to override the method.
    // So, abstract methods have no actual code in them, and subclasses HAVE TO override the method.
    // Virtual methods can have code, which is usually a default implementation of something, 
    // and any subclasses CAN override the method using the override modifier and provide a custom implementation.

    public abstract class E
    {
        public abstract void AbstractMethod(int i);

        public virtual void VirtualMethod(int i)
        {
            // Default implementation which can be overridden by subclasses.
        }
    }

    public class D : E
    {
        public override void AbstractMethod(int i)
        {
            // You HAVE to override this method
        }
        public override void VirtualMethod(int i)
        {
            // You are allowed to override this method.
        }
    }

    class AbstractClass
    {
        // Abstract Method
        // Abstract Method resides in abstract class and it has no body.
        // Abstract Method must be overridden in non-abstract child class.
        // Virtual Method
        // Virtual Method can reside in abstract and non-abstract class.
        // It is not necessary to override virtual method in derived but it can be.
        // Virtual method must have body ....can be overridden by "override keyword".....

        static void MainEx()
        {
            Dog dog = new Dog();
            Console.WriteLine(dog.VirtDescribe());
            Console.ReadKey();

            // this will throw an error
            //FourLeggedAnimal someAnimal = new FourLeggedAnimal();
        }

        abstract class FourLeggedAnimal
        {
            // virtual may or may not ve implemented
            // allow for it to be overridden in a derived class."
            public virtual string VirtDescribe()
            {
                return "This animal has four legs.";
            }

            //  abstract method is an obligation to implement that very method in all subclasses.
            public abstract string AbsDescribe();
        }

        class WhiteDog : FourLeggedAnimal
        {
            public override string VirtDescribe()
            {
                return "This four legged animal is a Dog!";
            }
            public override string AbsDescribe()
            {
                return "I'm a dog!";
            }
        }

        class Dog : FourLeggedAnimal
        {
            public override string VirtDescribe()
            {
                string result = base.VirtDescribe();
                result += " In fact, it's a dog!";
                return result;
            }
            public override string AbsDescribe()
            {
                return "I'm a dog!";
            }
        }

        class Cat : FourLeggedAnimal
        {
            // virtual does not have to be overriden

            public override string AbsDescribe()
            {
                return "I'm a cat!";
            }
        }
    }
}
