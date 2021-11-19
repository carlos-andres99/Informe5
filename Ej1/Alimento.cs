using System.Collections.Generic;
using System.Text;
using System.IO;
using System;

namespace Ej1{
    [Serializable]
    class Alimento{

        //-> Atributtes

        private string nombre,fechaVencimiento;
        private double precio;

        //-> Getters & Setters

        public string Nombre{
            get{return nombre;}
            set{nombre=value;}
        }
        public string FechaVencimiento{
            get{return fechaVencimiento;}
            set{fechaVencimiento=value;}
        }
        public double Precio{
            get{return precio;}
            set{precio=value;}
        }

        //-> Constructors

        public Alimento(){}


        //-> File management methods

        public void escribir(BinaryWriter escritor){

            escritor.Write(this.Nombre);
            escritor.Write(this.FechaVencimiento);
            escritor.Write(this.Precio);

        }

        public void lectura(BinaryReader lector){

            this.Nombre=lector.ReadString();
            this.FechaVencimiento=lector.ReadString();
            this.Precio=lector.ReadDouble();
        
        }


        //-------------->Methods<---------------------
        
        public void leer(){
            
            Console.WriteLine("\nIntroduzca los datos:");
            
            Console.Write("Int. nombre: ");
            nombre=Console.ReadLine();
            
            Console.Write("Int. fechaVen: ");
            fechaVencimiento=Console.ReadLine();
            
            Console.Write("Int. Precio: ");
            precio=double.Parse(Console.ReadLine());
        
        }

        public void mostrar(){

            Console.WriteLine("\nNombre: "+nombre+" | FechaVen: "+fechaVencimiento+" | Precio: "+precio);        
        
        }
    }
}