using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class StudyClass
    {
        public string Id { get; set; }
        public string Name { get; set; }

        List<Student> students = new List<Student>();

        List<string> classes = new List<string>();
        
        private static Random rnd = new Random(DateTime.Now.Second);

        public StudyClass()
        {
            this.Id = "";
            this.Name = "";

        }
        public StudyClass(string Id, string Name, IEnumerable<Student> studentsList)
        {
            this.Id = Id;
            this.Name = Name;
            students = new List<Student>(studentsList);
        }
        
        public static string teacherName()
        {
            string[] names = new string[] { "Mrs. Cholakova", "Mrs. Andreev", "Mr. Rachkov", "Mr. Trifonov", "Mr. Mihalkov", "Mr. Chatlabashev" };
            string tName = names[rnd.Next(0, names.Length - 1)];
            return tName;
        }

        public static string randomLetter(int len)
        {
            const string chars = "ABCDEF";
            return new string(Enumerable.Repeat(chars, len)
              .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// 1.	Произволно генериране на 4 до 6 паралелки от един клас (например 7-ми), 
        /// във всяка паралелка да има от 20 до 30 ученика
        /// 2.	Извеждане на генерираните паралелки (идентификатор, ръководител на паралелката и брой ученици)
        /// </summary>
        public void RandomClasses()
        {
            Console.WriteLine("Enter grade: ");
            int grade = int.Parse(Console.ReadLine());
            if (grade >= 1 && grade <= 12)
            {
                int number = 0;
                while (number <= rnd.Next(4, 6))
                {
                    string letter = randomLetter(1);
                    StringBuilder stringBuilder = new StringBuilder().Append(grade).Append(letter);
                    Id = stringBuilder.ToString();
                    classes.Add(Id);
                    Name = StudyClass.teacherName();
                    while (students.Count <= rnd.Next(20, 30))
                    {
                        Student student = new Student();
                        student.FirstName = student.RandFirstName();
                        student.LastName = student.RandLastName();
                        student.AverageSuccess = (double)rnd.Next(2, 6);
                        students.Add(student);
                    }
                    number++;
                    Console.WriteLine($"Class id: {Id}");
                    Console.WriteLine($"Teacher's name: {Name}");
                    Console.WriteLine($"Number of students: {students.Count}");
                    Console.WriteLine(" ");
                }
            }
            else
            {
                Console.WriteLine("Invalid grade entered!");
            }
        }

        /// <summary>
        /// 3.	Извеждане на среден успех на всяка паралелка
        /// </summary>
        public void printAverageSuccess()
        {
            double sum = 0;
            foreach (var cl in classes)
            {
                sum = 0;
                Console.WriteLine($"Class id: {cl}");
                foreach (var st in students)
                {
                    sum += st.AverageSuccess;
                    st.AverageSuccess = (double)rnd.Next(2, 6);
                }
                Console.WriteLine($"The average success id: {sum / (double)students.Count}");
                
            }
        }

        /// <summary>
        /// 4.	Извеждане на учениците в паралелка сортирани по име
        /// </summary>
        public void sortByNames()
        {
            List<Student> std = students.OrderBy(s => s.FirstName).ToList();
            foreach (var item in classes)
            {
                Console.WriteLine();
                Console.WriteLine($"Class id: {item}");
                printStudents(std);
            }
        }

        /// <summary>
        /// 4.	Извеждане на учениците в паралелка сортирани по успех
        /// </summary>
        public void sortBySuccess()
        {
            List<Student> std = students.OrderBy(s => s.AverageSuccess).ToList();
            foreach (var item in classes)
            {
                Console.WriteLine($"Class id: {item}");
                printStudents(std);
            }
        }

        public void printStudents(List<Student> students)
        {
            foreach (var st in students)
            {
                Console.WriteLine($"First name: {st.FirstName}");
                Console.WriteLine($"Last name: {st.LastName}");
                Console.WriteLine($"Average access: {st.AverageSuccess}");
            }
        }
    }
}
