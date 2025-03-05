using System;
using System.Linq;

namespace CtlLibraryWrapper
{
    public static class ArrayWrapper
    {
        public static ArrayWrapper<T> Create<T>(int length, Func<int, T> creator) where T : IDisposable
        {
            return new ArrayWrapper<T>(length, creator);
        }
    }

    public class ArrayWrapper<T> : IDisposable where T : IDisposable
    {
        public ArrayWrapper(int n, Func<int, T> factoryMethod)
        {
            Size = n;
            Value = factoryMethod(n);
        }

        public int Size { get; }
        public T Value { get; }

        public void Dispose()
        {
            Value.Dispose();
        }

        public U[] GetItems<U>(Func<T, int, U> getItem)
        {
            return Enumerable.Range(0, Size).Select( i => getItem(Value, i)).ToArray();
        }
    }
}
