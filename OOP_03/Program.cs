using System;
#nullable disable
namespace OOP_03
{
    #region Part 01 — Theoretical Questions Q1
    //-------------------------------Q1-------------------------------
    /*
    ----------------------------------- a -----------------------------
    1.overloading : Allows a class to have multiple methods with the same name but different Parameters.
    2.overriding: Allows a derived class to provide a specific implementation of a method that is already defined in its base class
    ----------------------------------- b -----------------------------
    1. Static binding(early binding) : resolved at compile time , the compiler performs it , decided by reference type ,  key word : new, faster , less flexible
    2. Dynamic binding(last binding) : resolved at run time , the CLR performs it , decided by object in memory ,  key word : virtual + override, slower , more flexible =>
    (enable polymorphism)
     */
    #endregion


    #region  Part 01 — Theoretical Questions Q2
    //-------------------------------Q2-------------------------------
    /*
    -----------------------------------a-----------------------------
     it protect logic , better performance because JIT can often skip the virtual lookup

    -----------------------------------b-----------------------------
    A sealed class is a class that cannot be inherited. It stops the inheritance chain completely
    A method can be sealed inside a derived class to prevent further overriding down the chain.

    -----------------------------------C-----------------------------
     it can not be overridden , sealed method prevent that 
    and all this for more protection and the design requirements
     */

    #endregion



    public class Program
    {
        static public void Main(string[] args)
        {

        }
    }
}