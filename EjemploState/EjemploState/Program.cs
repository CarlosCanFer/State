using System;
namespace EjemploState
{
    class Program
    {
        static void Main(string[] args)
        {            
            var objcontext = new EstadoAlarma(new EstadoDesactivado());
            string _caccion;
            
            Console.WriteLine("\n****Estado inicial Activo****");
           
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Acción a Realizar: ");
            Console.WriteLine("1.-Actvar");
            Console.WriteLine("2.-Desactivar");            
            _caccion = Console.ReadLine();
            
            switch (_caccion)
            {
                case "1":
                    objcontext.Activo();
                        break;
                    
                case "2":
                    objcontext.Desactivado();
                    break;
                    default: Console.WriteLine("Dato insertado incorrecto!!!");
                        break;
            }         

            Console.ReadKey();
        }
    }
}
