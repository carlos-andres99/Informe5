using System.Collections.Generic;
using System.Text;
using System.IO;
using System;

namespace Ej2{

    [Serializable]
    class Zoologico{

        //-> Atributtes

        private string nombre,direccion;
        private int nroAnimales;
        private Animal[] animales=new Animal[300];

        //-> Getters & Setters

        public string Nombre{
            get{return nombre;}
            set{nombre=value;}
        }
        public string Direccion{
            get{return direccion;}
            set{direccion=value;}
        }
        public int NroAnimales{
            get{return nroAnimales;}
            set{nroAnimales=value;}
        }
        public Animal[] Animales{
            get{return animales;}
            set{animales=value;}
        }

        //-> Constructor

        public Zoologico(){
            for(int i=0; i<nroAnimales; i++){
                animales[i]=new Animal();
            }
        }


        //-> File management Methods

         public void escribir(BinaryWriter escritor){

             escritor.Write(this.Nombre);
             escritor.Write(this.Direccion);
             escritor.Write(this.NroAnimales);

             for(int i=0; i<this.NroAnimales ;i++){
                 animales[i].escribir(escritor);
             }
        }

        public void lectura(BinaryReader lector){

            this.Nombre=lector.ReadString();
            this.Direccion=lector.ReadString();
            this.NroAnimales=lector.ReadInt32();
           
            for(int i=0; i<this.NroAnimales ;i++){
                animales[i].lectura(lector);
            }
        }

        //-------------->Methods<-------------------

        public void leer(){

            Console.WriteLine("\nInt. Datos Zoologico: ");
            
            Console.Write("Nombre: ");
            nombre=Console.ReadLine();
            
            Console.Write("Direccion: ");
            direccion=Console.ReadLine();

            Console.Write("NroAnimales: ");
            nroAnimales=int.Parse(Console.ReadLine());

            for(int i=0; i<nroAnimales ;i++){
                animales[i].leer();
            }
        }

        public void mostrar(){

            Console.WriteLine("\nNombre: "+nombre+" | Direccion: "+direccion+" | NroAnimales: "+nroAnimales);
            
            Console.WriteLine("--------------Animales-------------\n");
            for(int i=0; i<nroAnimales ;i++){
                animales[i].mostrar();
            }
            Console.WriteLine("----------------------------------------");    
        }
    }
} 