using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exercise2
{
    internal class Class1
    {
        private int idEmployee;
        private string firstName;
        private string lastName;
        private int age;
        private string job;
        private string company;



        /*Default Constructor*/
        public Class1()
        {

        }


        /*Constructor for unemployed */
        public Class1(int idEmployee,string firstName, string lastName, int age)
        {
            this.idEmployee = idEmployee;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;

        }
        /*Constructur for worker*/
        public Class1(int idEmployee, string firstName, string lastName, int age, string job, string company){
            this.idEmployee = idEmployee;
            this.firstName = firstName;
            this.lastName = lastName;   
            this.age = age;
            this.job = job;
            this.company = company;

        }


        public string updateEmployee(string firstName, string lastName, int age, string job, string company)
        {
            return "Employee information:\nFull Name:" + firstName + " " + lastName + "\nAge: " + age + "\nJob: " + job + "\nCompany: " + company;
        }
        
            public string updateEmployee(string job, string company)
        {
            this.job = job;
            this.company = company;
            return "Employee information: " +"\nId Employee: "+this.idEmployee+"\nFull Name:" + this.firstName + " " + this.lastName + "\nAge: " + this.age + "\nJob: " + this.job + "\nCompany: " + this.company;
        }
        public string getEmployee()
        {
            return "Employee information: " + "\nId Employee: " + this.idEmployee + "\nFull Name:" + this.firstName + " " + this.lastName + "\nAge: " + this.age + "\nJob: " + this.job + "\nCompany: " + this.company;
        }


        public static void printNumbersInDiagonal(int limit)
        {
            for (int i = 1; i <= limit;i++) {
                Console.WriteLine(i.ToString().PadLeft(i));
             }
        }

        public static bool isPalidrome(string word)
        {
            /*Remove every special character like '!. */
            string wordFormatted = Regex.Replace(word.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");

            /*Remove blank spaces and make an upper case*/
            char[] chars = wordFormatted.ToUpper().Replace(" ","").ToCharArray();
            for(int x = 1; x < chars.Length; x++)
            {
                char a = chars[x - 1];
                char b = chars[chars.Length - x];
                if (chars[x - 1] != chars[chars.Length - x])
                {
                    return false;
                }
            }
            return true;
        }


    }
}
