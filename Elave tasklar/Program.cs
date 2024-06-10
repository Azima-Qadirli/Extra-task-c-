

#region Extra task
//1.Write a C# Sharp program to print Hello and your name in a separate line.
//Console.WriteLine("Hello:");
//Console.WriteLine("Azimaxanim");


//2.Write a C# Sharp program to print the sum of two numbers.
//int a = 15;
//int b = 20;
//int sum = a + b;
//Console.WriteLine(sum);


//3.Write a C# Sharp program to print the result of dividing two numbers.
//int a = 15;
//int c = 5;
//int dividing = a / c;
//Console.WriteLine(dividing);

//4.Write a C# Sharp program to print the results of the specified operations.
//int a = 25;
//int b = 5;
//int c = 4;
//int d = 3;
//int sum = a / b + c * d;
//int dividing = a * c / b;
//int multiplied = sum / dividing;
//Console.WriteLine(sum);
//Console.WriteLine(dividing);
//Console.WriteLine(multiplied);

//5.Write a C# Sharp program to swap two numbers.
//int num1, num2,result=0;
//Console.WriteLine("Enter your first number:");
//num1=int.Parse(Console.ReadLine());
//Console.WriteLine("Enter your second number:");
//num2=int.Parse(Console.ReadLine());
//result = num1;
//num1 = num2;
//num2=result;
//Console.WriteLine("After swapping:");
//Console.WriteLine("First number:"+num2);
//Console.WriteLine("Second number:"+num1);

//6.Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
//Console.WriteLine("Enter your first number:");
//int num1=int.Parse(Console.ReadLine());
//Console.WriteLine("Enter your second number:");
//int num2=int.Parse(Console.ReadLine());
//Console.WriteLine("Enter your third number:");
//int num3=int.Parse(Console.ReadLine());
//int multiplication = num1 * num2 * num3;
//Console.WriteLine(multiplication);

//7.Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
//Console.WriteLine("Enter your first number:");
//int num1=int.Parse(Console.ReadLine());
//Console.WriteLine("Enter your second number:");
//int num2=int.Parse(Console.ReadLine());
//int adding = num1 + num2;
//int subtracting = num1 - num2;
//int multiplying = num1 * num2;
//int dividing = num1 / num2;
//Console.WriteLine("Result of adding numbers is " + adding);
//Console.WriteLine("Result of subtracting numbers is " + subtracting);
//Console.WriteLine("Result of multiplying numbers is " + multiplying);
//Console.WriteLine("Result of dividing numbers is " + dividing);

//8.Write a C# Sharp program that prints the multiplication table of a number as input.
//Console.WriteLine("Enter your number:");
//int number = int.Parse(Console.ReadLine());
//Console.WriteLine("Result of the multiplication table of a number is:");
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(number*i);
//}

//9.Write a C# Sharp program that takes four numbers as input to calculate and print the average.
//int num1, num2, num3, num4 = 0;
//Console.WriteLine("Enter your first number:");
//num1=int.Parse(Console.ReadLine());
//Console.WriteLine("Enter your second number:");
//num2 =int.Parse(Console.ReadLine());
//Console.WriteLine("Enter your third number:");
//num3 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter your fourth number:");
//num4 = int.Parse(Console.ReadLine());
//int average = (num1 + num2 + num3 + num4) / 4;
//Console.WriteLine("Result of average number is: "+average);

//10.Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
//int x, y, z = 0;
//Console.WriteLine("Enter first number for x:");
//x=int.Parse(Console.ReadLine());
//Console.WriteLine("Enter second number for y:");
//y=int.Parse(Console.ReadLine());
//Console.WriteLine("Enter third number for z:");
//z=int.Parse(Console.ReadLine());
//Console.WriteLine("First result is: "+(x+y)*z);
//Console.WriteLine("Second result is: "+(x*y+y*z));

//11. Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".
//int age = 0;
//Console.WriteLine("Enter your age:");
//age=int.Parse(Console.ReadLine());
//if (age > 20)
//{
//    Console.WriteLine("You look older than 20.");
//}
//else if (age < 20)
//{
//    Console.WriteLine("You look younger than 20.");
//}
//else
//{
//    Console.WriteLine("You are young person.");
//}

//12.Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}.

//int num = 0;
//Console.WriteLine("Enter your number:");
//num=int.Parse(Console.ReadLine());
//for (int j = 0; j < 2; j++)
//{
//    for (int i = 0; i < 4; i++)
//    {
//        if (i > 0)
//        {
//            Console.Write(" ");
//        }
//        Console.Write(num);
//    }
//    Console.WriteLine();

//    for (int i = 0; i < 4; i++)
//    {
//        Console.Write(num);
//    }
//    Console.WriteLine();
//}

//13.Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.
//int number = 0;
//Console.WriteLine("Enter your number:");
//number = int.Parse(Console.ReadLine());
//Console.WriteLine("Expected output:");
//for (int i = 0; i < 3; i++)
//{
//    Console.Write(number);
//}
//Console.WriteLine();
//for (int j = 0; j < 3; j++)
//{
//    Console.Write(number);
//    for (int k = 0; k < 2; k++)
//    {
//        Console.Write(" ");
//    }
//    Console.WriteLine(number);
//}
//for (int i = 0; i < 3; i++)
//{
//    Console.Write(number);
//}

//14.Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
//int Celsius = 0;
//double Kelvin, Fahrenheit = 0;
//Console.WriteLine("Enter celcius:");
//Celsius=int.Parse(Console.ReadLine());
//Fahrenheit=(9/5)*Celsius+32;
//Kelvin= Celsius + 273.15;
//Console.WriteLine("Result for Kelvin: "+Kelvin);
//Console.WriteLine("Result for Fahrenheit: "+ Fahrenheit);

//15.Write a C# program that removes a specified character from a non-empty string using the index of a character.
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the string:");
//        string str = Console.ReadLine();

//        Console.WriteLine("Enter the index of the character that you want to remove:");
//        if (int.TryParse(Console.ReadLine(), out int index))
//        {
//            if (index >= 0 && index < str.Length)
//            {
//                string result = RemoveSpecifiedCharacter(str, index);
//                Console.WriteLine("Resulting string: " + result);
//            }
//            else
//            {
//                Console.WriteLine("Error: Index is out of range.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Error: Invalid input for index.");
//        }
//    }

//    static string RemoveSpecifiedCharacter(string str, int index)
//    {
//        string result = str.Remove(index, 1);
//        Console.WriteLine("Removed character: " + str[index]);
//        return result;
//    }
//}


//16.Write a C# program to create a new string from a given string where the first and last characters change their positions.

//public class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter your string:");
//        string input = Console.ReadLine();
//        Console.WriteLine(ChangingFirstLastChar(input)); 
//    }

//    static string ChangingFirstLastChar(string str)
//    {
//        char FirstChar = str[0];
//        char LastChar = str[str.Length - 1];
//        int MiddleChar = str[str.Length - 2];
//        return FirstChar.ToString() + MiddleChar.ToString()+LastChar.ToString();
//    }
//}

//17. Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.
//Sample Output:
//Input a string : The quick brown fox jumps over the lazy dog.
//TThe quick brown fox jumps over the lazy dog.T
//string str;
//Console.Write("Enter your string:");
//str= Console.ReadLine();
//if (str.Length>=1)
//{
//    var s = str.Substring(0,1);
//    Console.WriteLine(s+str+s);
//}

//18. Write a C# program to check a pair of integers and return true if one is negative and one is positive.
//Sample Output:
//Input first integer:
//-5
//Input second integer:
//25
//Check if one is negative and one is positive:
//True

//Console.WriteLine("Input first integer:");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Input second integer:");
//int b = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Check if one is negative and one is positive:");
//Console.WriteLine((a < 0 && b > 0 || a > 0 && b < 0)); 
//#endregion

//19. Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum.
//Console.WriteLine("Enter first integer:");
//int a=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter second integer:");
//int b=Convert.ToInt32(Console.ReadLine());
//if(a != b)
//{
//    Console.WriteLine("Sum of them:" +(a+b));
//}
//else
//{
//    Console.WriteLine("Triple of their sum:"+(3*(a+b)));
//}



#endregion

#region ToChangingnumbers

//public class Program
//{
//    static void Main(string[] args)
//    {
//        int a = 3;
//        int b = 5;
//        ChangingNum(ref a, ref b);
//        Console.WriteLine($"After changing number: a={a},b={b}");
//    }
//    static void ChangingNum(ref int a, ref int b)
//    {
//        a = a + b;
//        b = a - b;
//        a = a - b;
//    }
//}


#endregion