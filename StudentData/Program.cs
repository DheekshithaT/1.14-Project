using System;
using System.IO;

namespace StudentsData
{
    public class Program
    {
        static void FileOp()
        {
            string path = "C:\\Users\\91807\\Desktop\\December\\StudentData\\StudentData.txt";

            if (File.Exists(path))
            {
                // Read and display existing student data
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                // Create and write sample student data
                string[] data = {
                    "Student_Roll  : 1212",
                    "Student_Name  : Jungkook",
                    "Student_Address: South Korea"
                };

                File.WriteAllLines(path, data);

                // Read and display the newly written data
                foreach (string line in data)
                {
                    Console.WriteLine(line);
                }
            }
        }

        static void Main(string[] args)
        {
            FileOp();
        }
    }
}
