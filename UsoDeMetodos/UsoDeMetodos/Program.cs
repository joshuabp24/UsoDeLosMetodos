using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---SIGA--INSTRUCCIONES--PARA--GENERAR--SU--KARDEX---");
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese su nombre completo");
            string Nombre = Console.ReadLine();        
            Console.WriteLine("Ingrese su numero de control");
            string NoControl = Console.ReadLine();
            Console.WriteLine("Ingrese numero de materias que llevo en primer semestre");
            int M = Convert.ToInt32(Console.ReadLine());
            string[] MateriasPrimer = new string[M];
            double[] PromediosPrimer = new double[M];
            for (int i = 0; i < M; i++)
            {
                Console.WriteLine("Ingrese materia");
                MateriasPrimer[i] = Console.ReadLine();
                Console.WriteLine("Ingrese su promedio en " + MateriasPrimer[i]);
                PromediosPrimer[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Ingrese numero de materias que llevo en segundo semestre");
            int M2 = Convert.ToInt32(Console.ReadLine());
            string[] MateriaSegundo = new string[M2];
            double[] PromedioSegundo = new double[M2];
            for (int i = 0; i < M2; i++)
            {
                Console.WriteLine("Ingrese materia");
                MateriaSegundo[i] = Console.ReadLine();
                Console.WriteLine("Ingrese su promedio en " + MateriaSegundo[i]);
                PromedioSegundo[i] = Convert.ToDouble(Console.ReadLine());
            }
            Kardex();
            void Kardex()
            {
                Console.Clear();
                double Resultado1=0;
                for (int i = 0; i < M; i++)
                {
                    Resultado1 = Resultado1 + PromediosPrimer[i];
                }
                Resultado1 = Resultado1 / M;
                
                double Resultado2 = 0;
                for (int i = 0; i < M2; i++)
                {
                    Resultado2 = Resultado2 + PromedioSegundo[i];
                }
                Resultado2 = Resultado2 / M2;
                Console.WriteLine("---KARDEX---");
                Console.WriteLine(" ");
                Console.WriteLine("Alumno");
                Console.WriteLine("Nombre: "+Nombre);
                Console.WriteLine("NoControl: " + NoControl);             
                Console.WriteLine(" ");
                Console.WriteLine("Primer semestre");
                for (int i = 0; i < M; i++)
                {
                    Console.WriteLine(MateriasPrimer[i]+": "+PromediosPrimer[i]);
                }
                Console.WriteLine("Promedio general: " + Resultado1);
                Console.WriteLine(" ");
                Console.WriteLine("Segundo semestre");
                for (int i = 0; i < M2; i++)
                {
                    Console.WriteLine(MateriaSegundo[i]+": "+PromedioSegundo[i]);
                }
                Console.WriteLine("Promedio general: " + Resultado2);
            }
            Console.ReadKey();
        }
    }
}
