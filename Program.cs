// See https://aka.ms/new-console-template for more information
using System;

class Program{

    static int Remainder(int d, int j){
        return (d % j);
    }
    
    static bool lessThan100(int x, int y){
        int sum = x + y;
        return (sum < 100); 
    }
    
    static void Main(string[] args){
        System.Console.WriteLine("Hello World, This is C#"); // printing Hello World in C# using the console
        System.Console.WriteLine("First Name: Benedict"); // printing first name using console
        System.Console.WriteLine("Last Name: Ogbulachi"); // printing last name using the console
        
    // printing current date and time to console
        DateTime dateTimeToday = DateTime.Now; // using the DateTime constructor and DateTime.Now() property
        Console.WriteLine("The Date and Time now is "+ dateTimeToday); // then printing it to console

        // Console.WriteLine(typeof(dateTimeToday));


    // printing these numbers to console
        Console.WriteLine("1001");
        Console.WriteLine("1");
        Console.WriteLine("101");

    // finding the square roots of numbers using Math.Sqrt() in-built func
        double num = 12345;
        double num2 = 576;
        Console.WriteLine(Math.Sqrt(num));
        Console.WriteLine(Math.Sqrt(num2));
        
    // // Printing age after 10 years after collecting your present age from the console
    //     Console.WriteLine("How old are you?");
    //     // used to accept input from users
    //     string AgeNow = Console.ReadLine(); // this accepts inputs as strings
    //     // converting string to integer
    //     int AgeNowInt = Int32.Parse(AgeNow);

    //     DateTime AgeNowDateTime;

    //     AgeNowDateTime= AgeNowInt;
        
    //     // adding and printing 10 years to the current Age below 
    //     DateTime AgeNow10yrs = AgeNowDateTime.AddYears(10);
    //     Console.WriteLine("Your age in 10 years time will be: " + AgeNow10yrs + " years old");
    //     // Console.WriteLine(type(AgeNow10yrs)
     
    //Arithmetic operations
        int a = 25;
        int b =7;
        decimal c = 25;
        decimal d = 7;
        
        // decimal sum
        decimal sumDec = c + d;
        Console.WriteLine("The sum of the decimal is: " + sumDec);

        // int difference
        int diffInt =  a + b;
        Console.WriteLine("The diff between the integer is: " + diffInt);

        // int product
        int prodInt = a * b;
        Console.WriteLine("The product of the integer is: " + prodInt);

        // decimal quotient
        decimal quotDec = c / d;
        Console.WriteLine("The quotient of the integer is: " + quotDec);

        // integer modulus
        int modInt = a % b;
        Console.WriteLine("The remainder of the integer division is: " + modInt);

    // Assignment operator
        // assigning variables
        int x = 10;

        //declaration of variablee
        int y;

        // assigning y to be x
        y = x;

    // relational operator


    // calling the lessThan100 method
        bool result = lessThan100(22,15);
        bool result2 = lessThan100(83,34);
        bool result3 = lessThan100(3,77);

        Console.WriteLine(result);
        Console.WriteLine(result2);
        Console.WriteLine(result3);

    // Calling the Remainder method from the main method to print the remainder to the console
    Console.WriteLine(Remainder(5,2));
    Console.WriteLine(Remainder(59,22));
    Console.WriteLine(Remainder(51123,112));
    Console.WriteLine(Remainder(2344,567));

    // printing the remainder of the division operator
    Console.WriteLine(" ");
    Console.WriteLine("printing the remainder of the division operator");
    
    Console.WriteLine("enter a number: ");
    int numinput1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("enter a second number: ");
    int numinput2 = Convert.ToInt32(Console.ReadLine());

    int remainder = numinput1 % numinput2;
    Console.WriteLine("The remainder of the division " + numinput1 + " and " + numinput2 + " is: " + remainder);

    }
   
} 
