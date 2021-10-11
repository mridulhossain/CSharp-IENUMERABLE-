using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IENUMERABLE
{
    public class School : IEnumerable
    {
        public readonly List<Student> students = new List<Student>();

        public void Add(Student s)
        {
            students.Add(s);
        }

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }
    }
}
