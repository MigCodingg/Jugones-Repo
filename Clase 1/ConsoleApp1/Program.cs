using System;

public class Program
{
    public static void Main()
    {
        //escribir en la consola
        string helloworld = "Hello World :)";
        Console.WriteLine(helloworld);

        int edad = 43;
        Console.WriteLine("La persona tiene " + edad + " años");

        //sumar numeritos
        int numero1 = 25;
        int numero2 = 13;
        int ValorSuma1 = numero1 + numero2;
        Console.WriteLine(ValorSuma1);

        //sumar decimalitos
        int numero3 = 36;
        double numero4 = 16.5;
        double ValorSuma2 = numero3 + numero4;
        Console.WriteLine(ValorSuma2);

        //juntar palabritas
        string frase1 = "Happy ";
        string frase2 = "Birthday!";
        string frasecompleta = frase1 + frase2;
        Console.WriteLine(frasecompleta);

        //escribir algo en la consola y recibir respuesta
        Console.WriteLine("Nombre:");
        string nombreInput = Console.ReadLine();
        Console.WriteLine("Buenas " + nombreInput +
         ", tu nombre tiene " + nombreInput.Length + " letras!");

        Console.WriteLine("Ahora dime dos numeros!");
        string numero5 = Console.ReadLine();
        string numero6 = Console.ReadLine();
        int numero5int = Convert.ToInt32(numero5);
        int numero6int = Convert.ToInt32(numero6);
        int suma1 = numero5int + numero6int;
        int resta1 = numero5int - numero6int;
        int multi1 = numero5int * numero6int;
        Console.WriteLine("Pues mira, tus numeros suman " + suma1
              + ", restan " + resta1 + " y multiplican " + multi1);
        // como la linea es muy larga, no cerramos con ; sino que seguimos una linea más abajo.

        //numero aleatorio (como empieza a contar en un rango "del 1 al 5" contando desde 0 al 4, le sumamos el 1.)
        Console.WriteLine("Oye, adivina a que numero estoy pensando del 1 al 5!");
        string numerito = Console.ReadLine();
        Random random = new Random();
        int numeroAleatorio = random.Next(5);
        int suma2 = numeroAleatorio + 1;
        int numInt = Convert.ToInt32(numerito);
        Console.WriteLine(numInt == suma2);
        Console.WriteLine("El numero que había pensado es " + suma2);