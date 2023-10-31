using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace repasoLinq.Clases
{
    public class Linq02
    {
        List<Student> _student = new List<Student>()
        {
            new Student(){Id = 123,Name = "Iron Man",Age = 18},
            new Student(){Id = 124,Name = "Iron Man",Age = 19},
            new Student(){Id = 125,Name = "Iron Man",Age = 17}
        };
        public void PrintData()
        {
            var teenPerson = _student.Where(s => s.Age > 12 && s.Age < 20).ToList<Student>();
            teenPerson.ForEach(tp => Console.WriteLine($"{tp.Name}"));
        }
    }
}