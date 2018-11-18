using System;

namespace Generics
{
    public class GenericClass<T> where T : class
    {
        private T _item;
        public T AnotherItem { get; set; }

        public GenericClass(T item)
        {
            _item = item;
        }

        public GenericClass()
        {
        }

        public void DoSomething(T item)
        {
            T tmp = item;

            _item = tmp;
        }

        public T DoSomethingElse()
        {
            return _item;
        }
    }
}
