namespace ADVV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1: What is a generic class? Why use generics?
            //A generic class works with different data types.Generics provide type safety and code reusability.

            //Q2: Write a generic class Container<T> with Add and Get methods.
            //    class Container<T>
            //{
            //    private T value;

            //    public void Add(T item)
            //    {
            //        value = item;
            //    }

            //    public T Get()
            //    {
            //        return value;
            //    }
            //}

            // Q3:What are multiple type parameters? Write Pair<TKey,TValue >.
            //Multiple type parameters mean using more than one generic type.
            //    class Pair<TKey, TValue>
            //{
            //    public TKey Key;
            //    public TValue Value;
            //}

            //Q4: What is a generic method? Write Swap<T> method.
            //A generic method works with different data types.
            //static void Swap<T>(ref T a, ref T b)
            //{
            //    T temp = a;
            //    a = b;
            //    b = temp;
            //}
        }
    }
}
