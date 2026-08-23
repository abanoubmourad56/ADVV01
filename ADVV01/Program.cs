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

            //Q5: Write a generic method FindMax<T> that finds maximum value.
            //static T FindMax<T>(T a, T b) where T : IComparable<T>
            //{
            //    return a.CompareTo(b) > 0 ? a : b;
            //}

            //Q6: What is a generic interface? Write IRepository<T>.
            //A generic interface can work with different data types
            //    interface IRepository<T>
            //{
            //    void Add(T item);
            //    T Get(int id);
            //}

            //Q7: What is the struct constraint? Write an example.
            //It means T must be a value type
            //class Test<T> where T : struct
            //{
            //}
    }
    }
}
