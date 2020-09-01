using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       //Your code goes here
       Console.Write("Want a quiz?");
       Console.ReadLine();
       Console.WriteLine("Okay, Let's start!");
       double answer = 3.14;
       Console.WriteLine("Type in the answer for this question \n What is PI in number form?(Give answer with 2.dp)");
       double input;
while (!double.TryParse(Console.ReadLine(), out input)) {
  // The code in here runs if the input is _not_ a valid double value.
  Console.WriteLine("The input is not a valid double");
}
       if (input == answer)
       {
          Console.WriteLine("Correct you smort peanut");
       }
       else
       {
           Console.WriteLine("Oh no, you a dum dum");
       }
      }
     }
   }
   //OMG it finally work, I tried for so long, and so many people helped. Thank you guys, This'll help me out.