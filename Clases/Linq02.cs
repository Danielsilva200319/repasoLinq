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
            new Student(){Id = 124,Name = "Steve",Age = 19},
            new Student(){Id = 125,Name = "Bill",Age = 17}
        };
        public void PrintData()
        {
            var teenPerson = _student.Where(s => s.Age > 12 && s.Age < 20).ToList<Student>();
            teenPerson.ForEach(tp => Console.WriteLine($"{tp.Name}"));
        }
        public void PrintDataQuery()
        {
            var teenAgerStudent = (from s in _student 
                                            where s.Age > 12 && s.Age <= 30 
                                            select new { s.Id, s.Name });
            foreach (var item in teenAgerStudent)
            {
                Console.WriteLine($"Id: {item.Id}   -->  Name: {item.Name}");
            }
        }
        public void PrintDataV3()
        {
            var result = _student.Where((s,i) => 
            {
                if(i % 2 == 0)
                    return true;
                return false;
            }).ToList();
            result.ForEach(rs => Console.WriteLine($"{rs.Name}"));
        }
        public List<Student> Order(char typeOrder)
        {
            List<Student> result;
            Console.Write("");
            switch (typeOrder)
            {
                case 'A':
                    result = _student.OrderBy(s => s.Name).ToList();
                    break;
                case 'B':
                    result = _student.OrderByDescending(s => s.Name).ToList();
                    break;
                default:
                    Console.WriteLine($"No se especifico el tipo de ordenamiento valido");
                    return result = new List<Student>();
            }
            return result;
        }
    }
}