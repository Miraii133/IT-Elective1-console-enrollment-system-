using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValmoriaLab2
{
    class Students
    {
        List<int> idArray = new List<int>();
        List<string> nameArray = new List<string>();
        List<int> contactNumberArray = new List<int>();
        /*public Students(int id, string name, int contactNumber)
        {
            idArray.Add(id);
            nameArray.Add(name);
            contactNumberArray.Add(contactNumber);
            //ReadArrays();
        }*/

        private void GetStudentInputs()
        {

        }

        public void ReadArrays()
        {
            foreach (int id in idArray)
            {
                Console.WriteLine(id);
            }
            foreach (string name in nameArray)
            {
                Console.WriteLine(name);
            }
            foreach (int contactNumber in contactNumberArray)
            {
                Console.WriteLine(contactNumber);
            }
        }


    }
}
