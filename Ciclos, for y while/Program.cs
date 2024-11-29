using System;

class Program
{
    static void Main()
    {
        int opcion, total, precio, moneda, cambio;
        total = 0;
        precio = 0;
        moneda = 0;
        cambio = 0;

        string mensajeBienvenida = "Bienvenido a la máquina expendedora.";
        string mensajeMenu = "1. Refresco....$10\n2. Jugo........$15\n3. Cerveza.....$30\nSelecciona un producto: ";
        string mensajePagar = "Por favor paga solo con monedas de $1, $5 y $10.";

        Console.WriteLine(mensajeBienvenida);
        Console.WriteLine(mensajeMenu);

        opcion = int.Parse(Console.ReadLine());

        string productoSeleccionado = "";
        if (opcion == 1)
        {
            productoSeleccionado = "Refresco";
            precio = 10;
        }
        else if (opcion == 2)
        {
            productoSeleccionado = "Jugo";
            precio = 15;
        }
        else if (opcion == 3)
        {
            productoSeleccionado = "Cerveza";
            precio = 30;
        }
        else
        {
            string mensajeError = "No se pudo procesar.";
            Console.WriteLine(mensajeError);
            return;
        }

        string mensajeProducto = $"Seleccionaste: {productoSeleccionado}, Precio: {precio} pesos.";
        Console.WriteLine(mensajeProducto);
        Console.WriteLine(mensajePagar);

        string historialMonedas = ""; // Variable que almacena todas las monedas introducidas

        while (total < precio)
        {
            Console.WriteLine("Introduce una moneda:");
            moneda = int.Parse(Console.ReadLine());
            historialMonedas += moneda + " "; // Guardar cada moneda en un historial

            if (moneda == 1 || moneda == 5 || moneda == 10)
            {
                total += moneda;
                string mensajeAcumulado = "Has acumulado: " + total + " pesos.";
                Console.WriteLine(mensajeAcumulado);
            }
            else
            {
                string mensajeInvalido = "Esta moneda no es válida. Solo se aceptan monedas de $1, $5 y $10.";
                Console.WriteLine(mensajeInvalido);
            }
        }

        if (total == precio)
        {
            string mensajeExito = "Proceso exitoso. Gracias por tu compra.";
            Console.WriteLine(mensajeExito);
        }
        else
        {
            cambio = total - precio;
            string mensajeCambio = "Tu cambio es de: " + cambio + " pesos.";
            Console.WriteLine(mensajeCambio);
        }

        // Mostrar historial de monedas al final
        string mensajeHistorial = "Monedas introducidas: " + historialMonedas;
        Console.WriteLine(mensajeHistorial);
    }
}