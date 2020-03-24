using System;
using System.IO;

namespace GitDiff
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaring neccessary variables and assigning file locations as values.
            string string1;
            string string2;
            string SelectedFile1;
            string SelectedFile2;

            string input = Console.ReadLine().ToLower();
            SelectedFile1 = FileSelect.findFileOne(input, 1);
            SelectedFile2 = FileSelect.findFileTwo(input, 2);


            
            //Calls method and assigns the value it returns to a string variable
            string1 = returnString.textToString(SelectedFile1);
            string2 = returnString.textToString(SelectedFile2);



         

            //Checks if the two strings are identical.
            if (string1 == string2)
            {
                Console.WriteLine("These files are not different");
            }
            else
            {
                Console.WriteLine("\nThese files are different");
            }


        }
    }
}
