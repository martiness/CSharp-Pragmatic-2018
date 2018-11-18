using System;

namespace ExtensionMethods
{
    public static class ObjectExtensions
    {
        public static string DoSomething(this object obj)
        {
            return $"A very complicated { obj.ToString() }";
        }
    }
}
