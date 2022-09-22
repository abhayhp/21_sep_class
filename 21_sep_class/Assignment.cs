using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_sep_class
{
    internal class Assignment
    {
    }

    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Fees { get; set; }


        public override string ToString()
        {
            return $" Course Details: {Id} {Name} {Fees}";
        }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Location { get; set; }

        public override string ToString()
        {
            return $" Department Details: {Id} {Name} {Location}";
        }



    }
}
