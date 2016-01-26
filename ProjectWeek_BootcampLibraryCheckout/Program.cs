using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWeek_BootcampLibraryCheckout
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int menuChoice;
                string errorNum = "Please type a number.";
                string menu1 = "\nList of Studnet Names\n\n";
                //Part 1:

                //2 Points - Application should be clearly named in the application (Bootcamp Resources Checkout System or an original name)
                string title = "********************* BootCamp Lending Library Checkout *********************";
                //3 Points - Program should be case insensitive
                //12 Points - Application should have a menu with the following options:
                //View Students
                //View Available Resources
                //View Student Accounts
                //Checkout Item
                //Return Item
                //Exit

                string[] studentNames = {"Quinn Bennett", "Imari Childress", "Jennifer Evans", "Richard Raponi", "Cameron Robinson", "Krista Scholdberg", "Ashley Stewart", "Cadale Thomas", "Kim Vargas", "Mary Winkelman", "Sirahn Butler" };
                string[] bookNames = {"Programming Interviews Exposed", "Killer Game Programming", "Head First C#", "A Smarter Way to Learn JavaScript", "Implementing Responsive Design", "C# 5.0 For Dummies", "Assembly Language Tutor", "Mastering C Pointers", "Javascritpt For Kids", "Essential C# 6.0", "ASP.NET MVC 5" };
                
                string menu = "\n\nMENU\n\n(Please type a number.)" +
                    "\n\n1. View Students\n2. View Available Resources\n" +
                    "3. View Student Accounts\n4. Checkout Item\n5. Return Item" +
                    "\n6. Exit";
                Console.WriteLine(title);
                Console.WriteLine(menu);
                bool menuNAN = int.TryParse(Console.ReadLine(), out menuChoice);
                while (!menuNAN)
                {
                    Console.WriteLine(errorNum);
                    menuNAN = int.TryParse(Console.ReadLine(), out menuChoice);
                }

                switch (menuChoice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(title);
                        Console.WriteLine(menu1);
                        foreach (string studentName in studentNames)
                            {
                            Array.Sort(studentNames);
                            Console.WriteLine(studentName);
                            }
                        Console.WriteLine("\n\nHit any key to return to menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:

                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    default:
                        break;
                }

            //6 Points - View Students
            //Print a vertical list of all of the students in the system (minimum 5 students)
            //Names should be alphabetized (by either first or last name)
            //Menu should be available to navigate to another option
            //10 Points - View Available Resources
            //Print vertical list of only the resources that are available (not checked out)
            //List should be alphabetized
            //If no items are checked out, there should be a minimum of 10 resources
            //Menu should be available to navigate to another option
            //If all resources are checked out, print “All resources are checked out.”
            //10 Points - View Student Accounts
            //Ask for a student’s name
            //If the student’s name does not exist, print “Error: Request Unavailable”
            //If the student has 0  items checked out, print “Nothing is checked out…”
            //If items are checked out, print a vertical list of those items
            //After printing the student’s account, menu should be available to navigate to another option
            //14 Points - Checkout Item
            //Ask for a student’s name
            //If the student’s name does not exist, print “Error: Request unavailable”
            //Ask for the title of the item
            //If the title does not exist in the available resources, print “Error: Request Unavailable”
            //If the item is available, print “[Student Name] checked out [Title].
            //Each student can only have 3 items checked out at one time
            //If a student has 3 items already checked out, when the student’s name is entered on the checkout screen, print “[Student Name]
            //        has checked out the max number of resources.”
            //14 Points - Return Item
            //Ask for a student’s name
            //If the student’s name does not exist, print “Error: Request Unavailable”
            //Ask for the title of the resource to be returned
            //If the title exists in the student’s account, remove the the title from the student’s account
            //Add the returned title back to the available resources list
            //If the title does not exist in the student’s account, print “Error: Request Unavailable”
            //Menu should be available to navigate to another option
            //4 Points - Exit
            //The program should not exit until told to by the user
            //Before exiting, print an exit message, such as “Goodbye”

            //Part 1 Total Points _____/75

            //Part 2:

            //10 Points - Find ways to break your program, and make necessary adjustments for prevention and explain on the submission form
            //10 Points - Explain your development process on the submission form by answering what you used and how you used items from the listed categories
            //5 Points - Present your project for peer review on Thursday
            //Submit project through this form: Submission Form

            //Part 2 Total Points _____/25

            //Total Points _____/100



            if (menuChoice.Equals(6))
                {
                    return;
                }



            }
        }
    }
}
