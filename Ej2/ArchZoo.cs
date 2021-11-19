
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;

namespace Ej2{

    class ArchZoo{

        //->Atributtes

        private string nombre;

        //->Constructor

        public ArchZoo(string n){
            nombre=n;
        }

        //-> File Management Methods

        public void crear(){

            if(System.IO.File.Exists(nombre)){

                Console.Write("\nDesea Eliminar el Archivo? s/n ~> ");
                
                if(Console.ReadKey().KeyChar=='s'){
                    Console.WriteLine("\nArchivo ELIMINADO!!");
                    System.IO.File.Delete(nombre);
                }else{
                    Console.WriteLine("\nEl archivo NO fue eliminado!");
                }

            }else{
                Console.WriteLine("\nEl archivo No existe!");
            }

        }

        public void adicionar(){

            Stream arch=File.Open(nombre,FileMode.Append);

            BinaryWriter escribe=new BinaryWriter(arch);

            Zoologico z=new Zoologico();   

            try{

                do{

                    z.leer();
                    z.escribir(escribe); 
                    Console.Write("\nContinuar añadiendo registros? s/n ~> ");
    
                }while(Console.ReadKey().KeyChar=='s');
            }

            catch(Exception){
                Console.WriteLine("\nFallo en adicionar Objeto!");
            }

            finally{
                arch.Close();
            }

        }

        public void listar(){

            Stream arch=File.Open(nombre, FileMode.OpenOrCreate);

            BinaryReader lee=new BinaryReader(arch);

            Zoologico z=new Zoologico();

            try{

                while(true){

                    z.lectura(lee);
                    z.mostrar();

                }
            }
            
            catch(Exception){
                Console.Write("\nFin del archivo...");
            }

            finally{
                arch.Close();
            }

        }
    }
}