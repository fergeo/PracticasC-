using System;
using System.Runtime.CompilerServices;

namespace MiPrimerProyecto
{
    internal class Program
    {
        //Ejercicio 1 - Precio de venta
        static void ejecicio1()
        {
            const float recargo = 15;
            float precioTotal;

            Console.WriteLine("Ingresa el precio del producto: ");
            string precio = Console.ReadLine();
            float precioProd = float.Parse(precio);

            precioTotal = precioProd * (recargo / 100 + 1);
            Console.WriteLine("El precio final es: " + precioTotal);
        }

        //Ejercicio 2
        static void ejercicio2()
        {
            int puntajeTotal, i;
            puntajeTotal = 0;

            Console.WriteLine("Ingrese el nombre del parcitipante");
            string nombre = Console.ReadLine();

            while (nombre != "FIN")
            {

                for (i = 0; i < 3; i++)
                {
                    Console.WriteLine("Ingrese el puntaje del juez");
                    string puntaje = Console.ReadLine();
                    puntajeTotal = puntajeTotal + int.Parse(puntaje);
                }

                Console.WriteLine("El puntaje del participante " + nombre + " es " + puntajeTotal);

                puntajeTotal = 0;

                Console.WriteLine("Ingrese el nombre del parcitipante");
                nombre = Console.ReadLine();
            }
        }

        //Ejercicio 3 - Modifica la salida de la resolución del punto 2.
        //e pide mostrar un mensaje que indique si cada participante llegó a la última etapa o no.
        static void ejercicio3()
        {
            int puntajeTotal, i;
            string llego;
            puntajeTotal = 0;


            Console.WriteLine("Ingrese el nombre del parcitipante");
            string nombre = Console.ReadLine();

            while (nombre != "FIN")
            {

                for (i = 0; i < 3; i++)
                {
                    Console.WriteLine("Ingrese el puntaje del juez");
                    string puntaje = Console.ReadLine();
                    puntajeTotal = puntajeTotal + int.Parse(puntaje);
                }

                if(puntajeTotal >= 80)
                {
                    llego = " y llego a la etapa final.";
                }
                else
                {
                    llego = " y no llego a la etapa final.";
                }

                Console.WriteLine("El puntaje del participante " + nombre + " es " + puntajeTotal + llego);

                puntajeTotal = 0;

                Console.WriteLine("Ingrese el nombre del parcitipante");
                nombre = Console.ReadLine();
            }
        }

        //Se trata de implementar un programa que sume los dígitos de un número entero no negativo de 4 dígitos.
        //Por ejemplo, la suma de los dígitos del 3433 es 13.  Para darle un poco más de emoción,
        //el programa no se limitará a escribir el resultado de la suma, sino que también escribirá
        //todos los sumandos utilizados: 3 + 4 + 3 + 3 = 13.
        static void ejercicio4()
        {
            int numero;
            
            Console.WriteLine("Ingrese un numero de 4 digitos: ");
            string num = Console.ReadLine();
            numero = int.Parse(num);
            while (numero < 999 && numero > 9999)
            {
                Console.WriteLine("Debe ingresar un numero positivo de 4(cuatro) digitos: ");
                num = Console.ReadLine();
                numero = int.Parse(num);
            }

            int decimaMil = numero / 1000;
            int centesima = (numero % 1000) / 100;
            int decima = (numero % 100) / 10;
            int unidad = numero - decimaMil * 1000 - centesima * 100 - decima * 10;
            
            numero = decimaMil + centesima + decima + unidad;

            Console.WriteLine("Los numeros en cuestion son: " + decimaMil + " + " + centesima + " + " + decima + " + " + unidad + " = " + numero);
         
        }

        //Resolver la consiga del punto 4 con la particularidad que el número puede tener cualquier cantidad de dígitos, es decir, puede ser un número de dos dígitos como un número de 6 dígitos.
        //Tomá la codificación anterior e introducí los cambios que sean necesarios.
        static void ejercicio5()
        {
            int numero, i, multipli, suma, multi;
            
            Console.WriteLine("Ingrese un numero: ");
            string num = Console.ReadLine();
            numero = int.Parse(num);
            while (numero < 0)
            {
                Console.WriteLine("Debe ingresar un numero: ");
                num = Console.ReadLine();
                numero = int.Parse(num);
            }

            multipli = 10;
            suma = 0;
            multi = 0;

            for(i = 0; i < num.Length; i++)
            {
                if( i == 0 )
                {
                    suma = suma + numero / 10;
                    multi = suma * 10;
                    Console.WriteLine("Salida1 " + suma);
                }
                else if( i == num.Length - 1)
                {
                    suma = suma + (numero - multi);   
                    Console.WriteLine("Salida2 " + suma);
                }
                else
                {
                    suma = suma + (numero % (multipli*10)) / multipli;
                    multi = multi + (suma * multipli);
                    Console.WriteLine("Salida3");
                }

                multipli = multipli * 10;
                Console.WriteLine("Salida " + suma + " " + multi);
            }

            
        }


        static void Main(string[] args)
        {
            //Ejecucion ejercicio 1
            //ejecicio1();

            //Ejecucion ejercicio 2
            //ejercicio2();

            //Ejecucion ejercicio 3
            //ejercicio3();

            //Ejecucion ejercicio 4
            //ejercicio4();

            //Ejecucion ejercicio 5
            ejercicio5();

        }
    }
}
