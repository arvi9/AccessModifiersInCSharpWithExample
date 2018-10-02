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
