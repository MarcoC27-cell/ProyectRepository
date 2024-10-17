using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrimeraApp.Entidades
{
    public class Alumno:Entidad
    {
        private string v1;
        private string v2;
        private int v3;

        public int Edad { get; set; } = 12; //Regla de negocio


        public Alumno(string nombre, string apellido, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = 12;//Regla de negocio

          
            //usar regex para validar email
            if(string.IsNullOrEmpty(email) && !email.Contains("@"))
            {
                throw new InvalidOperationException("El email no es valido");
            }

            Email = email;
        }

        //Sobrecarga de constructor
        public Alumno(string nombre, string apellido,string email,int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Edad = edad;
        }

        public Alumno(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
}
