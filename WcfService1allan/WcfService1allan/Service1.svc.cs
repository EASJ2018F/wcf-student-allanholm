using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1allan
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static List<Student> _listOfStudents;


        public Service1()
        {
            _listOfStudents = new List<Student>();

            AddStudent(1,"john", "5G");
            AddStudent(2,"Conrad", "8S");
            AddStudent(7,"bent", "9k");
        }

        public static List<Student> ListOfStudents
        {
            get
            {
                if (_listOfStudents == null)
                {
                    _listOfStudents = new List<Student>();
                }

                return _listOfStudents;
            }
        }
        public void AddStudent(int StudentID, string Name, string ClassName)
        {
            ListOfStudents.Add(new Student(Name, ClassName, StudentID));
        }

        public void RemoveStudent(int StudentID)
        {
            ListOfStudents.Remove(FindStudent(StudentID));
        }

        public void EditStudent(int StudentID, string Name, string ClassName)
        {
            RemoveStudent(StudentID);
            ListOfStudents.Add(new Student(Name, ClassName, StudentID));
        }

        public List<Student> GetAllStudents()
        {
            return ListOfStudents;
        }

        public Student FindStudent(int StudentID)
        {
            Student FoundStudent = ListOfStudents.Find(x => x.StudentID.Equals(StudentID));
            return FoundStudent;
        }
        
    }
}
