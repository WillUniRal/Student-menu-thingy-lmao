using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public class Grade
        {
            public char letter;
            public Grade(char g)
            {
                char[] validGrades = { 'A', 'B', 'C', 'D', 'E', 'F', 'U' };
                foreach (char grade in validGrades)
                {
                    if (grade == char.ToUpper(g))
                    {
                        letter = char.ToUpper(g);
                        return;
                    }
                }
                letter = 'U';
            }
        }
        public Grade grade { get; set; }

        public Student(string name, int id, Grade _grade)
        {
            Name = name;
            Id = id;
            grade = _grade;
        }


    }
}

