public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass myClass)
    {
        return myClass.MyProperty;
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyClass myClass = 5;
        int i = myClass;
        Console.WriteLine(i); //Output: 5

        i = 10;
        myClass = i;
        Console.WriteLine(myClass.MyProperty); // Output: 10

        MyClass myClass2 = new MyClass(20);
        if (myClass2 == 20) //This will produce a compiler error
        {
            Console.WriteLine("Equal");
        }
    }
}