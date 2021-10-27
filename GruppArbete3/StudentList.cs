using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppArbete3
{
    class StudentList : IStudentList
    {
        const int MaxNrOfStudents = 50;

        string[] students;

        private int _NrOfStudents = 0;
        public int NrOfStudents => _NrOfStudents;

        private int _NrOfGroups = 0;
        public int NrOfGroups
        {
            get => _NrOfGroups;
            set => _NrOfGroups = value;
        }
        public int _NrStudentsInGroup => _NrOfStudents / _NrOfGroups;
        public int NrStudentsInGroup => _NrStudentsInGroup;
        public int _NrStudentsNotInGroup => _NrOfStudents % _NrOfGroups;
        public int NrStudentsNotInGroup => _NrStudentsNotInGroup;

        // sorts list of students by first names alphabetically
        public void Sort()
        {
            for (int i = 0; i < NrOfStudents - 1; i++)
            {
                for (int unsortedStart = 0; unsortedStart < NrOfStudents - 1; unsortedStart++)
                {
                    int minIndex = unsortedStart;
                    var minValue = students[unsortedStart];

                    //Iterate over the unsorted part
                    for (int j = unsortedStart + 1; j < NrOfStudents; j++)
                    {
                        //Find the smalest element in the unsorted part
                        if (students[j].CompareTo(minValue) < 0)
                        {
                            minIndex = j;
                            minValue = students[j];
                        }
                    }
                    (students[unsortedStart], students[minIndex]) = (students[minIndex], students[unsortedStart]);
                }
            }
        }
        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < _NrOfStudents; i++)
            {
                sRet += $"{students[i],-15}";
                if ((i + 1) % 5 == 0)
                    sRet += "\n";
            }
            return sRet;
        }

        public void CreateOOP1dotNet5()
        {
            // new string[MaxNrOfStudents];
            students = new string[]{
                "Sahar", "Jennifer", "Shohruh", "Jonathan",
                "Leo", "Jenny", "Mohamed", "Ferri", "Alexandra F",
                "Vidar", "Kamran", "Kamran", "Pontus", "Kaveh",
                "Maria", "Adam", "Sophie", "Louise", "Fredric",
                "Carl-Henrik","Frans","Sam","Alexandra S","Alperen",
                "Josefine","Ghasem","Ghasem", "Hanna","Finan","Niklas",
                "Hector","Adrian","Teodor"
            };

            /*students[0] = "Sahar";
            students[1] = "Jennifer";
            students[2] = "Shohruh";
            students[3] = "Jonathan";
            students[4] = "Leo";
            students[5] = "Jenny";
            students[6] = "Mohamed";
            students[7] = "Ferri";
            students[8] = "Alexandra F";
            students[9] = "Vidar";
            students[10] = "Kamran";
            students[11] = "Pontus";
            students[12] = "Kaveh";
            students[13] = "Maria";
            students[14] = "Adam";
            students[15] = "Sophie";
            students[16] = "Louise";
            students[17] = "Fredric";
            students[18] = "Carl-Henrik";
            students[19] = "Frans";
            students[20] = "Sam";
            students[21] = "Alexandra S";
            students[22] = "Alperen";
            students[23] = "Josefine";
            students[24] = "Ghasem";
            students[25] = "Hanna";
            students[26] = "Finan";
            students[27] = "Niklas";
            students[28] = "Hector";
            students[29] = "Fredrik";
            students[30] = "Adrian";
            students[31] = "Teodor";
            // why 30 not 32?
            */

            _NrOfStudents = students.Length - 1;
        }
        // Knuth Shuffle
        public void ShuffleStudents()
        {
            Random rng = new Random();

            for (int i = 0; i < NrOfStudents - 1; i++)
            {
                int j = rng.Next(i, NrOfStudents);
                string tmp = students[i];
                students[i] = students[j];
                students[j] = tmp;
            }
        }
        public string CreateGroups()
        {
            int groupCount = 1;
            string sRet = "";

            for (int i = 0; i < _NrOfStudents; i++)
            {
                if (i == 0 || i % NrStudentsInGroup == 0)
                {
                    sRet += $"\nGroup no. {groupCount}: ";
                    groupCount++;
                }
                sRet += $"{students[i],-15}";
            }
            return sRet;


            /*
            Console.WriteLine("== GROUPS ==");
            string sRet = "";
            int groupCount = 0;
            Console.WriteLine($"Group { groupCount + 1}");

            for (int i = 0; i < NrOfStudents; i++)
            {
                if(i == 0 || i == NrStudentsInGroup)
                {
                    sRet += $"Group {groupCount + 1}\n{students[i],-15}";
                    groupCount++;
                }
                else
                {
                    sRet += $"{students[i],-15}";
                }
            }
            return sRet;
            */
        }
    }
}
