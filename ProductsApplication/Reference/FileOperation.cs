using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/**
 * From developer console: execute csc FileOperation (to compile), then run
 */
namespace ProductsApplication.Reference
{
    public class FileOperation
    {

        static void Main()
        {
            string fileName = @"e:\temp\test_file.txt";

            if (System.IO.File.Exists(fileName))
            {
                System.IO.File.Delete(fileName);

            }

            using (System.IO.FileStream fs = System.IO.File.Create(fileName, 1024))
            {
                byte[] info = new System.Text.UTF8Encoding(true).GetBytes("ProductFileTest");
                fs.Write(info, 0, info.Length);
            }

            using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
            {
                string someText = "";
                while ((someText = sr.ReadLine()) != null)
                {
                    System.Console.WriteLine(someText);
                }
            }


        }
    }
}