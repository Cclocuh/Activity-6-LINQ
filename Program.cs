using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // make some test scores 
            int[] scores = new[] { 50, 66, 90, 81, 77, 45, 0, 100, 99, 72, 87, 85, 81, 80, 77, 74, 95, 97 };

            // print the scores
            foreach (var individualScore in scores)
            {
                Console.WriteLine("One of the scores was {0}", individualScore);
            }

            // pause to see the output before closing 
            Console.ReadLine();

            // use a LINQ statement to filter the list.
            var theBestStudents = 
                from individualScore in scores
                where individualScore > 90
                select individualScore;

            // print only the bestscores
            foreach (var individualScore in theBestStudents)
            {
                Console.WriteLine("One of the BEST scores was {0}", individualScore);
            }

            // pause to see the output before closing 
            Console.ReadLine();

            // use LINQ to sort the results 
            var sortedScores = 
                from individualScore in scores
                orderby individualScore
                select individualScore;

            // print the sorted list
            foreach (var individualScore in sortedScores)
            {
                Console.WriteLine("One of the scores was {0}", individualScore);
            }

            // pause to see the output before closing
            Console.ReadLine();

            // Print a list of only the B students (scores between 80% and 89%) in ascending order
            var bStudent =
                from individualScore in scores
                where individualScore > 80 && individualScore <89
                select individualScore;

            // print only b students score 
            foreach ( var individualScore in bStudent)
            {
                Console.WriteLine(individualScore);
            }

            // pause to see the output before closing
            Console.ReadLine();

            // Create an arraylist of students and demonstrate the use of LINQ on the new list
            ArrayList students = new ArrayList();
            students.Add(new Student("Terry", 34, 82));
            students.Add(new Student("Calvin", 32, 95));
            students.Add(new Student("Elizabeth", 25, 93));
            students.Add(new Student("Shondell", 27, 66));
            students.Add(new Student("Dorah", 29, 100));
            students.Add(new Student("Charlie", 20, 85));
            students.Add(new Student("David", 21, 89));
            students.Add(new Student("Emily", 18, 75));
            students.Add(new Student("Frank", 23, 85));

            // Sort the students by grade using LINQ
            var sortedStudents = 
                from Student student in students
                orderby student
                select student;
            
            //Console.WriteLine("Sorted student:");
            foreach (Student student in sortedStudents)
            {
                //Console.WriteLine(student.Name + ", age " + student.Age + ", grade " + student.Grade);
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
            }

            Console.ReadLine();
        }
    }
}
