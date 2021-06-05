using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudyClass studyClass = new StudyClass();
            studyClass.RandomClasses();
            //studyClass.sortBySuccess();
            //studyClass.printAverageSuccess();
            //studyClass.sortByNames();
            Console.ReadLine();
        }
    }
}
