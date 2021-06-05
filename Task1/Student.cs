using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double AverageSuccess { get; set; }

        private static Random rnd = new Random(DateTime.Now.Second);

        public Student()
        {
            this.FirstName = "";
            this.LastName = "";
            this.AverageSuccess = 0;
        }
        public Student(string FirstName, string LastName, double AverageSuccess)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.AverageSuccess = AverageSuccess;
        }

        public string RandFirstName()
        {
            string[] maleNames = new string[] { "Kostadin", "Nikolai", "Dimitar", "Nikola", "Daqn", "Martin", "Georgi", "Misho", "Cvetan", "Rostislav" };
            FirstName += maleNames[rnd.Next(0, maleNames.Length - 1)];
            return FirstName;
        }

        public string RandLastName()
        {
            string[] lastNames = new string[] { "kolchev", "Mitev", "Stoqnov", "Ishev", "Aleksandrov", "Dimitrov", "Stoichev", "Kadrev", "Mangurov"};
            LastName += lastNames[rnd.Next(0, lastNames.Length - 1)];
            return LastName;
        }
    }
}
