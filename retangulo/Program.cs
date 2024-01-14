using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double basee, altura, area, perim, diag;
            
            Console.Write("Base do retangulo: ");
            basee = double.Parse(Console.ReadLine(),CI);
            Console.Write("Altura do retangulo: ");
            altura = double.Parse(Console.ReadLine(), CI);

            area = basee * altura; 
            perim = (2 * altura) + (2 * basee);
            diag = Math.Sqrt(basee * basee + altura * altura);

            Console.WriteLine("Area: " + area.ToString("F4", CI));
            Console.WriteLine("Perimetro = " + perim.ToString("F4", CI));
            Console.WriteLine("Diagonal = " + diag.ToString("F4", CI));

        }
    }
}
