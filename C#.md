# C#

## Quickfix Formatting in VSCode:  Shift Alt F

Or command Panel (Ctrl shift P) Format Document"

Console. --> for .Net console
Console.WriteLine()--> writes text + \n
Console.Write() --> writes text
lorem ipsum --> string
# Data type names

'a' --> char, one character
123 --> auto Int
1.25 --> auto double (genauer bei mehr nachkommastellen wie float)
1.25f --> float f- literal suffix
1.25m--> decimal (noch genauer als double, ideal fuer Mathe)
true/false bools
# declare vars

Var declarienen --> Var namen keine Sonderzeichen bsp 
      int lala:
      bool LULU
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
==
string firstName = "Bob";
Console.WriteLine(firstName);
# Implicitly declare local vars

implicitly typed local variable is created by using the"var"keyword followed by a variable initialization eg
var message = "Hello world!";
# strings

escape characters \n \t like python
" can be printed with a \ in front \" -> "
For printing \ eg in path \\ -> \
@"string + whitespaces" no vars, named: Verbatim string literal
\u for Unicode UTF-16 chars
## String concatenation

Var1 + var2 = Var1var2 
string name= "Luna";
string message= "Hi";
var Info= message + " " +name;
Console.WriteLine (Info);

string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);

## string interpolation
like f-strings in python with $ for f, also curleys for vars
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");

can be combined with verbatim eg

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");
# Math operations

As in python 
Except var of a type can only hold that type and even when var is declared decimal (m) at least one of the numbers needs to be declared too
decimal decimalQuotient = 7.0m / 5;
Modulus operator shows what remains after the comma in devision
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}"); -> 0
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}"); -> 2
Often used in big loops when update is provided after eg every 100 runs (every time the result is 0)
## Order of operations 

In math, PEMDAS is an acronym that helps students remember the order of operations. The order is:
1. Parentheses (whatever is inside the parenthesis is performed first)
2. Exponents ( not in C# since ^ doesn"t exist as operator)
3. Multiplication and"Division (from left to right)
4. Addition and"Subtraction (from left to right)
## compound assignment"operators

Adding and assning values withn +=,"-=,"*=
var += 5;
++ increments by 1
int var=5;
var++; -> 6
-- Decrements by 1
int var=5;
var--; -> 4

int value = 1;
value++;
Console.WriteLine($"Second: {value++}"); -> 2 because its incremented after its printed
Console.WriteLine("Third: " + value); -> 3 because oft he increment in the line before
Console.WriteLine("Fourth: " + (++value)); -> 4 because it was incr4emented before it was printed

# Writing in VSCode

The C# dev kit .net tool are needed for writing in C# SDK is needed for compiling and executing.
.Net is a opensource platform that has C# language, tools, packages etc.
## New project: 

dotnet new console -o ./CsharpProjects/TestProject
run code : dotnet run
build project with all librarys and stuff dotnet build

".NET Runtime, which hosts and manages your code as it executes on the end user's computer
## Calling classes

1 write class eg "Console" member access operator "." Then methode name and methode invocation operator () then specify arguments
### Stateful versus stateless methods

Current state of application is the collection of all values currently stored in Memory. Some methodes are independent of this state, they work without refferencingt or chaning stored Values, Stateless Merthodes == static methodes example: Console.WriteLine() 
Sateful methodes are built in a way that depends on values stored in Memory, updates them or stores new ones. Sataeful Methodes == instance methodes. These methods keep track of their state in"fields, which are variables defined on the class. Each new instance of the class gets its own copy of those fields in which to store state, when you need to call stateful methods, you must first create an"instance"of the class so that the method can access state.
### Creating an instance of a class

An instance of a class is called an"object. New instances are created with the new operator
Random dice = new Random();
A New  object of the type Random  is created in memory and its memory address is stored in dice it is created by the Random() function
The newest Runtime allows for the shorter target-typed constructor invocation, always need to use () on taget-typed new()
Random dice = new();

How to know which to use : you can attempt to access the method directly from the class itself. If it works, you know that it's a stateless method

Void methodes: end silently, don"t return as value

'parameter' refers to the variable that's being used inside the method. An 'argument' is the value that's passed when the method is called

An"overloaded method"is defined with multiple method signatures. Overloaded methods provide different ways to call the method or provide different types of data.

# Should autocomplete / intellisense not work 

1. Ctrl + Shift + p
2. Write " OmniSharp: Select Project " and press Enter.
3. Choose either add existing or create new.
# Decision logic

If (var operator limit)
{
	Whatever;
}
Else
{
	NOT Whatever;
}
operators
==, the "equals" operator, to test for equality
>, the "greater than" operator, to test that the value on the left is greater than the value on the right
<, the "less than" operator, to test that the value on the left is less than the value on the right
>=, the "greater than or equal to" operator
<=, the "less than or equal to" operator
|| logical OR
&& logical AND

Code block: defined by opening and closdsing curley barcets
# Arrays

## One-dimensional Array 

Collection of elements in one variable accessible through zero based index, ordered, set lenght
Bsp
string[] fraudulentOrderIDs = new string[3]; 
for the Variable name of the type string an empty Array is created and a string with 3 elements is created using the new operator

also
string[] fraudIDs=[ "A123", "B456", "C789" ];

## rectangular Array (Multidimensional)

int[,] Array1 = new int[3,2] -> 3 Number of Rows, 2 Number of Columns
{
" "{1,2},
" "{3,4},
" "{5,6}
};
To access it Array[row,column], Array1[2,0] -> 5
it has a fixed size where all rows have the same amount of columns. The elements are stored continuously in the memory .

## Jagged Arrays (multidimensional)

In A Jagged Array each row can have sub-array or different number of elements. The sub-arrays are stored independently in memory

int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[] { 1, 2 };
jaggedArray[1] = new int[] { 3, 4, 5 };
jaggedArray[2] = new int[] { 6 };
To access it Array[row][column], Array1[2][0] -> 3
# foreach loop

cant be used for multidimensional structures like nested array if the second dimesion is also an array because it would see the contains as strings not a structured array. (for loop works). In a Jagged Array this wouldn"t be 
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string idx in names)
{
    Console.WriteLine(idx);
}
# Naming conventions local Vars

Rules
Alphanumerics and underscore, no special chars like #-$
Must begin with underscore or letter not number ( _is usually for private instance fields)
Must not be a class or methodename or type
Casesensitive
Conventions
Should use Camel case like string thisIsCamelCase;
Descriptive and meaningful
Use entire words 
Shouldn"t include data types
* Use PascalCase for class names and method names.
* Use camelCase for method parameters and local variables.
* Use PascalCase for constant names, both fields and local constants.
# Decision logic

An Expression is any mix of value operator and return methods. Statements are composed of one or more expression and are complete instructions
== equal 	!= not equal
## Logical negation

Console.WriteLine(!Var.Contains("String"));

Toupper() ToLower() 	Trim() removing leading or trailing spaces
Console.WriteLine(Var.Contains("String") == false); if String in Var output: false

## Conditional operator 

<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
With examples:
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

# Variable Scope

A locally scoped variable is only accessible inside of the code block in which it's defined.
# Formatting convention for if statments

* Never use single-line form (for example: if (flag) Console.WriteLine(flag);
* Using braces is always accepted, and required if any block of an if/else if/.../else compound statement uses braces or if a single statement body spans multiple lines.
* Braces may be omitted only if the body of every block associated with an if/else if/.../else compound statement is placed on a single line.
# Switch-case

The"switch"statement chooses one section of code to execute from a list of possible switch sections. The selected"switch section"is chosen based on a pattern match with the statement's match expression.
Best used when
* You have a single value (variable or expression) that you want to match against many possible values.
* For any given match, you need to execute a couple of lines of code at most.

switch (fruit)
{
    case "apple":
    case "Apple":
        Console.WriteLine($"App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;

     default:
        Console.WriteLine($"We don"t have Information on this fruit.");
}
Only ever one switch statement can be executed, without the break keyword a compiler error occurs 

# Loops overview

The"for"statement iterates through a code block a specific number of times. This level of control makes the"for"statement unique among the other iteration statements. The"foreach"statement iterates through a block of code once for each item in a sequence of data like an array or collection. The"while"statement iterates through a block of code until a condition is met.

for (int i = 0; i < 10; i++)
{
" " Console.WriteLine(i);
}
1. Part defines and initialises iterator Variable  (Initialiser) 2.part condition for completion 3, part the iterator is the codeblock executed each iteration
More examples
Iterating backwards
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
Same forwards 
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
{
" " Console.WriteLine(names[i]);
}
Renaming stuff during iteration
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);
# What is/are data/Datatypes?

Data is A value strored in the memory in a series of bits. A data type is a way a programming language defines how much memory to save for a value."Variables of reference types store references to their data (objects), that is they point to data values stored somewhere else. In comparison, variables of value types directly contain their data."A value type variable stores its values directly in an area of storage called the"stack. The stack is memory allocated to the code that is currently running on the CPU (also known as the stack frame, or activation frame). When the stack frame has finished executing, the values in the stack are removed. A reference type variable stores its values in a separate memory region called the"heap, "a memory area that is shared across many applications. The .NET Runtime communicates with the operating system to determine what memory addresses are available, The .NET Runtime stores the value, and then returns the memory address to the variable

## Int Types

For integer types there are two sub types signed type uses its bytes to represent an equal number of positive and negative numbers.
sbyte  : -128 to 127
short  : -32768 to 32767
int    : -2147483648 to 2147483647
long   : -9223372036854775808 to 9223372036854775807

An"unsigned type"uses its bytes to represent only positive numbers. The remainder of the exercise introduces the unsigned integral types in C#.
Unsigned integral types:
byte   : 0 to 255
ushort : 0 to 65535
uint   : 0 to 4294967295
ulong  : 0 to 18446744073709551615

## float types 

They variate in precision (digits after the decimal point) and the way theren stored in memory flat and double are stored in a binary format decimal in a decimal(base 10) format, which makes the first two more of an approximation of the real Value, there good because they use a small amount of memory but only when being a few thousandths"of is no problem. Anything accurate should be decimal.
Floating point types:
float  : -3,4028235E+38 to 3,4028235E+38 (with ~6-9 digits of precision)
double : -1,7976931348623157E+308 to 1,7976931348623157E+308 (with ~15-17 digits of precision)
decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precision)

## reference types

Reference types include arrays, classes, and strings.



int val_A = 2;
int val_B = val_A;
val_B = 5;
--> A: 2, B: 5

int[] ref_A= new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;
A:5, B:5

When"ref_B = ref_A"is executed,"ref_B"points to the same memory location as"ref_A. So, when"ref_B[0]"is changed,"ref_A[0]"also changes because they both point to the same memory location. This is a key difference between value types and reference types.

Easiest use in the beginning int decimal bool string
then
byte: working with encoded data that comes from other computer systems or using different character sets.
double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
System.DateTime for a specific date and time value.
System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.

# While and do-while Loops

Do-while statements executes while a specified Term stays True, the expression is evaluated after the executions so there is one more execution after the Term turns False
do
{
    // This code executes at least one time
} while (true);
"code block that influences the exit criteria is a primary reason to select a"do-while"or"while"statements rather than one of the other iteration statements. In a do-while the loop will iterate at least once.

Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

While Loop
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

The for statement: executes its body while a specified Boolean expression (the 'condition') evaluates to true.
The foreach statement: enumerates the elements of a collection and executes its body for each element of the collection.
The do-while statement: conditionally executes its body one or more times.
The while statement: conditionally executes its body zero or more times.
