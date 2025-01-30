public class MyClass {
    public int MyProperty { get; set; } = 0; // Initialize MyProperty

    public MyClass() { // Initialize in constructor
        MyProperty = 10;
    }
    public void MyMethod() {
        Console.WriteLine(MyProperty); // Accessing MyProperty after initialization 
    }
}