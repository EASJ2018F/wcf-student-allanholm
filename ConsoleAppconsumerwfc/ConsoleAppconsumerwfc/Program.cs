using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppconsumerwfc.ServiceReference1;

namespace ConsoleAppconsumerwfc
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new ServiceReference1.Service1Client())
            {
                client.AddStudent(1, "allan", "3F");
                client.AddStudent(2, "hans", "4D");

                foreach (var student in client.GetAllStudents())
                {
                    Console.WriteLine(student.Name);
                }

                Console.ReadLine();

                client.RemoveStudent(2);

                foreach (var student in client.GetAllStudents())
                {
                    Console.WriteLine(student.Name);
                }

                Console.ReadLine();
            }
        }
    }
}
