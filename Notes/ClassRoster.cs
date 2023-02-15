using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_124_Lecture_11_Interfaces.Notes
{
    internal class ClassRoster : IEnumerable
    {
        List<Student> _classRoster;

        public ClassRoster()
        {
            _classRoster = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            _classRoster.Add(student);
        }

        public IEnumerator GetEnumerator()
        {
            return new ClassRosterEnum(ref _classRoster);
        }



        private class ClassRosterEnum : IEnumerator
        {
            int index = -1;
            List<Student> Students;

            public object Current => Students[index];

            public ClassRosterEnum(ref List<Student> list)
            {
                Students = list;
            }

            public bool MoveNext()
            {
                index++;
                if(index >= Students.Count)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
