using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Operatii_cu_numere_mari
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger a = new BigInteger();
            BigInteger b = new BigInteger();
            BigInteger res = new BigInteger();

            Console.Write("Introduceti operatia pe care o doriti : (s pentru suma , sc pentru scadere ,in pentru inmultire , " +
                "imp pentru impartire , rad pentru radacina patrata sau r2 pentru ridicarea la putere ");
            Console.Write("Introduceti numerele : ");
            a = BigInteger.Parse(Console.ReadLine());
            b = BigInteger.Parse(Console.ReadLine());

            string operatie = Console.ReadLine();

            switch (operatie)
            {
                case "s":
                    res = a + b;
                    break;
                case "sc":
                    res = a - b;
                    break;
                case "in":
                    res = a * b;
                    break;
                case "imp":
                    res = a / b;
                    break;
                case "rad":
                    res = a;
                    while (res * res > a)
                    {
                        res = res-a;
                    }
                    break;
                case "r2":
                    res = a;
                    Console.Write("Introduceti la ce numar vreti sa il ridicati : ");
                    int rad = int.Parse(Console.ReadLine());

                    rad--;
                    while (rad != 0)
                    {
                        res *= a;
                        rad =rad- 1;
                    }
                    break;
                default:
                    Console.WriteLine("Ati introdus o operatie gresita");
                    break;
            }

                Console.WriteLine("Rezultatul este: {0} ",res);


        }
    }
}
