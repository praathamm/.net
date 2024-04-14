using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 { 
    class Program { 
        static void Main(string[] args)
        {
            Student s1 = new Student(1, 40, 40, 40);
            Student s2 = new Student(2, 62, 77, 19);
            Console.WriteLine("Passing marks were 41");
            Student s3 = new Student(3, 2, 53, 83);
            s1.get_total();
            s1.get_percentage();
            Console.WriteLine(s1.Disp());


        }
    }
}
