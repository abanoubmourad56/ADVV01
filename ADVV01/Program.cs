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
            //    class SafeList<T>
            //{
            //    private List<T> items = new List<T>();

            //    public void Add(T item)
            //    {
            //        items.Add(item);
            //    }

            //    public T Get(int index)
            //    {
            //        if (index < 0 || index >= items.Count)
            //            return default;

            //        return items[index];
            //    }
            //}

            //Q16: What is contravariance? Explain the in keyword.
            //Contravariance allows a base type to be used where a derived type is expected.
            //The in keyword is used for input types.
            //Action<object> action = obj => Console.WriteLine(obj);
            //Action<string> textAction = action;

            //Q15: What is covariance? Explain the out keyword.
            //Covariance allows a more derived type to be used where a base type is expected.The out keyword is used for output types.
            //IEnumerable<string> names = new List<string>();
            //IEnumerable<object> objects = names;


            //Q17: What is the difference between covariance and contravariance?
            //Covariance(out) → works with derived types.
            //Contravariance(in) → works with base types.

            //Q18: How do static members work in generic types ?
            //Each different type parameter has its own static member.
            //    class Test<T>
            //{
            //    public static int Count;
            //}
            //Test<int>.Count and Test<string>.Count are different values.


            //Q19: How can you inherit from a generic class?
        //    Specify the type when inheriting.
        //        class Animal<T>
        //{
        //}

        //class Dog : Animal<string>
        //{
        //}
    }
    }
}
