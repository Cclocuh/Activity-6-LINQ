using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQdemo
{
    class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        public Student(string name, int age, int grade) 
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public int CompareTo(Student other)
        {
            if (this.Grade == other.Grade) return 1;

            //Student students = other as Student;
            if (this.Grade == other.Grade)
            {
                return this.Name.CompareTo(other.Name);
            }
            return other.Grade.CompareTo(this.Grade);
        }

        public override string ToString()
        {
            return this.Grade.ToString() + "," + this.Name + "," + this.Age;
        }

    }
}
