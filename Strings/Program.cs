using System;

namespace Strings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            StringBuilder myString = new StringBuilder();

            for (int i -0; i < 100, i++)
            {
                myString.Append("--");
                myString.Append(i);

            }
*/
            string myString = "Lyrics";

                myString = myString.Substring(5, 14);

            Console.WriteLine(myString);
            Console.ReadLine();



        }
    }
}



//