using System;

namespace StudentAdmissionManagement
{
    public class Student
    {
        // Public Data Members
        public int GrNo;
        public int AdmissionNo;
        public string Course;
        public int Semester;
        public double Fees;

        // Private Data Member
        private string Name;

        // Scholarship Details
        public bool IsScholarshipEligible;
        public const double ScholarshipRate = 0.10;
        public double FinalFees;

        // Default Constructor
        public Student()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine(" Student Admission Management System");
            Console.WriteLine("=======================================\n");
        }

        // Method to Accept Student Details
        public void GetData()
        {
            Console.Write("Enter GR No           : ");
            GrNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name            : ");
            Name = Console.ReadLine();

            Console.Write("Enter Admission No    : ");
            AdmissionNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course          : ");
            Course = Console.ReadLine();

            Console.Write("Enter Semester        : ");
            Semester = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Admission Fees  : ");
            Fees = Convert.ToDouble(Console.ReadLine());
        }

        // Method to Display Student Details
        public void DisplayData()
        {
            Console.WriteLine("\n=======================================");
            Console.WriteLine(" Student Details");
            Console.WriteLine("=======================================");

            Console.WriteLine($"Name                 : {Name}");
            Console.WriteLine($"GR No                : {GrNo}");
            Console.WriteLine($"Admission No         : {AdmissionNo}");
            Console.WriteLine($"Course               : {Course}");
            Console.WriteLine($"Semester             : {Semester}");
            Console.WriteLine($"Admission Fees       : {Fees}");

            if (Fees <= 50000)
            {
                IsScholarshipEligible = true;
                FinalFees = Fees - (Fees * ScholarshipRate);
            }
            else
            {
                IsScholarshipEligible = false;
                FinalFees = Fees;
            }

            Console.WriteLine($"Scholarship Eligible : {(IsScholarshipEligible ? "Yes" : "No")}");
            Console.WriteLine($"Final Fees           : {FinalFees}");
        }
    }
}