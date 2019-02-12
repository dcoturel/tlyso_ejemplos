﻿using System;

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
                case 8:
                    ejercicio8();
                    break;
                case 9:
                    ejercicio9();
                    break;
                case 10:
                    ejercicio10();
                    break;
                case 11:
                    ejercicio11();
                    break;
                case 12:
                    ejercicio12();
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

        private static void ejercicio6()
        {
            int lado1;
            int lado2;
            int lado3;

            Console.WriteLine("Ingrese lado 1");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese lado 2");
            lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese lado 3");
            lado3 = Convert.ToInt32(Console.ReadLine());

            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triangulo ingresado es equilatero");
            }
            else if ((lado1 == lado2 && lado1 != lado3) || (lado1 == lado3 && lado1 != lado2) || (lado2 == lado3 && lado1 != lado2))
            {
                Console.WriteLine("El triangulo es isosceles");
            }
            else
            {
                Console.WriteLine("El triangulo es escaleno");
            }

            Console.WriteLine("Press any key");
            Console.Read();

        }

        private static void ejercicio7()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("10 x " + i + " = " + i * 10);
            }

            Console.WriteLine("Press any key");
            Console.Read();
        }

        private static void ejercicio8()
        {
            double total = 0;
            double importe;
            String seguir = "S";

            do
            {
                Console.WriteLine("Ingrese el importe de la factura:");
                importe = Convert.ToDouble(Console.ReadLine());
                total = total + importe;
                Console.WriteLine("Desea continuar la carga de facturas? Ingrese S para indicar que si");
                seguir = Console.ReadLine();
            } while (seguir.Equals("S"));


            Console.WriteLine("El total de facturas ingresadas es " + total);
            Console.WriteLine("Press any key");
            Console.Read();

        }

        private static void ejercicio9()
        {
            String nombre = "";
            double jornalPorHora = 0;
            double horasTrabajadas = 0;

            do
            {
                Console.WriteLine("Ingrese el nombre del empleado");
                nombre = Console.ReadLine();
                if (nombre.Equals(""))
                {
                    Console.WriteLine("El nombre no puede quedar vacio");
                }
            } while (nombre.Equals(""));

            do
            {
                Console.WriteLine("Ingrese el jornal por hora");
                jornalPorHora = Convert.ToDouble(Console.ReadLine());
                if (jornalPorHora == 0)
                {
                    Console.WriteLine("Ingrese un valor mayor a 0");
                }
            } while (jornalPorHora == 0);

            do
            {
                Console.WriteLine("Ingrese las horas trabajadas");
                horasTrabajadas = Convert.ToDouble(Console.ReadLine());
                if (horasTrabajadas == 0)
                {
                    Console.WriteLine("Ingrese un valor mayor a 0");
                }
            } while (horasTrabajadas == 0);

            Console.WriteLine("Empleado: " + nombre);
            Console.WriteLine("Sueldo bruto: " + jornalPorHora * horasTrabajadas);
            Console.WriteLine("Retencion jubilacion: " + (jornalPorHora * horasTrabajadas) * 0.11);
            Console.WriteLine("Retencion otros conceptos: " + (jornalPorHora * horasTrabajadas) * 0.07);
            Console.WriteLine("Total retenciones: " + (jornalPorHora * horasTrabajadas) * 0.18);
            Console.WriteLine("Sueldo neto a cobrar: " + ((jornalPorHora * horasTrabajadas) - (jornalPorHora * horasTrabajadas * 0.18)));
            Console.WriteLine("Press any key");
            Console.Read();
        }

        private static void ejercicio10()
        {
            String registro, registroNotaMaxima = "", registroNotaMinima = "", continuar = "";
            int nota = -1, notaMaxima = -1, notaMinima = 11;

            do
            {
                registro = "";
                nota = -1;
                do
                {
                    Console.WriteLine("Ingrese numero de registro:");
                    registro = Console.ReadLine();
                    if (registro.Equals(""))
                    {
                        Console.WriteLine("Debe ingresar un valor");
                    }
                } while (registro.Equals(""));

                do
                {
                    Console.WriteLine("Ingrese una nota entre 0 y 10");
                    nota = Convert.ToInt32(Console.ReadLine());
                    if (nota < 0 || nota > 10)
                    {
                        Console.WriteLine("La nota debe estar entre 0 y 10");
                    }
                } while (nota < 0 || nota > 10);

                if (nota < notaMinima)
                {
                    notaMinima = nota;
                    registroNotaMinima = registro;
                }

                if (nota > notaMaxima)
                {
                    notaMaxima = nota;
                    registroNotaMaxima = registro;
                }

                do
                {
                    Console.WriteLine("Desea continuar? Ingrese S o N");
                    continuar = Console.ReadLine();
                    if (!continuar.Equals("S") && !continuar.Equals("N"))
                    {
                        Console.WriteLine("Ingrese S o N");
                    }
                } while (!continuar.Equals("S") && !continuar.Equals("N"));
            } while (continuar.Equals("S"));

            Console.WriteLine("Nota maxima: " + notaMaxima + " - " + registroNotaMaxima);
            Console.WriteLine("Nota minima: " + notaMinima + " - " + registroNotaMinima);

            Console.WriteLine("Press any key");
            Console.Read();
        }

        private static void ejercicio11()
        {
            String numeroFactura = "", facturaMaxima = "", facturaMinima = "";
            double importe = 0, importeTotal = 0, importeMaximo = 0, importeMinimo = 0;
            int contador = 0;
            String continuar = "S";

            do
            {
                numeroFactura = "";
                importe = 0;
                do
                {
                    Console.WriteLine("Ingrese numero de factura:");
                    numeroFactura = Console.ReadLine();
                    if (numeroFactura.Equals(""))
                    {
                        Console.WriteLine("Debe ingresar un valor");
                    }
                } while (numeroFactura.Equals(""));

                do
                {
                    Console.WriteLine("Ingrese una importe positivo para la factura");
                    importe = Convert.ToDouble(Console.ReadLine());
                    if (importe <= 0)
                    {
                        Console.WriteLine("El importe debe ser positivo");
                    }
                } while (importe <= 0);

                if (contador == 0)
                {
                    facturaMaxima = numeroFactura;
                    facturaMinima = numeroFactura;
                    importeMaximo = importe;
                    importeMinimo = importe;
                }
                else
                {
                    if (importe < importeMinimo)
                    {
                        facturaMinima = numeroFactura;
                        importeMinimo = importe;
                    }

                    if (importe > importeMaximo)
                    {
                        facturaMaxima = numeroFactura;
                        importeMaximo = importe;
                    }
                }
                contador = contador + 1;
                importeTotal = importeTotal + importe;

                do
                {
                    Console.WriteLine("Desea continuar? Ingrese S o N");
                    continuar = Console.ReadLine();
                    if (!continuar.Equals("S") && !continuar.Equals("N"))
                    {
                        Console.WriteLine("Ingrese S o N");
                    }
                } while (!continuar.Equals("S") && !continuar.Equals("N"));
            } while (continuar.Equals("S"));

            Console.WriteLine("Importe total: " + importeTotal);
            Console.WriteLine("Cantidad de facturas: " + contador);
            Console.WriteLine("Importe promedio: " + (importeTotal / contador));
            Console.WriteLine("Importe minimo: " + importeMinimo + " - " + facturaMinima);
            Console.WriteLine("Importe maxima: " + importeMaximo + " - " + facturaMaxima);

            Console.WriteLine("Press any key");
            Console.Read();
        }



        private static void ejercicio12()
        {
            const double kdTasaIva = 0.21;
            const int kiIndirectos = 100000;

            String codigoArticulo = "", articuloMasCaro = "", articuloMasBarato = "", articuloMasRentable = "";
            String nombreArticulo = "", nombreArticuloMasCaro = "", nombreArticuloMasBarato = "", nombreArticuloMasRentable = "";
            double costoMateriaPrima = 0, cantidadGramos = 0, porcentajeIndirectos = 0, porcentajeRentabilidad = 0;
            double costo = 0, precio = 0, rentabilidad = 0;
            double precioMinimo = 0, precioMaximo = 0, rentabilidadMaxima = 0;
            String continuar = "S";
            int contador = 0;

            do
            {
                codigoArticulo = "";
                nombreArticulo = "";
                costoMateriaPrima = 0;
                cantidadGramos = 0;
                porcentajeIndirectos = 0;
                porcentajeRentabilidad = 0;

                do
                {
                    Console.WriteLine("Ingrese codigo de articulo:");
                    codigoArticulo = Console.ReadLine();
                    if (codigoArticulo.Equals(""))
                    {
                        Console.WriteLine("Debe ingresar un valor");
                    }
                } while (codigoArticulo.Equals(""));

                do
                {
                    Console.WriteLine("Ingrese nombre de articulo:");
                    nombreArticulo = Console.ReadLine();
                    if (nombreArticulo.Equals(""))
                    {
                        Console.WriteLine("Debe ingresar un valor");
                    }
                } while (nombreArticulo.Equals(""));


                do
                {
                    Console.WriteLine("Ingrese un importe positivo para el costo de materia prima");
                    costoMateriaPrima = Convert.ToDouble(Console.ReadLine());
                    if (costoMateriaPrima <= 0)
                    {
                        Console.WriteLine("El importe debe ser positivo");
                    }
                } while (costoMateriaPrima <= 0);

                do
                {
                    Console.WriteLine("Ingrese un valor positivo para la cantidad de gramos");
                    cantidadGramos = Convert.ToDouble(Console.ReadLine());
                    if (cantidadGramos <= 0)
                    {
                        Console.WriteLine("La cantidad debe ser positiva");
                    }
                } while (cantidadGramos <= 0);

                do
                {
                    Console.WriteLine("Ingrese un valor para el porcentaje de indirectos");
                    porcentajeIndirectos = Convert.ToDouble(Console.ReadLine());
                    if (porcentajeIndirectos <= 0 || porcentajeIndirectos > 100)
                    {
                        Console.WriteLine("El valor debe ser positivo y estar entre 0 y 100");
                    }
                } while (porcentajeIndirectos <= 0 || porcentajeIndirectos > 100);

                do
                {
                    Console.WriteLine("Ingrese un valor para el porcentaje de rentabilidad");
                    porcentajeRentabilidad = Convert.ToDouble(Console.ReadLine());
                    if (porcentajeRentabilidad <= 0 || porcentajeRentabilidad > 100)
                    {
                        Console.WriteLine("El valor debe ser positivo y estar entre 0 y 100");
                    }
                } while (porcentajeRentabilidad <= 0 || porcentajeRentabilidad > 100);

                costo = (costoMateriaPrima * cantidadGramos) + (kiIndirectos * porcentajeIndirectos / 100);
                precio = costo * ((porcentajeRentabilidad / 100) + 1) * (1 + kdTasaIva);
                rentabilidad = precio - costo;

                if (contador == 0)
                {
                    precioMaximo = precio;
                    nombreArticuloMasCaro = nombreArticulo;
                    articuloMasCaro = codigoArticulo;

                    precioMinimo = precio;
                    nombreArticuloMasBarato = nombreArticulo;
                    articuloMasBarato = codigoArticulo;

                    rentabilidadMaxima = rentabilidad;
                    nombreArticuloMasRentable = nombreArticulo;
                    articuloMasRentable = codigoArticulo;
                }
                else
                {
                    if (precio > precioMaximo)
                    {
                        precioMaximo = precio;
                        nombreArticuloMasCaro = nombreArticulo;
                        articuloMasCaro = codigoArticulo;
                    }
                    if (precio < precioMinimo)
                    {
                        precioMinimo = precio;
                        nombreArticuloMasBarato = nombreArticulo;
                        articuloMasBarato = codigoArticulo;
                    }
                    if (rentabilidad > rentabilidadMaxima)
                    {
                        rentabilidadMaxima = rentabilidad;
                        nombreArticuloMasRentable = nombreArticulo;
                        articuloMasRentable = codigoArticulo;
                    }
                }


                do
                {
                    Console.WriteLine("Desea continuar? Ingrese S o N");
                    continuar = Console.ReadLine();
                    if (!continuar.Equals("S") && !continuar.Equals("N"))
                    {
                        Console.WriteLine("Ingrese S o N");
                    }
                } while (!continuar.Equals("S") && !continuar.Equals("N"));

                contador = contador + 1;

            } while (continuar.Equals("S"));

            Console.WriteLine("Articulo mas caro: " + articuloMasCaro + " - " + nombreArticuloMasCaro);
            Console.WriteLine("Precio: " + precioMaximo);
            Console.WriteLine("Articulo mas barato: " + articuloMasBarato + " - " + nombreArticuloMasBarato);
            Console.WriteLine("Precio: " + precioMinimo);
            Console.WriteLine("Articulo mas rentable: " + articuloMasRentable + " - " + nombreArticuloMasRentable);



            Console.WriteLine("Press any key");
            Console.Read();

        }
    }
}
