using StringFunctions;

class Program
{
    static void Main(string[] args)
    {
        InstanceFunctions instance = new InstanceFunctions("My name is Magda! magda");

        int length = instance.strLength();
        Console.WriteLine("Length: " + length);

        string substring = instance.MySubstring(2, 10);
        Console.WriteLine("MySubstring: " + substring);

        int index = instance.MyIndexOf("magda");
        Console.WriteLine("index of magda is " + index);

        int ind = instance.MyLastIndexOf("magda");
        Console.WriteLine("last index of magda is " + ind);

        string newVal = instance.MyReeplace("magda", "hello");
        Console.WriteLine(newVal);

        string upperVal = instance.MyToUpper();
        Console.WriteLine(upperVal);

        string lowerVal=instance.MyToLower();
        Console.WriteLine(lowerVal);

        string trimmedVal=instance.MyTrim();
        Console.WriteLine(trimmedVal);

        string[] strings = instance.MySplit('*');
        Console.WriteLine(string.Join(", ", strings));

        
        Console.WriteLine(StaticFunctions.Contains("hello world", "world"));

        
        Console.WriteLine(StaticFunctions.StartsWith("hello world", "hello")); 

       
        Console.WriteLine(StaticFunctions.EndsWith("hello world", "world")); 

        
        Console.WriteLine(StaticFunctions.Format("My name is {} and I am {} years old", "John", 25)); 

        
        Console.WriteLine(StaticFunctions.IsNullOrEmpty(""));
        Console.WriteLine(StaticFunctions.IsNullOrEmpty("hello")); 

        
        Console.WriteLine(StaticFunctions.IsNullOrWhiteSpace("   "));  
        Console.WriteLine(StaticFunctions.IsNullOrWhiteSpace("hello")); 

    }
}