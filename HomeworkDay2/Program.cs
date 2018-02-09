using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader Reader = new StreamReader("DecodeThis.txt");
            // Compose a string that consists of the file.
            string line = "";

            System.IO.StreamWriter newFile = new System.IO.StreamWriter("WriteThis.txt");

            Console.WriteLine("Starting......!");

            while (line != null)
            {
                line = Reader.ReadLine();
                if (line != null)
                {
                    char[] charArray = line.ToCharArray();
                    Array.Reverse(charArray);
                    //Console.WriteLine(charArray);

                    // Write the string to a file.                    
                    newFile.WriteLine(charArray);
                 }                
            }
            Reader.Close();
            newFile.Close();

            Console.WriteLine("......Finished!");
            Console.ReadLine();         
            //file.Close();                                  
         }
    }
}
