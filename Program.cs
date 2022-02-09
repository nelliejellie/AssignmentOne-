using System;
using System.Text.RegularExpressions;

namespace ClassRegister
{
    class Program
    {    

        static void Main()
        {
            int counter = 0;
            Student[] students = new Student[5];

            while (counter < students.Length)
            {
                Student student = new Student
                {
                    Firstname = ReturnData.firstName(),
                    Lastname = ReturnData.secondName(),
                    Gender = ReturnData.returnGender().ToString(),
                    Gadgets = ReturnData.loadArray(),
                    phoneNumber = ReturnData.phoneNumber(),
                    Email = ReturnData.EmailAddress()
                };
                students[counter] = student;
                counter++;
            }
            
            DotNetClass netClass = new DotNetClass(students);
            netClass.PrintClassDetails();
        }
        
    }
    // a static utility class for useful functions
    static class ReturnData{
        // static function that selects gender on userinput
        public static Gender returnGender(){
            System.Console.WriteLine("pick a value from 1 to 3");
            System.Console.WriteLine("1 = Male \n2 = Female \n3 = others ");
            string gender = Console.ReadLine();
            while(!Regex.IsMatch(gender, @"^[1|2|3]{1}$"))
            {
                System.Console.WriteLine("Make sure you pick a value from 1 to 3");
                System.Console.WriteLine("1 = Male \n2 = Female \n3 = others ");
                gender = Console.ReadLine();
            }
            if(gender == "1")
            {
                return Gender.Male;
            }
            else if(gender == "2")
            {
                return Gender.Female;
            }
            else{
                return Gender.Other;
            }
            
        }
        // function for creating a string from userinput
        public static string firstName(){
            Console.Write("enter your firstname:");
            string name = Console.ReadLine();
            while(!Regex.IsMatch(name, @"^[\p{L}]+$"))
            {
                Console.Write("your firstname must contain only letters:\n");
                Console.Write("enter your firstname:");
                name = Console.ReadLine();
            }
            return name;
        }
        public static string secondName(){
            Console.Write("enter your secondname:");
            string name = Console.ReadLine();
            while(!Regex.IsMatch(name, @"^[\p{L}]+$"))
            {
                Console.Write("your secondname must contain only letters:");
                Console.Write("enter your secondname:");
                name = Console.ReadLine();
            }
            return name;
        }
        // function for creating an array from userinput
        public static string[] loadArray()
        {
            System.Console.WriteLine("How many gadgets do you have?");
            int numOfGadgets = Convert.ToInt32(Console.ReadLine());
            string[] gadgets = new string[numOfGadgets];
            int counter = 0;
            string nextGadgetPointer = "please register your first gadget";
            while(counter < numOfGadgets)
            {
                if (counter > 0)
                {
                    nextGadgetPointer = "please register next gadget";
                }
                Console.WriteLine(nextGadgetPointer);
                gadgets[counter] = Console.ReadLine();
                counter++;
            }
            return  gadgets;
        }
        // function that matches valid phone numbers 
        public static string phoneNumber()
        {
            Console.Write("enter your mobile number:");
            string numb = Console.ReadLine();
            while(!Regex.IsMatch(numb, @"^[0]{1}[9|8|7]{1}[0|1]{1}[0-9]{8}$"))
            {
                Console.Write("your phone number must 11  digits:\n");
                Console.Write("enter your mobile number:");
                numb = Console.ReadLine();
            }
            return numb;
        }
        public static string EmailAddress(){
            Console.Write("enter your email address:");
            string email = Console.ReadLine();
            return email;
        }
    }
}

//class object
//field representing total number of students
//field representing the list of students in the class
//method to set the number of students
//method to add students to the class
//method to remove student from class
//class name
//class description


//student object
//student name
//student gender
//student gadgets
//student id