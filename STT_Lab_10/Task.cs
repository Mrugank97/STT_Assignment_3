//TASK 2
//class Calculator
//{
//    static void Main()
//    {
//        Console.WriteLine("Simple C# Calculator");

//        // Accepting user input for two numbers
//        Console.Write("Enter first number: ");
//        int num1 = int.Parse(Console.ReadLine());

//        Console.Write("Enter second number: ");
//        int num2 = int.Parse(Console.ReadLine());

//        // Performing arithmetic operations
//        int sum = num1 + num2;
//        int difference = num1 - num2;
//        int product = num1 * num2;
//        double quotient = num2 != 0 ? (double)num1 / num2 : double.NaN; // Handling division by zero

//        // Checking if the sum is even or odd
//        string evenOrOdd = (sum % 2 == 0) ? "even" : "odd";

//        // Displaying results
//        Console.WriteLine($"\nResults:");
//        Console.WriteLine($"Addition: {num1} + {num2} = {sum}");
//        Console.WriteLine($"Subtraction: {num1} - {num2} = {difference}");
//        Console.WriteLine($"Multiplication: {num1} * {num2} = {product}");
//        Console.WriteLine(num2 != 0 ? $"Division: {num1} / {num2} = {quotient:F2}" : "Division by zero is not allowed.");
//        Console.WriteLine($"The sum {sum} is {evenOrOdd}.");

//        Console.WriteLine("\nPress any key to exit...");
//        Console.ReadKey();
//    }
//}

//---------------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------------

//Task 3
using System;
class Program
{
    static void Main()
    {
        // 1. Using a for loop to print numbers from 1 to 10
        Console.WriteLine("Numbers from 1 to 10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        // 2. Using a while loop to accept user input until "exit" is entered
        Console.WriteLine("Enter text (type 'exit' to stop):");
        string userInput;
        while (true)
        {
            Console.Write("Input: ");
            userInput = Console.ReadLine();
            if (userInput.ToLower() == "exit")
                break;
        }
        Console.WriteLine("Exited the loop.\n");

        // 3. Calling a function to compute factorial
        Console.Write("Enter a number to calculate its factorial: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.Write("Invalid input. Enter a non-negative integer: ");
        }

        long factorial = CalculateFactorial(number);
        Console.WriteLine($"Factorial of {number} is {factorial}");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // Function to calculate factorial
    static long CalculateFactorial(int n)
    {
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}

//---------------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------------


// Task 4
//using System;
//class Student
//{
//    // Properties
//    public string Name { get; set; }
//    public int ID { get; set; }
//    public double Marks { get; set; }

//    // Default Constructor (Overloaded)
//    public Student()
//    {
//        Name = "Unknown";
//        ID = 0;
//        Marks = 0.0;
//    }

//    // Parameterized Constructor (Overloaded)
//    public Student(string name, int id, double marks)
//    {
//        Name = name;
//        ID = id;
//        Marks = marks;
//    }

//    // Copy Constructor
//    public Student(Student existingStudent)
//    {
//        Name = existingStudent.Name;
//        ID = existingStudent.ID;
//        Marks = existingStudent.Marks;
//    }

//    // Method to determine grade based on marks
//    public string GetGrade()
//    {
//        if (Marks >= 90) return "A";
//        else if (Marks >= 75) return "B";
//        else if (Marks >= 60) return "C";
//        else if (Marks >= 50) return "D";
//        else return "F";
//    }

//    // Method to display student details
//    public void DisplayStudentDetails()
//    {
//        Console.WriteLine($"\nStudent Details:\nName: {Name}\nID: {ID}\nMarks: {Marks}\nGrade: {GetGrade()}");
//    }
//}

//// Subclass of Student
//class StudentIITGN : Student
//{
//    public string Hostel_Name_IITGN { get; set; }

//    // Constructor Overloading in Derived Class
//    public StudentIITGN(string name, int id, double marks, string hostelName)
//        : base(name, id, marks)
//    {
//        Hostel_Name_IITGN = hostelName;
//    }

//    // Copy Constructor in Derived Class
//    public StudentIITGN(StudentIITGN existingIITGNStudent)
//        : base(existingIITGNStudent)  // Call base class copy constructor
//    {
//        Hostel_Name_IITGN = existingIITGNStudent.Hostel_Name_IITGN;
//    }

//    // Method to display IITGN student details
//    public void DisplayIITGNStudentDetails()
//    {
//        DisplayStudentDetails(); // Call base class method
//        Console.WriteLine($"Hostel Name: {Hostel_Name_IITGN}");
//    }
//}

//// Main Program to Test
//class Program
//{
//    static void Main()
//    {
//        // Using Parameterized Constructor
//        Student student1 = new Student("Alice", 101, 85.5);
//        student1.DisplayStudentDetails();

//        Console.WriteLine("\n---------------------------\n");

//        // Using Copy Constructor
//        Student student2 = new Student(student1);
//        student2.DisplayStudentDetails();

//        Console.WriteLine("\n---------------------------\n");

//        // Using Default Constructor
//        Student student3 = new Student();
//        student3.DisplayStudentDetails();

//        Console.WriteLine("\n---------------------------\n");

//        // Using StudentIITGN Constructor
//        StudentIITGN iitgnStudent = new StudentIITGN("Bob", 102, 92, "Satpura Hostel");
//        iitgnStudent.DisplayIITGNStudentDetails();

//        Console.WriteLine("\n---------------------------\n");

//        // Using StudentIITGN Copy Constructor
//        StudentIITGN copiedIITGNStudent = new StudentIITGN(iitgnStudent);
//        copiedIITGNStudent.DisplayIITGNStudentDetails();

//        Console.WriteLine("\nPress any key to exit...");
//        Console.ReadKey();
//    }
//}



//---------------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------------

//Task 5
//using System;
//class Calculator
//{
//    static void Main()
//    {
//        Console.WriteLine("Simple C# Calculator");

//        int num1, num2;

//        // Accepting user input with error handling
//        num1 = GetValidNumber("Enter first number: ");
//        num2 = GetValidNumber("Enter second number: ");

//        // Performing arithmetic operations
//        int sum = num1 + num2;
//        int difference = num1 - num2;
//        int product = num1 * num2;
//        double quotient = 0;

//        // Handling division inside try-catch
//        try
//        {
//            quotient = (double)num1 / num2;
//        }
//        catch (DivideByZeroException)
//        {
//            Console.WriteLine("Error: Division by zero is not allowed.");
//        }

//        // Checking if the sum is even or odd
//        string evenOrOdd = (sum % 2 == 0) ? "even" : "odd";

//        // Displaying results
//        Console.WriteLine("\nResults:");
//        Console.WriteLine($"Addition: {num1} + {num2} = {sum}");
//        Console.WriteLine($"Subtraction: {num1} - {num2} = {difference}");
//        Console.WriteLine($"Multiplication: {num1} * {num2} = {product}");

//        if (num2 != 0)
//            Console.WriteLine($"Division: {num1} / {num2} = {quotient:F2}");
//        else
//            Console.WriteLine("Division by zero is not allowed.");

//        Console.WriteLine($"The sum {sum} is {evenOrOdd}.");

//        Console.WriteLine("\nPress any key to exit...");
//        Console.ReadKey();
//    }

//    // Method to get valid integer input
//    static int GetValidNumber(string prompt)
//    {
//        int number;
//        while (true)
//        {
//            Console.Write(prompt);
//            string input = Console.ReadLine();

//            try
//            {
//                number = int.Parse(input);
//                break;  // Exit loop if input is valid
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Invalid input! Please enter a valid integer.");
//            }
//            catch (OverflowException)
//            {
//                Console.WriteLine("Number is too large! Please enter a valid integer.");
//            }
//        }
//        return number;
//    }
//}
