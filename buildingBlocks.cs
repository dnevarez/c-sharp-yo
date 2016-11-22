using System; // Using statements bring in precreated code that you can use.
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A namespace is a way to say that anything declared or named within it will be seperate from other namespaces.
namespace BuildingBlocks
{
  class Program // class is a way of creating new type
  {  // Below is a function
    static void Main(string[] args)
    {
        var myString = "Hello World!"; // String is a series of letters/words between double quotes. All statements must end with a semicolon.
        // string myString = "Hello World!" //same as above.
        Console.WriteLine(myString);
        int myFirstValue = 23; // different kinds of number types. Int is for whole number
        double mySecondValue = 45.79; // double is for fraction/percentage
        double sum = myFirstValue + mySecondValue; // int is converted to double in this equation. ex - myFirstValue now equals 23.0.
        Console.WriteLine(sum); //Write line expects a string, but will run ToString on sum. we can also write it more explicity Console.WriteLine(sum.ToString())
    }
  }
}
