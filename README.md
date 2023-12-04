# C#_learning
studying and Learning C#  and putting on github


## C# Basics and Syntax:
### Basic Structure:
in C#, a basic program structure consists of a "namespace", a 'class', and the "Main" method
```csharp
namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main program logic
        }
    }
}
```

## Variables and Data Types:
## Variables are declared with a specific data type, Common data types includes:
```csharp
int age = 25;
double price = 19.99;
string name = "John";
char grade = 'A';
bool isStudent = true;
```

## User Input :
## To take user input, use the "Console.Readline();" method and convert it to the desired data type:
```csharp
Console.Write("Enter your age: ");
int userAge = Convert.ToInt32(Console.ReadLine());
or
int userage = int.Parse(Console.Readline());
```

### Object-Oriented Programming (OOP):
## Classes and objects:
```csharp
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

Person person1 = new Person();
person1.Name = "Alice";
person1.Age = 30;
```

### Encapsulation:
```csharp
public class BankAccount
{
    private double balance;

    public void Deposit(double amount)
    {
        // Deposit logic
    }

    public void Withdraw(double amount)
    {
        // Withdraw logic
    }
}
```
### Inheritance:
```csharp
public class Animal
{
    public void Eat()
    {
        // Eating logic
    }

    public void Sleep(){
  
    }
}
public class Dog : Animal
{
    public void Eat()
    {
        Console.Writeline("The dog is eating");
    }
    public void Sleep(){
    Console.Writeline("The dog is sleeping");
  }
}
```
### Polymorphism:
```csharp
public class Shape
{
    public virtual void Draw()
    {
        // Drawing logic
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        // Circle drawing logic
    }
}

public class Square : Shape
{
    public override void Draw()
    {
        // Square drawing logic
    }
}
```
# Arrays (Vetores) in C#

## Basic Arrays

#### Arrays in C# are similar to lists in Python. You declare an array by specifying the type of its elements, followed by the array name and its size.

```csharp
double[] array = new double[<size>];

double[] numbers = new double[5];
numbers[0] = 1.0;
numbers[1] = 2.5;
```
## Array of Objects:
#### When creating arrays of objects, the class must have the necessary properties
```csharp
Example: Product Class

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Product[] products = new Product[<size>];
        products[0] = new Product { Name = "Item1", Price = 10.99 };
        products[1] = new Product { Name = "Item2", Price = 5.99 };
        // ... (assign values to other indices)

        // Accessing properties of objects in the array
        Console.WriteLine(products[0].Name);
        Console.WriteLine(products[1].Price);
    }
}
```

# Advanced Concepts:
## Null Coalescing Operator

The null coalescing operator (`??`) is a shorthand notation and a substitute for the `Nullable` class with the `?` operator appended to the variable type. For example:

### Using Nullable class:

```csharp
Nullable<double> x = null;
double result = x.GetValueOrDefault();
bool hasValue = x.HasValue;
double value = x.Value; // Throws an exception if there is no value
```
### Using Null Coalescing Operator:
```csharp
double? x = null;
double result = x ?? 0.0; // If x has a value, use it; otherwise, use 0.0
bool hasValue = x.HasValue;
double value = x.Value; // Throws an exception if there is no value

In the second example, double? signifies a nullable double, allowing the variable x to either hold a valid double value or be null.
The ?? operator is used to provide a default value (0.0 in this case) if x is null.
The other methods (HasValue and Value) operate similarly to the Nullable class, indicating whether there is a value and fetching the value, respectively
```
# Params
## C# `params` Keyword - Similar to Python **kwargs

In C#, the `params` keyword allows a method to accept a variable number of parameters. It is similar to the `**kwargs` feature in Python. This feature provides flexibility by allowing the caller to pass any number of arguments of a specific type to the method.

## Example: Sum Method

Consider a `Calculator` class with a `Sum` method that takes multiple integer parameters:

```csharp
public class Calculator
{
    public static int Sum(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}
```
In this example, the params keyword is used to specify that the Sum method can accept a variable number of integer parameters. The method then iterates over the provided integers and calculates their sum.

#### Usage of Sum Method:
```csharp
class Program
{
    static void Main(string[] args)
    {
        // Using the Sum method with different numbers of parameters
        int result1 = Calculator.Sum(1, 2, 3, 4, 5);
        int result2 = Calculator.Sum(10, 20, 30);

        Console.WriteLine("Result 1: " + result1); // Output: Result 1: 15
        Console.WriteLine("Result 2: " + result2); // Output: Result 2: 60
    }
}

```



