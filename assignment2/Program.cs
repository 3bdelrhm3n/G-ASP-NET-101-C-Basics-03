using System.Threading.Channels;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Divides.divide();
        }
    }
}
#region question1
//Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block
public class Divides
{
    public static void divide()
    {

        try
        {
            Console.WriteLine("Enter the first number ");
            bool isValidInput1 = int.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("Enter the second number ");
            bool isValidInput2 = int.TryParse(Console.ReadLine(), out int b);
            decimal   result = (decimal)a / b;
            Console.WriteLine("Result: " + result);

           
            
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine( "Cannot divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine( "an error occured:"+ex .Message );
        }
        finally
        {
            Console.WriteLine( "End of program ");
        }
        
    }
    
 }
#endregion


#region question2
//Declare an int pages = 300; then store it in a double variable without using a cast.

//int pages = 300;
//double pagesDouble = pages;
#endregion

#region question3
//Declare a double price = 49.99; then convert it into an int using a cast.

//double price = 49.99;
//int priceInt = (int) price ;
#endregion

#region questions4
//Given string pagesText = "464";, convert it into an int using the Convert class.

//string pagesText = "464";
//int pagesInt = Convert.ToInt32(pagesText);
#endregion

#region question5
//Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.

//string yearText  ="2023";
//int yearInt =int.parse(yearText);
//string badText ="abc";
//bool isValid = int.TryParse(badText, out int badInt);
//if (isValid == false){
//    Console.WriteLine("Invalid number");
//}
#endregion

#region question6
//Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.

// int pages =464;
// string pagesString = pages.ToString();
// Console.WriteLine(pagesString.GetType());
#endregion

#region question7
//Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.

// int copies =100;
//object obj = copies;
//int newcopies = (int) obj;
// console.WriteLine("Boxed value: " + obj);
// console.WriteLine("Unboxed value: " + newcopies);
#endregion

#region question8
//Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book".

// int pages = 464;
// if (pages > 300){
//     Console.WriteLine("Long Book");
// }
// else{
//    Console.WriteLine("Short Book");
// }
#endregion

#region question9
//Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
//greater than 300 and isAvailable is true. Use the && operator.

// int pages =464;
// bool isAvailable = true;
// if (pages > 300 && isAvailable == true){
//  Console.WriteLine("You can borrow this book");
// }
#endregion