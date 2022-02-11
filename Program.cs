using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 employee = new Class1(1, "Jose", "Aguirre", 31);
            Class1 employee2 = new Class1(2, "Dario", "Gamboa", 31, "SDET", "UnoSquare");


            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("------------Apply constructor overloading.-----------");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(employee.getEmployee());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(employee.updateEmployee("Tester", "UnoSquare"));
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(employee2.getEmployee());

        
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Create a method to verify if a string is a palindrome (Use the created property).");
            
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Alí tomó tila. --->" + Class1.isPalidrome("Alí tomó tila."));
            Console.WriteLine("Ají traga la lagartija. ---->" + Class1.isPalidrome("Ají traga la lagartija."));
            Console.WriteLine("Lo sé, dama de sol. --->" + Class1.isPalidrome("Lo sé, dama de sol."));
            Console.WriteLine("Esto no es un palindromo --->" + Class1.isPalidrome("Esto no es un palindromo"));

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("----Create a method to print numbers in diagonal.----");
            Console.WriteLine("-----------------------------------------------------");
            Class1.printNumbersInDiagonal(100);





            Console.ReadKey();

            
        }
    }
}
