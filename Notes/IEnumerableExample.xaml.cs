using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Programming_124_Lecture_11_Interfaces.Notes
{
    /// <summary>
    /// Interaction logic for IEnumerableExample.xaml
    /// </summary>
    public partial class IEnumerableExample : Window
    {
        ClassRoster prog124;

        public IEnumerableExample()
        {
            InitializeComponent();
            prog124 = new ClassRoster();
            prog124.AddStudent(new Student("Will", "Cram"));
            prog124.AddStudent(new Student("Dylan", "Register"));

            DisplayStudents();
        }

        public void DisplayStudents()
        {
            foreach (Student student in prog124)
            {
                lbExample.Items.Add(student);
            }
        }
    }
}
