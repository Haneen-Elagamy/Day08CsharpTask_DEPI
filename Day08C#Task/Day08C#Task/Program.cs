using Day08C_Task.Abstract;
using Day08C_Task.Interface;
using System;
using System.Drawing;

namespace Day08C_Task
{
    internal class Program
    {
        #region sort
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Sort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j].CompareTo(numbers[j + 1]) == 1)
                    {
                        Swap(ref numbers[j], ref numbers[j + 1]);
                    }
                }
            }
        }
        #endregion

        #region PrintTenShapes
        public static void PrintTenShapes(IShapeSeries shapeSeries)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Shape Area {i}: {shapeSeries.CurrentShapeArea}");
                shapeSeries.GetNextArea();
            }
            shapeSeries.ResetSeries();
        }
        #endregion

        #region SelectionSort
        //Cannot use this function like previous sort method >> the previous one (Sort) 
        //exists in .Net ecosystem>>int>> use CompareTo and we implemented it in shaape class 
        //here I cannot implement it with the same way
        public static void SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int MinIndex = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j]< numbers[MinIndex])
                    {
                        Swap(ref numbers[j], ref numbers[MinIndex]);
                    }
                }
            }
        }
        public static void SelectionSort(Shaape[] shapes)
        {
            for (int i = 0; i < shapes.Length - 1; i++)
            {
                int MinIndex = i;
                for (int j = i + 1; j < shapes.Length; j++)
                {
                    if (shapes[j].Area < shapes[MinIndex].Area)
                    {
                        MinIndex = j;
                    }
                }
                // Swap shapes
                if (MinIndex != i)
                {
                    Shaape temp = shapes[i];
                    shapes[i] = shapes[MinIndex];
                    shapes[MinIndex] = temp;
                }
            }
        }


        #endregion
        static void Main(string[] args)
        {
            #region Part01

            #region problem01
            //IVehicle vehicle01 = new Car();
            //vehicle01.StartEngine();
            //vehicle01.StopEngine();
            //Console.WriteLine();
            //IVehicle vehicle02 = new Bike();
            //vehicle02.StartEngine();
            //vehicle02.StopEngine(); 
            #endregion

            #region problem02
            //Shape shape01=new CircleWithAbstract(5);
            //shape01.Display();
            //Console.WriteLine();
            //Shape shape02=new RectangleWithAbstract(5,8);
            //shape02.Display();

            //Console.WriteLine("--------------------------------------------------");

            //IShape shape03=new CircleWithInterface(5);
            //shape03.Display();
            //Console.WriteLine();
            //IShape shape04=new RectangleWithInterface(5,8);
            //shape04.Display(); 
            #endregion

            #region problem03
            //Product[] products = new Product[]
            //{
            //    new Product(1,"Laptop",25000),
            //    new Product(2,"PC",50000),
            //    new Product(3,"Ipad",15000)
            //};

            //foreach (Product item in products)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //Array.Sort(products);
            //foreach (Product item in products)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region problem04
            //int[] arr01 = { 1, 2, 3 };
            //int[] arr02 = { 4, 5, 6 };
            //arr01 = arr02;//Shallow Copy
            //arr01 = (int[])arr02.Clone(); //Deep copy

            ////making shallow and deep copy for student
            ////intialize using object intializer
            //Student student01 = new Student()
            //{
            //    Id = 1,
            //    Name = "Haneen",
            //    Grade = 98
            //};
            ////intialize using properties
            //Student student02 = new Student();
            //student02.Id = 2;
            //student02.Name = "Sohila";
            //student02.Grade = 99;

            //student01= student02;//shallow copy
            //Console.WriteLine(student01);
            //Console.WriteLine(student02);
            //Console.WriteLine(student01.GetHashCode());//58225482
            //Console.WriteLine(student02.GetHashCode()); //58225482

            //Console.WriteLine();

            //student01=(Student)student02.Clone();//Deep Copy
            //Console.WriteLine(student01);
            //Console.WriteLine(student02);
            //Console.WriteLine(student01.GetHashCode());//54267293
            //Console.WriteLine(student02.GetHashCode());//58225482 
            #endregion

            #region problem05
            //// using IWalkable interface method
            //IWalkable walkable = new Robot();
            //walkable.Walk();

            ////using its own method
            //Robot robot = new Robot();
            //robot.Walk(); 
            #endregion

            #region problem06
            ////Write a program to demonstrate encapsulation in structs
            //Account account = new Account();
            //account.AccountId =123;
            //account.AccountHolder = "Haneen Elagamy";
            //account.Balance = 55000.5m;

            //account.DisplayAccountDetails(); 
            #endregion

            #region problem07 
            //ILogger logger = new ConsoleLogger();
            //logger.Log(); 
            #endregion

            #region problem08
            ////Write a program to demonstrate constructor overloading
            //Book book = new Book();
            //Console.WriteLine(book);
            //Console.WriteLine();
            //Book book2 = new Book("Harry Potter and the Sorcerer’s Stone");
            //Console.WriteLine(book2);
            //Console.WriteLine();
            //Book book3 = new Book("Moby Dick", "Herman Melville");
            //Console.WriteLine(book3); 
            #endregion

            #region Q01
            //Question: Why is it better to code against an interface rather than a concrete class?
            /*1-Flexibility and Abstraction:
            Interfaces provide a higher level of abstraction, allowing you to define what an object can do without specifying how it does it.
            This makes your code more adaptable to changes.

            2-Decoupling:
            Using interfaces reduces the dependency between different parts of your code.
            This promotes the Dependency Inversion Principle, where higher-level modules depend on abstractions, not implementations.

            3-Ease of Testing:
            You can substitute the actual implementation with mock objects or stubs that implement the same interface during testing.
            This improves unit testing by isolating components.

            4-Supports Multiple Implementations:
            An interface allows for multiple classes to implement the same set of methods.
            You can easily switch between implementations without altering the dependent code.

            5-Enhances Maintainability:
            Changes in the implementation do not affect the code that depends on the interface.
            This simplifies future updates and maintenance.

            6-Enables Polymorphism:
            Coding against an interface enables runtime polymorphism.
            You can write code that works with any class implementing the interface, making it more reusable.
            */
            #endregion

            #region Q02
            //Question: When should you prefer an abstract class over an interface?
            /*1-Shared Implementation
            Use an abstract class when you want to share common code (like methods or fields) among derived classes.
            Abstract classes can include non-abstract methods with default implementations, which reduces code duplication.

            Example: A Shape abstract class with a Display() method that all derived classes inherit.
            2-Single Inheritance
            Abstract classes are preferable when you know the class will only inherit from one base class and does not require multiple inheritance.

            3-Closely Related Objects
            If the classes that derive from the base class are tightly related in their purpose or behavior, an abstract class is a better choice.

            Example: A Vehicle abstract class for Car and Truck.
            4-Evolving Requirements
            Abstract classes are easier to extend as requirements evolve, as you can add new methods without breaking existing derived classes.

            5-Fields and Constructors
            If you need to define fields or provide a constructor to initialize common properties,
            an abstract class is necessary because interfaces cannot have fields or constructors.

            Example: A base class that initializes Name and ID fields for all derived classes.
           6- Enforcing Default Behavior
            When you want to enforce default behavior for some methods while requiring others to be overridden, abstract classes provide this flexibility.

            Example: A Logger class with a default Log() implementation and an abstract WriteLog() method.
            7-Performance
            Abstract classes can offer slightly better performance than interfaces because of their direct inheritance model, 
            which avoids the runtime overhead of interface resolution.

            */
            #endregion

            #region Q03
            //Question: How does implementing IComparable improve flexibility in sorting?
            /*1-Custom Comparison Logic: IComparable allows you to define custom comparison behavior
             * through the CompareTo method.
            2-Integration with Sorting Functions: It is used by .NET sorting methods like Array.Sort() and
            List<T>.Sort(), enabling automatic sorting based on your custom logic.
            3-Reusability: By implementing IComparable, the comparison logic is embedded directly within the 
            class, making it reusable across different parts of the application.
            4-Maintainability: It simplifies and centralizes sorting behavior, making the code easier to maintain and modify.
            5-Consistency: Ensures consistent sorting behavior whenever sorting is required without needing external comparers.*/

            #endregion

            #region Q04
            //Question: What is the primary purpose of a copy constructor in C#?

            /*The primary purpose of a copy constructor in C# is to create a new instance of a class by copying the values of an existing 
             * object. It allows for the initialization of an object with the values of another object of the same class, ensuring that 
             * a deep copy is made when necessary, especially in the case of complex objects or objects containing reference types.

            A copy constructor helps to:

            1. **Create a New Object with the Same Values**: It allows you to copy the state of one object into a new object.
            2. **Prevent Reference Sharing**: By copying the values (or performing a deep copy), you avoid sharing references between objects
            , preventing unintended side effects when modifying one object.
            3. **Ensure Safe Cloning**: It provides a safe way to clone objects, especially when dealing with mutable fields or properties.*/

            #endregion

            #region Q05
            //Question: How does explicit interface implementation help in resolving naming conflicts?

            /*Naming Conflict Scenario:

            A class can implement multiple interfaces that may have methods with the same name.
            Without explicit implementation, the class would need to provide a single method for all interfaces, leading to ambiguity.
            Explicit Implementation Solution:

            Explicit interface implementation allows the class to define separate implementations for each interface, even if the method names are the same.
            The method tied to a specific interface can only be accessed through that interface's reference.
            Benefits:

            Avoid Ambiguity: Provides clear and distinct implementations for methods from different interfaces.
            Encapsulation: Hides interface-specific implementations from the main class API, exposing them only through the respective interface.*/

            #endregion

            #region Q06-1
            //Question: What is the key difference between encapsulation in structs and classes?

            /*The key difference lies in how encapsulation operates in value types (structs) versus reference types (classes):

            Memory Allocation:

            Structs: Encapsulation applies to a value type that is allocated on the stack (or inline within other objects). 
            Changes to a copy of the struct do not affect the original instance.
            Classes: Encapsulation applies to a reference type, which is allocated on the heap. Modifications made via a reference affect the original object.
            Inheritance:

            Structs: Do not support inheritance (cannot derive from other structs or classes). Encapsulation is limited to the struct itself.
            Classes: Support inheritance, allowing encapsulation to extend and evolve through derived classes.
            Immutability:

            Structs: Typically used for small, immutable data structures. Properties and methods are designed to ensure
            encapsulation without unintended side effects due to copying.
            Classes: Designed for larger, mutable objects where encapsulation includes managing state changes over time.
            Default Constructor:

            Structs: Automatically have a default parameterless constructor generated by the compiler, ensuring all fields are initialized
            to their default values. User-defined parameterless constructors are not allowed (pre-C# 10).
            Classes: Allow user-defined default constructors, giving more control over the encapsulation of initialization logic.
            Performance:

            Structs: Encapsulation focuses on lightweight objects to reduce memory overhead and avoid heap allocations.
            Classes: Encapsulation accommodates more complex behaviors, potentially with higher memory overhead due to heap allocations and garbage collection.*/

            #endregion

            #region Q06-2
            //Question: what is abstraction as a guideline, what’s its relation with encapsulation?

            /*Abstraction as a Guideline:
            Definition: Abstraction hides implementation details and exposes only relevant features, focusing on "what to do" rather 
            than "how to do it."
            Relation to Design: It simplifies complex systems, promoting clean interfaces through abstract classes, interfaces,
            or access modifiers.

            Relation to Encapsulation:
            Encapsulation enables abstraction: By restricting access to internal data and bundling it with methods, you can create 
            simplified, abstracted interfaces for users.

            Difference:
            Abstraction focuses on what an object does (design-level).
            Encapsulation focuses on how it protects and implements data (implementation-level).*/
            #endregion

            #region Q07
            //Question: How do default interface implementations affect backward compatibility in C#?

            /*Default interface implementations improve backward compatibility in C# by:
            Adding New Methods Without Breaking Existing Code:

            Interface authors can introduce new methods with default implementations without forcing all existing implementations to modify their code.
            Optional Override:

            Implementing classes can either use the default implementation or override it with their own behavior, offering flexibility.
            Avoiding the Need for Adapter Classes:

            Prior to default implementations, adding methods to an interface required creating new interfaces or adapter classes, which added complexity.
            Maintaining Existing Contracts:

            Existing classes that implement the interface remain functional and unchanged because the default implementation provides a fallback.*/

            #endregion

            #region Q08
            //Question: How does constructor overloading improve class usability?

            /*Providing Multiple Initialization Options:

            Users can initialize objects in different ways based on the provided constructors. For example, they can supply complete or partial data depending on their needs.
            Improving Flexibility:

            By offering multiple constructors, a class can adapt to a variety of scenarios without requiring additional configuration after object creation.
            Simplifying Object Creation:

            Overloaded constructors allow intuitive initialization without relying on separate initialization methods.
            Enhancing Code Readability:

            The intent behind object creation becomes clear when constructors are appropriately designed and named.
            Supporting Default and Custom Values:

            Constructors can include default values while also allowing specific values to be set explicitly.*/

            #endregion
            #endregion

            #region Part02
            #region IShapeSeries
            //IShapeSeries shapeSeries01 = new SquareSeries();
            //Console.WriteLine("Square Series:");
            //PrintTenShapes(shapeSeries01);

            //Console.WriteLine();

            //IShapeSeries shapeSeries02= new CircleSeries();
            //Console.WriteLine("Circle Series:");
            //PrintTenShapes(shapeSeries02); 
            #endregion

            #region Implement Sorting for Shapes
            //Shaape[] shapes = new Shaape[]
            //{
            //    new Shaape("Circle",65.5),
            //    new Shaape("Square",25),
            //    new Shaape("Rectangle",78.3)
            //};

            //foreach (var item in shapes)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //Array.Sort(shapes);
            //foreach (var item in shapes)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region GeometricShape
            //Triangle triangle = new Triangle(3,5);
            //Console.WriteLine($"Triangle perimeter is: {triangle.Perimeter}");//13.44030650891055
            //Console.WriteLine($"Triangle Area is:{triangle.CalculateArea()}");//7.5

            //Rectanglee rectangle = new Rectanglee(5,7);
            //Console.WriteLine($"Rectangle perimeter is: {rectangle.Perimeter}");//24
            //Console.WriteLine($"Rectangle Area is:{rectangle.CalculateArea()}");//35

            #endregion

            #region SelectionSort
            //Shaape[] shapes2 = new Shaape[]
            //{
            //    new Shaape("Circle",65.5),
            //    new Shaape("Square",25),
            //    new Shaape("Rectangle",78.3)
            //};

            //foreach (var item in shapes2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //SelectionSort(shapes2);
            //foreach (var item in shapes2)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region ShapeFactory
            //// Use the factory to create shapes
            //GeometricShape rectangle = ShapeFactory.CreateShape("rectangle", 5, 10);
            //GeometricShape triangle = ShapeFactory.CreateShape("triangle", 4, 8);

            //// Display details
            //Console.WriteLine(rectangle);
            //Console.WriteLine(triangle);

            //// Create another shape dynamically
            //Console.WriteLine("Enter the shape type (rectangle/triangle): ");
            //string shapeType = Console.ReadLine();
            //Console.WriteLine("Enter Dimension 1: ");
            //double dim1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter Dimension 2: ");
            //double dim2 = Convert.ToDouble(Console.ReadLine());

            //try
            //{
            //    GeometricShape customShape = ShapeFactory.CreateShape(shapeType, dim1, dim2);
            //    Console.WriteLine(customShape);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //} 
            #endregion

            #region Q1
            //What we mean by coding against interface rather than class ?
            /* Coding Against Interface Rather Than Class
            Definition: Instead of using specific classes, use interfaces as types for method arguments, variables, or return types.
            Why it's important:
            Flexibility: The code works with any class that implements the interface, not just one specific class.
            Decoupling: Reduces dependencies on concrete implementations, making the code more adaptable to changes.*/

            //and if u get it so What we mean by code against abstraction not concreteness ?
            /*. Coding Against Abstraction, Not Concreteness
            Definition: Use abstract types(interfaces or abstract classes) instead of specific classes.
            Why it's important:
            Flexibility: The code can work with any concrete class that implements the abstraction.
            Maintainability: Changes in concrete classes won't affect the code that uses the abstraction.
            */
            #endregion

            #region Q2
            //3- What is abstraction as a guideline and how we can implement this through what we have studied ?
            /*### **Abstraction as a Guideline**

            - **Definition**: Abstraction is the concept of **hiding the complex details** and showing only the
            essential features of an object or system. It allows focusing on the *what* an object does rather than *how* it does it.
  
            - **Why it matters**:  
              - Simplifies code.
              - Increases maintainability.
              - Helps focus on the core functionalities without worrying about implementation details.

            ### **Implementing Abstraction through What We Have Studied**

            1. **Interfaces**:  
               - **Use interfaces to define general behavior** without specifying the exact implementation.  
               - Example: Instead of focusing on how different shapes calculate their area, we define an interface `ICalculateArea` with a method `CalculateArea()`. Each shape class then implements this method differently.

   
           public interface ICalculateArea
           {
               double CalculateArea();
           }

           public class Circle : ICalculateArea
           {
               public double Radius { get; set; }
               public double CalculateArea() => Math.PI * Radius * Radius;
           }
   

        2. **Abstract Classes**:  
            - **Abstract classes define a blueprint** for other classes, allowing some methods to be defined and others to be abstract (unimplemented).  
            - Example: A base class `Shape` can have a method `CalculateArea()` that is abstract, and each specific shape (e.g., `Circle`, `Rectangle`) provides its own implementation.

   
           public abstract class Shape
           {
               public abstract double CalculateArea();
           }

           public class Rectangle : Shape
           {
               public double Width { get; set; }
               public double Height { get; set; }
               public override double CalculateArea() => Width * Height;
           }
   

            3. **Factory Pattern**:  
               - **Hide object creation details** behind a factory method. This allows creating different shapes without needing to know which concrete class is being instantiated.
               - Example: The `ShapeFactory` class hides the logic for creating `Circle`, `Rectangle`, or other shapes, making the code cleaner and more abstract.

           public class ShapeFactory
           {
               public static Shape CreateShape(string shapeType, double dim1, double dim2)
               {
                   return shapeType.ToLower() switch
                   {
                       "circle" => new Circle { Radius = dim1 },
                       "rectangle" => new Rectangle { Width = dim1, Height = dim2 },
                       _ => throw new ArgumentException("Invalid shape type")
                   };
               }
           } */
            #endregion

            #endregion

            #region Bonus
            //2- what is operator overloading
            /*### **Operator Overloading**

            - **Definition**: Operator overloading is a feature in C# that allows developers to redefine or "overload" the behavior of operators (e.g., `+`, `-`, `*`, `==`) for custom classes or structs. It enables operators to work with objects in a more intuitive way.

            - **Purpose**: To make code more readable and expressive when performing operations on user-defined types.

            ### **How It Works**
            - You define an operator as a static method in your class or struct.
            - The method uses the `operator` keyword and specifies the operator being overloaded.

            ### **Example**
            Consider a class `Point` to represent a 2D point. We can overload the `+` operator to add two `Point` objects:


            public class Point
            {
                public int X { get; set; }
                public int Y { get; set; }

                public Point(int x, int y)
                {
                    X = x;
                    Y = y;
                }

                // Overloading the + operator
                public static Point operator +(Point p1, Point p2)
                {
                    return new Point(p1.X + p2.X, p1.Y + p2.Y);
                }

                public override string ToString()
                {
                    return $"({X}, {Y})";
                }
            }

            ### **Usage**
            Point p1 = new Point(2, 3);
            Point p2 = new Point(4, 5);

            Point result = p1 + p2;

            Console.WriteLine(result); // Outputs: (6, 8)

            ### **Key Points**
            1. **Operators That Can Be Overloaded**: Most operators, including `+`, `-`, `*`, `/`, `==`, and more, can be overloaded. Some, like `&&` and `||`, have specific rules.
   
            2. **Cannot Overload**: Certain operators (e.g., `=` and `sizeof`) cannot be overloaded.

            3. **Use Cases**:
               - Adding or subtracting objects (e.g., `Point`, `ComplexNumber`).
               - Comparing objects with `==` or `!=`.
               - Customizing behavior of operators for domain-specific types.

            4. **Static Requirement**: Overloaded operators must be declared as `static`.

            ### **Benefits**
            - Enhances code readability by making operations on custom types intuitive.
            - Allows you to treat custom objects like built-in types during operations.

            ### **Drawbacks**
            - Misuse can make code harder to understand.
            - Should be implemented sparingly and logically to avoid confusion.*/

            #endregion 

        }
    }
}
