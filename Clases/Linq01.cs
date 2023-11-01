using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repasoLinq.Clases
{
    public class Linq01
    {
        List<string> libros = new List<string>(){
            "Vb.Net Tutorial",
            "C# Tutorial",
            "TypeScript e-book"
        };
        public IEnumerable<string> listBookByName(string criterio)
        {
            return libros.Where(x => x.Contains(criterio));
        }
        public void PrintData()
        {
            Console.Write("Ingrese el criterio de busqueda: ");
            string criterio = Console.ReadLine();
            IEnumerable<string> data = listBookByName(criterio);
            Console.Clear();
            foreach (string item in data)
            {
                Console.WriteLine($"Se encontro: {item}");
            }
            Console.ReadKey();
        }
        public void Query()
        {
            Console.WriteLine($"Ingrese el criterio de busqueda: ");
            
            var criterio = Console.ReadLine();
            var expre = from x in libros where x.Contains(criterio) select x;
            foreach (string item in expre)
            {
                Console.WriteLine($"S encontro el libro {item}");
            }
        }
    }
}