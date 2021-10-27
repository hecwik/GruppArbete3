using System;

namespace GruppArbete3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main program is using IStudentList as the type
            // Compilation works fine
            IStudentList myStudents = null;

            // Before execution myStudents needs to be assign an instance of StudentList
            myStudents = new StudentList();

            Console.WriteLine("\nEmpty student list");
            Console.WriteLine(myStudents);

            Console.WriteLine("\nStudent list");
            myStudents.CreateOOP1dotNet5();
            Console.WriteLine(myStudents);

            Console.WriteLine("\nSorted student list");
            myStudents.Sort();
            Console.WriteLine(myStudents);
            Console.WriteLine();

            Console.WriteLine("\nShuffled student list");
            myStudents.ShuffleStudents();
            Console.WriteLine(myStudents);
            Console.WriteLine();

            // Using the General UserInput we made in one of the code exercises
            int NrOfGroups = 0;
            bool Continue = UserInput.TryReadInt32("How many groups do you want", 1, myStudents.NrOfStudents / 2, out NrOfGroups);
            if (!Continue) return;

            myStudents.NrOfGroups = NrOfGroups;

            Console.WriteLine($"If you make {NrOfGroups} group(s), " +
                $"each group will have {myStudents.NrStudentsInGroup} " +
                $"student(s) with {myStudents.NrStudentsNotInGroup} " +
                $"student(s) remaining to be placed in the groups."
                );


            Console.WriteLine(myStudents.CreateGroups());
        }
    }
}
