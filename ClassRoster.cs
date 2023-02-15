using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_124_Lecture_11_Interfaces
{
    internal class ClassRoster : IEnumerable
    {
        int[] arr;
        List<Student> _classList;

        public ClassRoster()
        {
            _classList = new List<Student>();
        }

        internal List<Student> ClassList { get => _classList; }

        public void AddStudent(Student student)
        {
            _classList.Add(student);
        }


        public IEnumerator GetEnumerator()
        {
            return new ClassRosterEnumerator(ref _classList);
        }

        // In order to work with the GetEnuemrator, you need to create a class that inherits from IEnumerator

        // I'm going to create an internal class.

        private class ClassRosterEnumerator : IEnumerator
        {
            // Field to keep track of our index, declare with -1
            int index = -1;
            List<Student> students;

            // Make sure to take a List of your type, and put REF before it
            public ClassRosterEnumerator(ref List<Student> studentList)
            {
                students = studentList;
            }

            // Returns the current item in the list at the index
            public object Current => students[index];

            public bool MoveNext()
            {
                // Increase the index
                index++;

                // if it is pass the last item on the list, return false, else return true
                if(index >= students.Count)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            // Sets index back to negative one
            public void Reset()
            {
                index = -1;
            }
        }

    } // class
} // namespace
