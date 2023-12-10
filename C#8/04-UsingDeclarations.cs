using System.IO;

namespace CSharp8.Features
{
    public static class UsingDeclarations
    {
        public static int ConvertFiles()
        {
            int outPut = 0;

            using var inputFile = new StreamReader(@"D:\csharp.txt");
            using var outputFile = new StreamWriter(@"D:\output.txt");

            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                outputFile.WriteLine(line);
                outPut += 1;
            }

            /*using (var inputFile = new StreamReader(@"D:\csharp.txt"))
            {
                using (var outputFile = new StreamWriter(@"D:\output.txt"))
                {
                    string line;
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        outputFile.WriteLine(line);
                        outPut += 1;
                    }
                }
            }*/

            return outPut;
        }
    }
}
