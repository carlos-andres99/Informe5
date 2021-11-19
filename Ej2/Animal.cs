using System.Collections.Generic;
using System.Text;
using System.IO;
using System;

namespace Ej2{

   [Serializable]
    class Animal{

        //-> Atributtes

        private string especie, nombre, sexo;
        private int edad;

        //-> Getters and Setters

        public string Especie{
            get{return especie;}
            set{especie=value;}
        }
        public string Nombre{
            get{return nombre;}
            set{nombre=value;}
        }
        public string Sexo{
            get{return sexo;}
            set{sexo=value;}
        }
        public int Edad{
            get{return edad;}
            set{edad=value;}
        }

        //-> Constructor
        public Animal(){}

        //-> File management Methods

        public void escribir(BinaryWriter escritor){

            escritor.Write(this.Especie);
            escritor.Write(this.Nombre);
            escritor.Write(this.Edad);
            escritor.Write(this.Sexo);
        }

        public void lectura(BinaryReader lector){

            this.Especie=lector.ReadString();
            this.Nombre=lector.ReadString();
            this.Edad=lector.ReadInt32();
            this.Sexo=lector.ReadString();
        }

        //------------->Methods<-------------

        public void leer(){
            
            Console.WriteLine("\nInt. datos del Animal: ");
            
            Console.Write("Especie: ");
            especie=Console.ReadLine();
            
            Console.Write("Nombre: ");
            nombre=Console.ReadLine();

            Console.Write("Edad: ");
            edad=int.Parse(Console.ReadLine());

            Console.WriteLine("Sexo: ");
            sexo=Console.ReadLine();
        }

        public void mostrar(){

            Console.WriteLine("\nEspecie: "+especie+" | Nombre: "+nombre+" | Edad: "+edad+" | Sexo: "+sexo);
        }
    }
}