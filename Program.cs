using System;

namespace Pase
{
    class Auto
    {
        //Creación de los atributos
        public string Nombre, Modelo;
        public int Precio;
       
        
        public string getNombre()
        {
            return Nombre;
        }
        public void setNombre(string N)
        {
            Nombre=N;
        }
         public string getModelo()
        {
            return Modelo;
        }
        public void setModelo(string M)
        {
            Modelo=M;
        }
         public int getPrecio()
        {
            return Precio;
        }
        public void setPrecio(int P)
        {
            Precio=P;
        }

        public void Mes(int Precio)
        {
            Precio=Precio*4;
        }
        public void MesInteres(ref int Precio)
        {
            Precio=Precio+150;
        }

      //Creación del constructor para auto
      public Auto( string Nombre, string Modelo, int Precio)
        {
            this.Nombre= Nombre;
            this.Modelo= Modelo;
            this.Precio=Precio;
        }
        public Auto()
        {

        }

        public  void Imprime()
        {
            Console.WriteLine("Nombre: {0}, Modelo: {1}, Precio: {2}", this.Nombre, this.Modelo, this.Precio);
        }
        public void Dia(out int Precio)
        {
            Precio=300;
        }
      
    }
     class Anonimo
    {
        static public void Anonimiza(Auto B)
        {
            B.Nombre="XXX";
            B.Modelo="XXX";
            B.Precio=0;
        }
        
   
     class Program
     {
        static void Main(string[] args)
        {
            //Creación del objeto
            Auto A =new Auto();
            int PrecioA=500;
            A.Mes(PrecioA);
            Console.WriteLine("Precio Mensual: {0}",PrecioA);
            A.MesInteres(ref PrecioA);
            Console.WriteLine("Precio mensual más intereses: {0}",PrecioA);
            A.Dia(out PrecioA);
            Console.WriteLine("Precio con rebaja: {0}", PrecioA);
           A.setNombre("Nissan Skyline");
           A.setModelo("GTR-R34");
           A.setPrecio(150000);

            //Impresiones
            A.Imprime();
            Anonimiza(A);
           // Console.WriteLine(A.Nombre+A.Modelo+PrecioA);
        }
      }
    }
}