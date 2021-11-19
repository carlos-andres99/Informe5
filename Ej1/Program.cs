using System;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArchRefri archivo=new ArchRefri(@"/home/andres/2-2021/lab-121/Informe5/Ej1/ArchivoRefri.dat");

            bool sw=true;
        
            while(sw){

                Console.WriteLine(" ");
                Console.WriteLine("====================MENU====================");
                Console.WriteLine(" ");
                Console.WriteLine("1) Crear");
                Console.WriteLine("2) Adicionar");
                Console.WriteLine("3) Listar");
                Console.WriteLine("4) FechaVencimiento x");
                Console.WriteLine("5) Menor Precio ");
                Console.WriteLine("6) Verificar si existe alimento x");
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
                    
                    case '4':
                        Console.Write("\nInt. FechaVen DD/MM/AA: ");
                        string fv=Console.ReadLine();
                        bool sw2=archivo.fechVen(fv);
                        if(!sw2){
                            Console.WriteLine("No extiste ningun alimento con fecha de vencimiento: "+fv);
                        }
                        break;
                    
                    case '5':
                        archivo.menor();
                        break;

                    case '6':
                        Console.Write("\nInt. nombre de alimento para buscar: ");
                        string nom=Console.ReadLine();
                        bool sw3=archivo.verifAlx(nom);
                        if(sw3){
                            Console.WriteLine("El alimento "+nom+" SI existe!");
                        }else{
                            Console.WriteLine("El alimento "+nom+" NO existe!");
                        }
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
