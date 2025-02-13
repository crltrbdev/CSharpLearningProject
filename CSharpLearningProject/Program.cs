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
// SampleFunction(carlo);

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

// int addition = AddTwoNumbers(userNumber1, userNumber2);
// Console.WriteLine("The addition is " + addition);
//
// int multiplication = MultiplyTwoNumbers(userNumber1, userNumber2);
// Console.WriteLine("The multiplication is " + multiplication);
//
// int division = DivideTwoNumbers(userNumber1, userNumber2);
// Console.WriteLine("The division is " + division);
//
// int division2 = DivideTwoNumbers(userNumber2, userNumber1);
// Console.WriteLine("The 2nd division is " + division2);

// for (int i = 0; i < 25; i++)
// {
//     AddTwoNumbers(10, i);
// }

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

// SampleFunction(carlo);
EjemploVariosTipos("Carlo", 10);

void EjemploVariosTipos(string stringParam, int intParam)
{
    Console.WriteLine("Hello " + stringParam + ". The Number is: " + intParam);
}

// una funcion void que reciba tres parametros
// 1: string nombre1
// 2: string nombre2
// 3: int years

/*
 
 EjemploVariosTipos("Carlo", 10); <-- Mandar llamar, haz lo que esta definido adentro de tu scope
 trestipos ( "Kevin" , "Iovanna", 23 );
 */
trestipos ( "Kevin" , "Iovanna", 23 );
void trestipos(string nombre1, string nombre2, int years)
{
    // Console: nombre1 + " y " + nombre2 + " llevan " + years + " juntos"
    Console.WriteLine(nombre1 + " y " + nombre2 + " llevan " + years + " juntos");
    //  
    // siguiente: Kevin y Iovanna llevan 24 juntos
}

int totalIntroduction = AddOrSubtract(10, 20, false);
Console.WriteLine("Total Introduction: " + totalIntroduction);

// MultiplyOrDivide

int totalMultiplyorDivide = MultiplyOrDivide(50, 100, false);
Console.WriteLine ("Total Multiplication is: " +totalMultiplyorDivide);
int MultiplyOrDivide(int a, int b, bool isMultiply)
{
    int total = 0;
    
    // condition statements - flow control

    if (isMultiply == true)
    {
        total = a * b;
    }
    else if (isMultiply == false)
    {
        total = a / b;
    }
    
    return total;
}

/* TAREA 12 FEB -
 * #1
 * funcion que reciba 3 parametros
 * string nombreA
 * string nombreB
 * bool imprimirPrimerNombre
 *
 * si imprimirPrimerNombre == true regresar nombreA, sino regresar nombreB
 *
 * #2
 *
 * int numero = 1 + 1;
 *
 * int number = 1 + 5;
 * Console.WriteLine("Number is: " + number); // 6
 *
 * bool isTest = true && true; // isTest == true
 *
 * Boolean Arithmetic - Tarea - Leer sobre esto
 *
 * true && true = true
 * false && false = false
 * true || true = true
 * false || false = false
 * true && false = false
 * true || false = true
 * false && true = false
 * false || true = true
 *
 * true == false = false
 * true == true = true
 * false == false = true
 *
 * !true = false
 * !false = true
 * 
 * && (AND), || (OR), == (COMPARE), ! (NOT)
 *
 * bool isKevin = true;
 * bool isLate = false;
 *
 * if(isKevin && !isLate)
 * {
 *      OpenDoor
 * }
 *
 * if(!isKevin && isLate)
 * {
 *      Don't open door
 * }
 *
 * if(!isKevin && !isNotLate)
 * {
 *  OpenDoor
 * }
 * 
 * 
 */



int AddOrSubtract(int a, int b, bool isAddition)
{
    int total = 0;
    
    // condition statements - flow control

    if (isAddition == true)
    {
        total = a + b;
    }
    else if (isAddition == false)
    {
        total = a - b;
    }
    
    return total;
}


// int SayHiOrSayBye(bool sayHi, bool sayBye, string name, int byeCount)
// {

// }  

//
// Lesson #4: Conditions 
//

// IDE Overview -> Panels

//
// Bonus Lesson: Unity Code-Along
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

//
// Bonus
//


// type int, string, float // primitivos

int numero = 10;
string nombre = "Kevin";

// tipo nombre = valor

// Ejemplo kaiwenEjemplo = new Ejemplo();
// kaiwenEjemplo.Numero = 10;
// kaiwenEjemplo.Nombre = "Kaiwen";
// kaiwenEjemplo.DiAlgoXVeces("Otra cosa", 3);
//
// Ejemplo carloEjemplo = new Ejemplo();
// carloEjemplo.Numero = 20;
// carloEjemplo.Nombre = "Carlo";
// carloEjemplo.DiAlgoXVeces("Carlo Habla", 10);
//
// Ejemplo paco = new Ejemplo();
// paco.Numero = 20;
// paco.Nombre = "Carlo";
// paco.DiAlgoXVeces("Paco Sobaco", 10);

// Car defenseCar = new Car("Carro Defensa", 100);
// defenseCar.PrintHealth();
//
// Car attackCar = new Car("Carro de Ataque", 25);
// attackCar.TakeDamage(10);
// attackCar.PrintHealth();
//
// attackCar.Render();
// attackCar.UpdateFromUnityExample();

class UnityClass
{
    public void Render()
    {
        Console.WriteLine("Render from UnityClass");
    }
    
    public virtual void UpdateFromUnityExample()
    {
        Console.WriteLine("Update from UnityClass");
    }
}

class Car : UnityClass
{
    public string Name;
    public int Health;
    public int Speed;
    
    public Car(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void PedalToTheMetal(int steering, int acceleration)
    {
        Speed = steering + acceleration * acceleration - 1;

    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
    
    public void PrintHealth()
    {
        Console.WriteLine($"{Name} Health: {Health}");
    }
}

class Ejemplo
{
    public int Numero;
    public string Nombre;

    public void DiAlgoXVeces(string queDigo, int cuantasVeces)
    {
        Console.WriteLine($"Quien esta diciendo algo: {Nombre}");
        
        for (int i = 0; i < cuantasVeces; i++)
        {
            Console.WriteLine($"Diciendo: {queDigo} #{i}");
        }
    }
}