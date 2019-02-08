using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int ejercicio = 0;
			Console.WriteLine("Ingrese el numero de ejercicio a ejecutar");
			ejercicio = Convert.ToInt32(Console.ReadLine());
			switch (ejercicio)
			{
				case 1:
					ejercicio1();
					break;
				case 2:
					ejercicio2();
					break;
				case 3:
					ejercicio3();
					break;
				case 4:
					ejercicio4();
					break;
                case 5:
                    ejercicio5();
                    break;
                case 6:
                    ejercicio6();
                    break;
                case 7:
                    ejercicio7();
                    break;
			}

		}

		private static void ejercicio1()
		{
			String nombre;
			String direccion;
			Console.WriteLine("Ingrese por favor su nombre:");
			nombre = Console.ReadLine();
			Console.WriteLine("Ingrese por favor su dirección:");
			direccion = Console.ReadLine();
			Console.WriteLine("Usted se llama " + nombre + " y vive en " + direccion);
			Console.WriteLine("Press any key");
			Console.Read();
		}

		private static void ejercicio2()
		{
			String nombre = "";
			String direccion = "";
			Console.WriteLine("Ingrese por favor su nombre:");
			while (nombre.Length == 0)
			{
				nombre = Console.ReadLine();
				if (nombre.Equals(""))
				{
					Console.WriteLine("Debe ingresar un valor para el nombre");
				}
			}

			Console.WriteLine("Ingrese por favor su dirección:");
			while (direccion.Length == 0)
			{
				direccion = Console.ReadLine();
				if (direccion.Equals(""))
				{
					Console.WriteLine("Debe ingresar un valor para la direccion");
				}
			}

			Console.WriteLine("Usted se llama " + nombre + " y vive en " + direccion);
			Console.WriteLine("Press any key");
			Console.Read();
		}

		private static void ejercicio3()
		{
			double numero1;
			double numero2;
			double promedio;
			Console.WriteLine("Ingrese un numero entre 0 y 10");
			do
			{
				numero1 = Convert.ToDouble(Console.ReadLine());
				if (numero1 < 0 || numero1 > 10)
				{
					Console.WriteLine("Dije entre 0 y 10...");
				}
			} while (numero1 < 0 || numero1 > 10);

			Console.WriteLine("Ingrese otro numero entre 0 y 10");
			do
			{
				numero2 = Convert.ToDouble(Console.ReadLine());
				if (numero2 < 0 || numero2 > 10)
				{
					Console.WriteLine("Dije entre 0 y 10...");
				}
			} while (numero2 < 0 || numero2 > 10);

			promedio = (numero1 + numero2) / 2;

			Console.WriteLine("El promedio entre los numeros ingresados es " + promedio);
			Console.WriteLine("Press any key");
			Console.Read();
		}

		private static void ejercicio4()
		{
			int horas;
			int minutos;
			int segundos;

			Console.WriteLine("Ingrese el valor para las horas");
			do
			{
				horas = Convert.ToInt32(Console.ReadLine());
				if (horas < 0 || horas > 23)
				{
					Console.WriteLine("Deberia estar entre 0 y 23...");
				}
			} while (horas < 0 || horas > 23);

			Console.WriteLine("Ingrese el valor para los minutos");
			do
			{
				minutos = Convert.ToInt32(Console.ReadLine());
				if (minutos < 0 || minutos > 59)
				{
					Console.WriteLine("Deberia estar entre 0 y 59...");
				}
			} while (minutos < 0 || minutos > 59);

			Console.WriteLine("Ingrese el valor para los segundos");
			do
			{
				segundos = Convert.ToInt32(Console.ReadLine());
				if (segundos < 0 || segundos > 59)
				{
					Console.WriteLine("Deberia estar entre 0 y 59...");
				}
			} while (segundos < 0 || segundos > 59);

			Console.WriteLine("La cantidad total de segundos es " + (horas * 60 * 60 + minutos * 60 + segundos) + "");

			Console.WriteLine("Press any key");
			Console.Read();
		}

		private static void ejercicio5()
		{
			String variable1;
			String variable2;
            String buffer;

            Console.WriteLine("Ingrese valor para variable1");
            variable1 = Console.ReadLine();

            Console.WriteLine("Ingrese valor para variable2");
            variable2 = Console.ReadLine();

            Console.WriteLine("variable1=" + variable1 + " - variable2=" + variable2);

            buffer = variable1;
            variable1 = variable2;
            variable2 = buffer;

            Console.WriteLine("variable1=" + variable1 + " - variable2=" + variable2);

            Console.WriteLine("Press any key");
			Console.Read();
		}

        private static void ejercicio6() {
            int lado1;
            int lado2;
            int lado3;

            Console.WriteLine("Ingrese lado 1");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese lado 2");
            lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese lado 3");
            lado3 = Convert.ToInt32(Console.ReadLine());

            if (lado1 == lado2 && lado2 == lado3) {
                Console.WriteLine("El triangulo ingresado es equilatero");
            } else if ((lado1 == lado2 && lado1 != lado3) || (lado1 == lado3 && lado1 != lado2) || (lado2 == lado3 && lado1 != lado2)) {
                Console.WriteLine("El triangulo es isosceles");
            } else {
                Console.WriteLine("El triangulo es escaleno");
            }

            Console.WriteLine("Press any key");
            Console.Read();

        }

        private static void ejercicio7()
        {
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("10 x " + i + " = " + i * 10);
            }

            Console.WriteLine("Press any key");
            Console.Read();
        }
    }
}
