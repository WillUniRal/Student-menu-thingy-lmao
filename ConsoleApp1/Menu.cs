using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Menu
    {
        public static void Task()
        {
            Student timmy = input();
            Console.WriteLine(timmy.Name);
            Console.WriteLine(timmy.Id);
            Console.WriteLine(timmy.grade.letter);
        }
        public static Student input()
        {
            Console.WriteLine("");
            string nam = Console.ReadLine();
            if (nam == null) nam = "Nameless";
            int id = Int32.Parse(Console.ReadLine());
            char G = Console.ReadKey().KeyChar;
            return new (nam, id, new Student.Grade(G));
        }
    }
}
