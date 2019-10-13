using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversordeUnidades
{
    class Principal
    {

            Datos x = new Datos();
            int n = 0;
        public void Menu()
        {
           
            //Opciones del menu
            Console.WriteLine("Elige opcion:" + "\n"
            + "1.Centimetros a Metros" + "\n"
            + "2.Metros a Pulgadas" + "\n"
            + "3.Litros a Mililitros)" + "\n"
            + "4.Salir");
            Console.ReadLine();
            //Variable de opcion
            int o = 0;
            n = Convert.ToInt16(Console.ReadLine());

            //Opciones del menu con switch
            switch (o)
            {
                case 1:
                    Console.WriteLine("1.Centimetros a Metros");
                    Operaciones op = new Operaciones();
                    ConvertirCM();
                    break;

                case 2:
                    Console.WriteLine("2.Metros a Pulgadas");
                    ConvertirM();
                    break;

                case 3:
                    Console.WriteLine("3.Litros a Mililitros");
                    ConvetirLi();
                    break;


                case 4:
                    Console.Write("bye bye");
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("No se selecciono una opcion");
                    break;

            }
        }

        public void ConvertirCM()
        {
            Console.WriteLine("Ingrese centimetros: ");
            x.Centimetro = Convert.ToDouble(Console.ReadLine());

            x.Metro = x.Centimetro / 100;
            Console.WriteLine("El total en metros es: " + x.Metro);
        }

        public void ConvertirM()
        {
            Console.WriteLine("Ingrese metros:");
            x.Metro = Convert.ToDouble(Console.ReadLine());

            x.Pulgadas = x.Metro * 39.37;
            Console.WriteLine("El total de pulgadas es: " + x.Pulgadas);
        }

        public void ConvetirLi()
        {

            Console.WriteLine("Ingrese litros:");
            x.Litros = Convert.ToDouble(Console.ReadLine());

            x.Mililitros = x.Litros * 1000;

            Console.WriteLine("El totoal en Mililitros es: " + x.Mililitros);
        }
    }
}
