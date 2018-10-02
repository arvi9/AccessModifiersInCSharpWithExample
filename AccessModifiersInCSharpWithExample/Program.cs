using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryAssembly;

namespace AccessModifiersInCSharpWithExample
{
     class DerivedClass : AssemblyClass
    {

       static void fun()
        {
            AssemblyClass.protectedClass.protectedClassFunction();
            AssemblyClass.protectedInternalClass.protectedInternalClassFunction();
            AssemblyClass.publicClass.publicClassFunction();

        }

    }

    class A
    {
        private string privateX = "privateX";
        public string publicX = "publicX";
        internal string internalX = "internalX";
        protected string protectedX = "protectedX";
        protected internal string protectedInternalX = "protectedInternalX";

    }

    class B : A 
    {


        void printFun()
        {
            Console.WriteLine(base.publicX);
            Console.WriteLine(base.internalX);
            Console.WriteLine(base.protectedX);
            Console.WriteLine(base.protectedInternalX);
        }
        



    }



    class Program
    {
        static void Main(string[] args)
        {
            AssemblyClass ac = new AssemblyClass();
            DerivedClass dc = new DerivedClass();
            AssemblyClass.publicClass.publicClassFunction();
        }
    }
}
