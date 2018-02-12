using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfService1allan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1allan.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        
        [TestMethod()]
        public void AddStudentTest()
        {
            //arrange
            var service1 = new Service1();

            //act
            Student studenTest = service1.FindStudent(1);

            //assert
            Assert.AreEqual(studenTest.Name, "john");
        }

        [TestMethod()]
        public void RemoveStudentTest()
        {
            //act
            var service1 = new Service1();

            //arrange
            service1.AddStudent(1, "john", "5G");
            service1.AddStudent(9, "Conrad", "8S");
            
            service1.RemoveStudent(9);

            Assert.IsNull(service1.FindStudent(9));
        }

        [TestMethod()]
        public void EditStudentTest()
        {
            //arrange
            var service1 = new Service1();

            //act
            //service1.AddStudent(1, "Holger", "4G");
            service1.EditStudent(1, "Allan", "3F");
            Student studenTest = service1.FindStudent(1);

            //assert
            Assert.AreEqual(studenTest.Name, "Allan");
        }

        [TestMethod()]
        public void GetAllStudentsTest()
        {
            //arrange
            var service1 = new Service1();

            //act
            List<Student> studentList = new List<Student>();
            List<Student> getAllList = service1.GetAllStudents();

            studentList.Add(new Student("john", "3G", 1));
            studentList.Add(new Student("herman", "5t", 2));
            studentList.Add(new Student("rene", "9i", 5));

            

            //assert
            CollectionAssert.AreEqual(studentList, getAllList);
        }

        [TestMethod()]
        public void FindStudentTest()
        {
            //arrange
            var service1 = new Service1();

            //act
            Student studentTest = service1.FindStudent(1);

            //assert
            Assert.AreEqual(studentTest.Name, "john");
        }
    }
}