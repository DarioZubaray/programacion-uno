using System;

namespace TP10_ApareoCorteControl
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("TP10 AFrankel – Apareo y Corte de Control");

            Console.WriteLine("\n1) Corte de control\n");
            //Inicializacion
            int[] CodP = { 12, 12, 12, 7, 7, 16, 16, 16, 3, 3, 3, 3 };
            int[] CantV = { 5, 10, 1, 8, 6, 4, 10, 6, 2, 6, 3, 1 };

            //Realizar el corte de control
            CorteDeControl(CodP, CantV);
            //Mostrar por pantalla
            /*
             CodP: 12 Total de unid vendidas: 16 (obtenido de 5+10+1)
             CodP: 7 Total de unid vendidas: 14 (obtenido de 8+6)
             CodP: 16 Total de unid vendidas: 20 (obtenido de 4+10+6)
             CodP: 3 Total de unid vendidas: 12 (obtenido de 2+6+3+1)
             */

            Console.WriteLine("\n2) Apareo\n");
            Venta[] conjunto1 =
            {
                new Venta { codP = 4, cantV = 7 },
                new Venta { codP = 7, cantV = 8 },
                new Venta { codP = 8, cantV = 1 },
                new Venta { codP = 11, cantV = 3 },
                new Venta { codP = 12, cantV = 4 },
                new Venta { codP = 14, cantV = 1 },
                new Venta { codP = 17, cantV = 9 },
                new Venta { codP = 19, cantV = 6 }
            };
            Venta[] conjunto2 =
            {
                new Venta { codP = 2, cantV = 6 },
                new Venta { codP = 3, cantV = 2 },
                new Venta { codP = 4, cantV = 5 },
                new Venta { codP = 6, cantV = 3 },
                new Venta { codP = 11, cantV = 8 },
                new Venta { codP = 13, cantV = 5 }
            };

            // Realizar apareo
            Apareo(conjunto1, conjunto2);

            Console.ReadKey();
        }

        static void CorteDeControl(int[] CodP, int[] CantV)
        {
            int codActual = CodP[0];
            int total = 0;

            for (int i = 0; i < CodP.Length; i++)
            {
                if (CodP[i] == codActual)
                {
                    total += CantV[i];
                }
                else
                {
                    Console.WriteLine($"CodP: {codActual} Total de unid vendidas: {total}");

                    codActual = CodP[i];
                    total = CantV[i];
                }
            }

            Console.WriteLine($"CodP: {codActual} Total de unid vendidas: {total}");
        }

        static void Apareo(Venta[] c1, Venta[] c2)
        {
            {
                int i = 0, j = 0;

                Console.WriteLine("CodP CantV");

                while (i < c1.Length && j < c2.Length)
                {
                    if (c1[i].codP <= c2[j].codP)
                    {
                        Console.WriteLine($"{c1[i].codP} {c1[i].cantV}");
                        i++;
                    }
                    else
                    {
                        Console.WriteLine($"{c2[j].codP} {c2[j].cantV}");
                        j++;
                    }
                }

                while (i < c1.Length)
                {
                    Console.WriteLine($"{c1[i].codP} {c1[i].cantV}");
                    i++;
                }

                while (j < c2.Length)
                {
                    Console.WriteLine($"{c2[j].codP} {c2[j].cantV}");
                    j++;
                }
            }
        }
    }
}
