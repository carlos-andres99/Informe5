using System;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
                       ArchZoo archivo=new ArchZoo(@"/home/andres/2-2021/lab-121/Informe5/Ej2/datosZoo.dat");

            bool sw=true;
        
            while(sw){
                Console.WriteLine(" ");
                Console.WriteLine("====================MENU====================");
                Console.WriteLine(" ");
                Console.WriteLine("1) Crear");
                Console.WriteLine("2) Adicionar");
                Console.WriteLine("3) Listar");
                Console.WriteLine("0) Salir");
                Console.WriteLine(" ");
                Console.WriteLine("============================================");
                
                Console.WriteLine(" ");
                Console.Write("Introduzca una opcion   ~> ");
            
                switch(Console.ReadKey().KeyChar){

                    case '1':
                        archivo.crear();
                        break;
                   
                    case '2':
                        archivo.adicionar();
                        break;
                   
                    case '3':
                        archivo.listar();
                        break;
                   
                    default:
                        Console.WriteLine("\nFIN DEL PROGRAMA");
                        sw=false;
                        break;
                }

            }
        }
    }
}
