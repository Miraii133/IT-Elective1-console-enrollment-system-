using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ValmoriaLab2
{
    class Course
    {
        public static List<int> codeArray = new List<int>();
        public static List<string> scheduleArray = new List<string>();
        public static List<string> subjectArray = new List<string>();

        public Course(int classCode, string schedule, string subject)
        {
            codeArray.Add(classCode);
            scheduleArray.Add(schedule);
            subjectArray.Add(subject);
            //ReadArrays();
        }
        public void ReadArrays()
        {
            foreach (int code in codeArray)
            {
                Console.WriteLine(code);
            }
            foreach (string schedule in scheduleArray)
            {
                Console.WriteLine(schedule);
            }
            foreach (string subject in subjectArray)
            {
                Console.WriteLine(subject);
            }
        }

    }

}
