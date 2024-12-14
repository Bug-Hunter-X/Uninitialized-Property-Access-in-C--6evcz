public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize with a default value

    public ExampleClass() { MyProperty = 0; }

    public void MyMethod()
    {
        // Accessing a property that has been initialized
        int value = MyProperty; 
    }
}