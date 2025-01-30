public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing MyProperty before it's initialized can lead to unexpected behavior.
        Console.WriteLine(MyProperty); 
    }
}