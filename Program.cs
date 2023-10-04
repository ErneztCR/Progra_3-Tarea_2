using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un menu para que el usuario pueda seleccionar el ejercicio que desea ejecutar usando do-while
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Seleccione el ejercicio que desea ejecutar\n");
                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 2");
                Console.WriteLine("3. Ejercicio 3");
                Console.WriteLine("4. Salir");
                Console.WriteLine(" ");
                Console.Write("Ingrese la opcion que desea ejecutar: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Ejercicio1();
                        break;
                    case 2:
                        Ejercicio2();
                        break;
                    case 3:
                        Ejercicio3();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Gracias por usar el programa");
                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("La opcion ingresada no es valida");
                        Console.ReadLine();
                        break;
                }

            } while (opcion != 4);

        }

        static void Ejercicio1()
        {
            //Programa para una tienda que vende camisas, si la persona compra 1 camisa el precio es al costo
            //si la persona compra entre 2 y 5 camisas se le aplica un descuento del 15%
            //si la persona compra mas de 5 camisas se le aplica un descuento del 20%
            // el sistema debe solicitar la cantidad de camisas a comprar y el precio de cada una

            // Declarar las variables
            int cantidad;
            float precio;
            float total;
            float descuento;
            float totalPagar;

            // Solicitar la cantidad de camisas a comprar
            Console.Clear();
            Console.Write("Ingrese la cantidad de camisas a comprar: ");
            cantidad = int.Parse(Console.ReadLine());

            // Solicitar el precio de cada camisa
            Console.Clear();
            Console.Write("Ingrese el precio de cada camisa: ¢");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            // Calcular el total a pagar
            total = cantidad * precio;

            // Calcular el descuento
            if (cantidad == 1)
            {
                descuento = 0;
            }
            else if (cantidad >= 2 && cantidad <= 5)
            {
                descuento = total * 0.15f;
            }
            else
            {
                descuento = total * 0.20f;
            }

            // Calcular el total a pagar con descuento
            totalPagar = total - descuento;

            // Mostrar el total a pagar
            Console.Clear();
            Console.WriteLine($"El total a pagar es: ¢{totalPagar}\n");

            // Utilizando un if muestre el descuento si este es mayor a 0
            if (cantidad >= 2 && cantidad <= 5)
            {
                Console.WriteLine($"Obtuvo un descuento del 15%, usted ahorro: ¢{descuento}\n");
            }
            if (cantidad >= 6)
            {
                Console.WriteLine($"Obtuvo un descuento del 20%, usted ahorro: ¢{descuento}\n");
            }

            Console.WriteLine($"***GRACIAS POR SU COMPRA***");

            // Para que no se cierre la consola
            Console.ReadLine();

        }

        static void Ejercicio2()
        {

            /*
             Desarrolle un programa en C# que solicite el nombre y carnet de un estudiante, el programa debe calcular el promedio final para un estudiante del curso de Programación 1,
             basadose en los datos del, quiz 1, quiz 2, quiz 3, tarea 1, tarea 2, tarea 3, examen 1, examen 2 y examen 3 que el programa debe solicitar que uno ingrese. 
             Los quices tienen un valor de un 25%, las tareas un valor de 30%  los examenes un 45%.
             El programa tiene que calcular el promedio final y reportar al final que uno ingrese esos datos,
             el carnet, nombre, porcentaje de quices obtenido basado en las notas obtenidas, porcentaje de tareas basado en las notas obtenidas, porcentaje de exámenes basado en las notas obtenidas, 
             promedio final y condición del estudiante. La condición del estudiante esta con base a: Si el promedio 
             final es mayor o igual a 70 “Aprobado”. Si el promedio final es mayor o igual a 50 y menor que 
             70 “Aplazado” y si el promedio final es menor que 50 “Reprobado”. 
             */

            // Declaramos las variables
            string carnet;
            string nombre;
            int quiz1;
            int quiz2;
            int quiz3;
            int tarea1;
            int tarea2;
            int tarea3;
            int examen1;
            int examen2;
            int examen3;

            // Solicitamos los datos del estudiante
            Console.Clear();
            Console.Write("Ingrese el carnet del estudiante: ");
            carnet = Console.ReadLine();
            Console.Write("Ingrese el nombre del estudiante: ");
            nombre = Console.ReadLine();
            Console.Clear();
            Console.Write("Ingrese la calificación del quiz 1: ");
            quiz1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Ingrese la calificación del quiz 2: ");
            quiz2 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Ingrese la calificación del quiz 3: ");
            quiz3 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Ingrese la calificación de la tarea 1: ");
            tarea1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Ingrese la calificación de la tarea 2: ");
            tarea2 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Ingrese la calificación de la tarea 3: ");
            tarea3 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Ingrese la calificación del examen 1: ");
            examen1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Ingrese la calificación del examen 2: ");
            examen2 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Ingrese la calificación del examen 3: ");
            examen3 = int.Parse(Console.ReadLine());

            // Calculamos los porcentajes de cada componente
            int porcentajeQuices = (quiz1 + quiz2 + quiz3) / 3 * 25 / 100;
            int porcentajeTareas = (tarea1 + tarea2 + tarea3) / 3 * 30 / 100;
            int porcentajeExamenes = (examen1 + examen2 + examen3) / 3 * 45 / 100;

            // Calculamos el promedio final
            int promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;

            // Determinamos la condición del estudiante
            string condicion;
            if (promedioFinal >= 70)
            {
                condicion = "Aprobado";
            }
            else if (promedioFinal >= 50)
            {
                condicion = "Aplazado";
            }
            else
            {
                condicion = "Reprobado";
            }

            // Imprimimos los resultados
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Carnet: " + carnet);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Porcentaje de quices: " + porcentajeQuices + " / 25");
            Console.WriteLine("Porcentaje de tareas: " + porcentajeTareas + " / 30");
            Console.WriteLine("Porcentaje de exámenes: " + porcentajeExamenes + " / 45");
            Console.WriteLine("Promedio final: " + promedioFinal);
            Console.WriteLine(" ");
            Console.WriteLine("Condición: " + condicion);

            Console.ReadLine();

        }

        static void Ejercicio3()
        {

            /*
            Realice un programa en C# que con solo proporcionarle la cantidad de artículos dé como resultado el precio y el total.
            Si le compran 10 productos o menos, el precio por producto es de $20. Si le compran más de 10 artículos, el precio es de $15 por artículo.
            */

            // Declaramos las variables
            int cantidad;
            double precioUnitario;
            double precioTotal;

            // Solicitamos la cantidad de artículos
            Console.Clear();
            Console.Write("Ingrese la cantidad de artículos: ");
            cantidad = int.Parse(Console.ReadLine());

            // Calculamos el precio unitario
            if (cantidad <= 10)
            {
                precioUnitario = 20;
            }
            else
            {
                precioUnitario = 15;
            }

            // Calculamos el precio total
            precioTotal = cantidad * precioUnitario;

            // Imprimimos los resultados
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Cantidad: " + cantidad);
            Console.WriteLine("Precio unitario: $" + precioUnitario);
            Console.WriteLine("Precio total: $" + precioTotal);

            Console.ReadLine();

        }
    }
}
