using System;
using System.IO;

namespace GitDiff
{

    public class returnString
    {

        //Method converts the text files to strings.

        //file is taken from the user input
        public static string textToString(string file)
        {
            string filename = file;

            string text = File.ReadAllText(filename);
            return text;
        }
    }

}
