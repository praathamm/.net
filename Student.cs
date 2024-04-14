using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
    {
        class Student
        {
            long prn;
            int java, c, html, total;
            float percentage;

            public Student(long p, int j, int cs, int h)
            {
                prn = p;
                java = j;
                c = cs;
                html = h;
            }

            public void get_total()
            {
                total = java + html + c;
            }

            public void get_percentage()
            {
                percentage = total * 100 / 300f;
            }

            public string Disp()
            {

                return string.Format("PRN={0} Total={1} Percentage={2}", prn, total, percentage);
            }


        }
    }

