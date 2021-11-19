using System.Collections.Generic;
using System.Text;
using System.IO;
using System;

namespace Ej1{
    
    class ArchRefri{

        //-> Atributtes
        private string nombre;

        //->Constructor

        public ArchRefri(string n){nombre=n;}


        //-> Flie management Methods

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

            Alimento a=new Alimento();  //-> Creating a new class 

            try{

                do{

                    a.leer();
                    a.escribir(escribe);  //-> physical writing
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

            Alimento a=new Alimento();

            try{

                while(true){

                    a.lectura(lee);
                    a.mostrar();

                }
            }
            
            catch(Exception){
                Console.Write("\nFin del archivo...");
            }

            finally{
                arch.Close();
            }

        }


        //-------------->Methdos<------------------------

        //-----> b) Mostrar los alimentos con fecha de vencimiento x

        public Boolean fechVen(string x){
            
            Stream arch=File.Open(nombre, FileMode.OpenOrCreate);

            BinaryReader lee=new BinaryReader(arch);

            Alimento a=new Alimento();

            bool sw=false;
            try{

                while(true){
                    
                    a.lectura(lee);
                    if(a.FechaVencimiento==x){
                      a.mostrar();
                      sw=true;
                    }
                }

            }
            catch(Exception){
                Console.WriteLine("Fin del archivo...");
            }
            finally{
                arch.Close();
            }
            return sw;
        }


        //-----> c)  Mostrar los alimentos con menor precio


        public void menor(){

            Stream arch=File.Open(nombre, FileMode.OpenOrCreate);

            BinaryReader lee=new BinaryReader(arch);

            Alimento a=new Alimento();

            Alimento alimMenorPre=new Alimento();

            try{

                double men=10000000;
                while(true){

                    a.lectura(lee);
                    if(a.Precio<men){
                        alimMenorPre=a;
                    }
                }
            }
            catch{
                Console.WriteLine("\nEl alimento con menor precio es: ");
                alimMenorPre.mostrar();
                Console.WriteLine("Fin del archivo...");
            }
            finally{
                arch.Close();
            }

        }

        //-----> d) Verificar si existe un alimento con nombre x

        public Boolean verifAlx(string x){

            
            Stream arch=File.Open(nombre, FileMode.OpenOrCreate);

            BinaryReader lee=new BinaryReader(arch);

            Alimento a=new Alimento();

            bool sw=false;   
            try{

                while(true){
                    
                    a.lectura(lee);
                    if(a.Nombre==x){
                        sw=true;
                    }
                }
            }
            catch{
                Console.WriteLine("Fin del archivo..");
            }
            finally{
                arch.Close();
            }            
            return sw;
        }


    }
}