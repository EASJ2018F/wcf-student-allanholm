namespace WcfService1allan
{
    public class Student
    {
        private string _name;
        private string _className;
        private int _studentID;

        public Student(string name, string className, int studentID)
        {
            _name = name;
            _className = className;
            _studentID = studentID;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }

        public int StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }
    }
}