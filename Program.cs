//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//string text = System.IO.File.ReadAllText(@"F:\code\python\project\detectionCoordinate\test.txt");

//// Display the file contents to the console. Variable text is a string.
//System.Console.WriteLine("Contents of test1.txt = {0}", text);

//// Example #2
//// Read each line of the file into a string array. Each element
//// of the array is one line of the file.
//string[] lines = System.IO.File.ReadAllLines(@"F:\code\python\project\detectionCoordinate\test.txt");

//// Display the file contents by using a foreach loop.
//System.Console.WriteLine("Contents of test2.txt = ");
//foreach (string line in lines)
//{
//    // Use a tab to indent each line of the file.
//    Console.WriteLine("\t" + line);
//}

//// Keep the console window open in debug mode.
//Console.WriteLine("Press any key to exit.");
//System.Console.ReadKey();
using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Threading;

class Test
{

    public static void Main()
    {
        string path = @"F:\code\python\project\AR_project\data.txt";
        //try
        //{
        //if (File.Exists(path))
        //{
        //    File.Delete(path);
        //}

        //using (StreamWriter sw = new StreamWriter(path))
        //{
        //    sw.WriteLine("This");
        //    sw.WriteLine("is some text");
        //    sw.WriteLine("to test");
        //    sw.WriteLine("Reading");
        //}

        while (true)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open,FileAccess.Read,FileShare.ReadWrite))
            /*using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            string line = Console.ReadLine();*/
            using (StreamReader sr = new StreamReader(fs))
            {
                while (sr.Peek() >= 0)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            //string line = Console.ReadLine();
            Thread.Sleep(1000);

        }
        /*using (var inStream = new FileStream(logfileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            while (sr.Peek() >= 0)
            {
                Console.WriteLine(sr.ReadLine());
            }
        }*/

    }
}