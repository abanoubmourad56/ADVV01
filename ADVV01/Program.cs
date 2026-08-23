using System.Runtime.Intrinsics.X86;

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

            //Q8: What is the class constraint? Write an example.
            //It means T must be a reference type.
            //    class Test<T> where T : class
            //{
            //}

            //Q9: What is the new() constraint? Write an example.
            //It means T must have a public parameterless constructor.
            //    class Test<T> where T : new()
            //{
            //    T Create()
            //    {
            //        return new T();
            //    }
            //}

            //Q10: What is the interface constraint? Write an example.
            //It means T must implement a specific interface.
            //    class Test<T> where T : IDisposable
            //{
            //}

            //Q11: What is the base class constraint? Write an example.
            //It means T must inherit from a specific class.
            //    class Test<T> where T : BaseClass
            //{
            //}

            //Q12: How do you apply multiple constraints? Write an example.
            //Use multiple constraints after where.
            //    class Test<T> where T : Animal, IDisposable, new()
            //{
            //}

            //Q13: What does the default keyword do in generics?
            //It returns the default value of the generic type T.
            //default(int)    // 0
            //default(string) // null

            //Q14: Write a SafeList<T> that returns default when the index is invalid.


        }
    }
}
