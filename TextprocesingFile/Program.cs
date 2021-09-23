using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string adress = Console.ReadLine();

            int lastIndex = adress.LastIndexOf('\\');
            string lastelement = adress.Substring(lastIndex+1,adress.Length-1-lastIndex);
            int indexexeption = lastelement.LastIndexOf('.');
            string exepelement = lastelement.Substring(indexexeption + 1,lastelement.Length-1-indexexeption);
            string filenameindex = lastelement.Substring(0, indexexeption);
           // C:\Internal\training -internal \Template. pptx

            Console.WriteLine($"File name: {filenameindex}");
            Console.WriteLine($"File extension: {exepelement}");
        }
    }
}
