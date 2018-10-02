using System;

namespace ClassLibraryAssembly
{
    public class AssemblyClass
    {

        public class publicClass
        {
            public static void publicClassFunction()
            {
                Console.WriteLine("publicClassFunction");
            }

        }

        private class privateClass
        {

            public static void privateClassFunction()
            {
                Console.WriteLine("privateClassFunction");
            }
        }

        internal class internalClass
        {
            public static void internalClassFunction()
            {
                Console.WriteLine("internalClassFunction");
            }

        }




        protected class protectedClass
        {
            public static void protectedClassFunction()
            {
                Console.WriteLine("protectedClassFunction");
            }

        }

        protected internal class protectedInternalClass
        {
            public static void protectedInternalClassFunction()
            {
                Console.WriteLine("protectedInternalClassFunction");
            }

        }


    }
}
