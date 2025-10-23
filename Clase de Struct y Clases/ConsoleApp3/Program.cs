using System.Dynamic;

namespace ConsoleApp3
{
    class Animal
    {
        
        public string Nombre;
        public string Desplazamiento;
        public Animal(string nombre, string desplazamiento) 
        
        {
            Nombre = nombre;
            Desplazamiento = desplazamiento;
            
                
        }
        public virtual void Saludito()
        {
            Console.WriteLine($"Hola soy {Nombre} y me muevo {Desplazamiento} ");
        }
      



        }
        class Reptil : Animal
        {
                public Reptil(string Nombre, string Desplazamiento) : base(Nombre, Desplazamiento) 
                { 
        
                }
                public new void Saludito() 
                 {
            Console.WriteLine($"Que pasa soy: {Nombre} y me muevo con mis nunca antes visto: {Desplazamiento} ");
        }
        }
            
        class Mamifero : Animal 
        {
                public  Mamifero(string Nombre, string Desplazamiento) : base(Nombre, Desplazamiento) { }
                public new void Saludito()
                {
                    Console.WriteLine($"Buenas soy el mamifero: {Nombre} y me muevo con mis increibles: {Desplazamiento} ");
                }
        }
        class Ave : Animal
        {
                public Ave(string Nombre, string Desplazamiento) : base(Nombre, Desplazamiento) { }
                public new void Saludito()
                {
                    Console.WriteLine($"Buenas soy el Ave: {Nombre} y me muevo con mis increibles: {Desplazamiento} ");
                }
        }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            Reptil Reptil1 = new Reptil("ReptilPablo", "Las patitas");
            Mamifero Mamifero1 = new Mamifero("MamiferoAndres", "Las patotas");
            Ave Ave1 = new Ave("PajareteLuis", "Las alas");
            Ave1.Saludito();
            list.Add(Ave1);
            list.Add(Reptil1);
            list.Add(Mamifero1);
            foreach (Animal animal in list)
            {
                animal.Saludito();
            }

        }
    }
}
