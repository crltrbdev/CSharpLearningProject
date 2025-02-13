//
// Lesson #1: Print "Hello, World!" & Variables
//

// CAMBIO EJEMPLO

// Variable Types

// char - 'a'
// string - "Hello, Kevin!"
// int - 0
// float - 0.1f
// double, decimal - 0.1
// bool - true, false

// Create a variable

string myName = "Kevin Mulby ";
string carlo = "Carlo";

// calling the HelloWorld function (SampleFunction)
SampleFunction(carlo);

// definition
void SampleFunction(string name)
{
    Console.WriteLine("Hello from function " + name);
}

//
// Lesson #2: Functions to add, subtract, multiply and divide Integers (int)
//

// Function examples
int userNumber1 = 10;
int userNumber2 = 20;

int addition = AddTwoNumbers(userNumber1, userNumber2);
Console.WriteLine("The addition is " + addition);

int multiplication = MultiplyTwoNumbers(userNumber1, userNumber2);
Console.WriteLine("The multiplication is " + multiplication);

int division = DivideTwoNumbers(userNumber1, userNumber2);
Console.WriteLine("The division is " + division);

int division2 = DivideTwoNumbers(userNumber2, userNumber1);
Console.WriteLine("The 2nd division is " + division2);

for (int i = 0; i < 25; i++)
{
    AddTwoNumbers(10, i);
}

int AddTwoNumbers(int n1, int n2)
{
    Console.WriteLine("Adding " + n1 + " + " + n2);
    int total = n1 + n2;
    return total;
}

int MultiplyTwoNumbers(int n1, int n2)
{
    Console.WriteLine("Multiplying " + n1 + " * " + n2);
    int total = n1 * n2;
    return total;
}

int DivideTwoNumbers(int n1, int n2, int multiplier = 3)
{
    Console.WriteLine("Dividing " + n1 + " / " + n2);
    int total = n1 / n2;
    
    return total;
}

//
// Lesson #3: Functions that take other parameter types
//

// IDE Overview -> Panelsa

// int SayHiOrSayBye(bool sayHi, bool sayBye, string name, int byeCount)
// {

// }  

//
// Bonus Lesson: Unity Code-Along
//

//
// Lesson #4: Conditions 
//

//
// Lesson #5: Loops
//

//
// Lesson #6: Arrays
//

//
// Lesson #7: Classes & Access Modifiers
//

//
// Lesson #8: OOP (Inheritance, Encapsulation, Abstraction, Polymorphism)
//

//
// Lesson #9: Interfaces
//

//
// Lesson #10: Language Features
//

//
// Lesson #11: Unity - https://learn.unity.com/course/beginning-3d-game-development
//