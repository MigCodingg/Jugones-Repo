
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dame un numero");
        string num = Console.ReadLine();
        int num1 = Convert.ToInt32(num);
        if (num1 > 0)
        {
            Console.WriteLine("El numero es positivo");
        }
        else if (num1 < 0)
        {
            Console.WriteLine("El numero es negativo");
        }
        else
        {
            Console.WriteLine("El numero es cero");
        }

        Console.WriteLine("Escoje: triangulo, cuadrado o circulo");
        string figura = Console.ReadLine();
        if (figura == "triangulo")
        {
            Console.WriteLine("  *  ");
            Console.WriteLine(" *** ");
            Console.WriteLine("*****");
        }
        else if (figura == "cuadrado")
        {
            Console.WriteLine("*****");
            Console.WriteLine("*   *");
            Console.WriteLine("*****");
        }
        else if (figura == "circulo")
        {
            Console.WriteLine("   **   ");
            Console.WriteLine(" *    * ");
            Console.WriteLine("   **   ");
        }
        else
        {
            Console.WriteLine("Bro esa no es una opción >:(");
        }

        Console.WriteLine("¿Piedra, papel o tijera?");
        string eleccionjugador = Console.ReadLine();
        Random eleccionbot = new Random();
        int eleccion = eleccionbot.Next(3);
        string bot;
        if (eleccion == 0)
        {
            bot = "piedra";
        }
        else if (eleccion == 1)
        {
            bot = "papel";
        }
        else
        {
            bot = "tijera";
        }
        if (bot == "papel")
        {
            if (eleccionjugador == "papel") 
            { 
                Console.WriteLine("¡Empate!");
            }
            else if (eleccionjugador == "tijera")
            {
                Console.WriteLine("¡Gana el jugador!)");
            }
            else if (eleccionjugador == "piedra")
            {
                Console.WriteLine("¡Gana el bot!");
            }
            else
            {
                Console.WriteLine("¡Trampa!");
            }
        }
        if (bot == "tijera")
        {
            if (eleccionjugador == "papel")
            {
                Console.WriteLine("¡Gana el bot!");
            }
            else if (eleccionjugador == "tijera")
            {
                Console.WriteLine("¡Empate!)");
            }
            else if (eleccionjugador == "piedra")
            {
                Console.WriteLine("¡Gana el jugador!");
            }
            else
            {
                Console.WriteLine("¡Trampa!");
            }
        }
        if (bot == "piedra")
        {
            if (eleccionjugador == "papel")
            {
                Console.WriteLine("¡Gana el jugador!");
            }
            else if (eleccionjugador == "tijera")
            {
                Console.WriteLine("¡Gana el bot!)");
            }
            else if (eleccionjugador == "piedra")
            {
                Console.WriteLine("¡Empate!");
            }
            else
            {
                Console.WriteLine("¡Trampa!");
            }
        }

        int i = 0;
        while (i <= 100)
        {
            Console.WriteLine(i);
            i++;
        }

        Console.WriteLine("Dime un numero");
        string numero = Console.ReadLine();
        int numero1 = Convert.ToInt32(numero);
        int resultado = 1;
        while (numero1 >= 1)
        {
            resultado = numero1 * resultado;
            numero1--;
        }
        Console.WriteLine("Tu resultado es " + resultado);
    }
}