using System;

namespace StudentAdmissionManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.GetData();
            student.DisplayData();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}