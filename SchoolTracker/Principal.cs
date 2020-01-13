using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTracker
{
    // for the principal class to use pay function, it must implement the pay function
    class Principal : Member, IPayee
    {
       // implement interfaces pay function(the classes own version of it)
       public void Pay()
       {
           Console.WriteLine("Paying Principal");
       } 
    }
}