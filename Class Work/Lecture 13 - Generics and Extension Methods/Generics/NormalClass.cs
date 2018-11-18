using System;

namespace Generics
{
    public class NormalClass
    {
        public void DoSomething<T>(T item) where T : struct // or Stream, IList<T>, IConvertible
        {
            // we can define a local variable of type T
            T tmp = default(T);

            // do something
            Console.WriteLine(item.ToString());
        }

        // a non-generic method (e.g. generaly any other valid members) 
        // can be defined in the same class as well
        public void DoSomethingElse(int a, int b)
        {
            
        }
    }
}
