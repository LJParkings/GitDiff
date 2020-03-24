using System;
using System.IO;


namespace GitDiff
{
    public class FileSelect
    {

   



        public static string findFileOne(string input, int index)
        {
            //Declaring neccessary variables and assigning file locations as values.

            string file1 = (@"..\..\..\GitRepositories_1a.txt");
            string file2 = (@"..\..\..\GitRepositories_1b.txt");
            string file3 = (@"..\..\..\GitRepositories_2a.txt");
            string file4 = (@"..\..\..\GitRepositories_2b.txt");
            string file5 = (@"..\..\..\GitRepositories_3a.txt");
            string file6 = (@"..\..\..\GitRepositories_3b.txt");

            string foundFile1 = ("");


            //Brute force approach to taking user input

            if (input.Contains("diff"))
            {
                string[] splitInput = input.Split(" ");
                if (splitInput[1].Contains("1a.txt"))
                {
                    foundFile1 = file1;
                }
                else if (splitInput[1].Contains("1b.txt"))
                {
                    foundFile1 = file2;
                }
                else if (splitInput[1].Contains("2a.txt"))
                {
                    foundFile1 = file3;
                }
                else if (splitInput[1].Contains("2b.txt"))
                {
                    foundFile1 = file4;
                }
                else if (splitInput[1].Contains("3a.txt"))
                {
                    foundFile1 = file5;
                }
                else if (splitInput[1].Contains("3b.txt"))
                {
                    foundFile1 = file6;
                }
                else
                {
                    //Need better exception handling
                    foundFile1 = file1;
                }

                
            }
            else
            {
                Console.WriteLine("Need Expection handling");
            }

            return foundFile1;
        }

        public static string findFileTwo(string input, int index)
        {
         

            string file1 = (@"..\..\..\GitRepositories_1a.txt");
            string file2 = (@"..\..\..\GitRepositories_1b.txt");
            string file3 = (@"..\..\..\GitRepositories_2a.txt");
            string file4 = (@"..\..\..\GitRepositories_2b.txt");
            string file5 = (@"..\..\..\GitRepositories_3a.txt");
            string file6 = (@"..\..\..\GitRepositories_3b.txt");

            string foundFile2 = ("");


            if (input.Contains("diff"))
            {
                string[] splitInput = input.Split(" ");
                if (splitInput[2].Contains("1a.txt"))
                {
                    foundFile2 = file1;
                }
                else if (splitInput[2].Contains("1b.txt"))
                {
                    foundFile2 = file2;
                }
                else if (splitInput[2].Contains("2a.txt"))
                {
                    foundFile2 = file3;
                }
                else if (splitInput[2].Contains("2b.txt"))
                {
                    foundFile2 = file4;
                }
                else if (splitInput[2].Contains("3a.txt"))
                {
                    foundFile2 = file5;
                }
                else if (splitInput[2].Contains("3b.txt"))
                {
                    foundFile2 = file6;
                }
                else
                {
                    //Need better exception handling
                    foundFile2 = file1;
                }


            }
            
            return foundFile2;
        }



    }

}
