using System;
using System.Collections.Generic;

namespace ProgramacionUno
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Examen Final Programacion Uno: Dario Zubaray\n");

            String Enunciado = "\"\"Usted dispone de 2 vectores (ya cargados) con datos de no más de 30 ventas de productos, con los campos: \n\n" +
            "Cód Producto vendido (1 a 8) y \n" +
            "Monto de la venta (entero en miles de U$S), \n\n" +
            "ordenado por estos campos (es decir primero por cód de producto vendido y ante igualdad el desempate es por menor monto de la venta). \n" +
            "\n- Se pide aparear los conjuntos generando un tercer vector o un archivo con la totalidad de elementos de ambos conjuntos " +
            "manteniendo el orden de cód de producto y monto de venta.\"\"\n";

            Console.WriteLine(Enunciado);

            List<Producto> ventas1 = GetProductos1();

            List<Producto> ventas2 = GetProductos2();
            /*
            int[] vProds1 = { 1, 1, 1, 2, 2, 3, 3, 3, 4 };
            int[] vMontos1 = { 2, 3, 6, 4, 5, 4, 6, 7, 3 };
            int[] vProds2 = { 1, 1, 3, 3, 4, 4, 5, 5, 5 };
            int[] vMontos3 = { 2, 3, 2, 2, 3, 5, 2, 3, 6 };
            */
            List<Producto> resultado = AparearVentas(ventas1, ventas2);

            // Mostrar resultado
            Console.WriteLine("\nVentas apareadas:");
            Console.WriteLine("===================");
            foreach (var venta in resultado)
            {
                Console.WriteLine(venta);
            }


            Console.WriteLine("\nFin.");
            Console.Read();
        }

        static List<Producto> AparearVentas(List<Producto> v1, List<Producto> v2)
        {
            List<Producto> resultado = new List<Producto>();
            int i = 0, j = 0;

            while (i < v1.Count && j < v2.Count)
            {
                Producto venta1 = v1[i];
                Producto venta2 = v2[j];

                // Apareo por codigo, despues monto
                if (venta1.CodigoProducto < venta2.CodigoProducto ||
                   (venta1.CodigoProducto == venta2.CodigoProducto && venta1.MontoVenta <= venta2.MontoVenta))
                {
                    resultado.Add(venta1);
                    i++;
                }
                else
                {
                    resultado.Add(venta2);
                    j++;
                }
            }

            // El resto de productos
            while (i < v1.Count)
            {
                resultado.Add(v1[i]);
                i++;
            }

            while (j < v2.Count)
            {
                resultado.Add(v2[j]);
                j++;
            }

            return resultado;
        }

        static List<Producto> GetProductos1()
        {
            Console.WriteLine("GetProductos1: \n");
            List < Producto > productos = new List<Producto>
            {
                new Producto(1, 2),
                new Producto(1, 3),
                new Producto(1, 6),
                new Producto(2, 4),
                new Producto(2, 5),
                new Producto(3, 4),
                new Producto(3, 6),
                new Producto(3, 7),
                new Producto(4, 3)
            };

            foreach (var venta in productos)
            {
                Console.WriteLine(venta);
            }
            return productos;
        }

        static List<Producto> GetProductos2()
        {
            Console.WriteLine("\nGetProductos2: \n");
            List<Producto> productos = new List<Producto>
            {
                new Producto(1, 2),
                new Producto(1, 3),
                new Producto(3, 2),
                new Producto(3, 2),
                new Producto(4, 3),
                new Producto(4, 5),
                new Producto(5, 2),
                new Producto(5, 3),
                new Producto(5, 6)
            };

            foreach (var venta in productos)
            {
                Console.WriteLine(venta);
            }
            return productos;
        }
    }
}
