using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrimeraApp.Entidades
{
    public class Maestro:Entidad
    {
        private string v1;
        private string v2;
        private int v3;

        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Maestro(string nombre, string apellido, string email, string direccion, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email= email;
            


            //usar regex para validar email
            if (string.IsNullOrEmpty(email) && !email.Contains("@"))
            {
                throw new InvalidOperationException("El email no es valido");
            }

            Email = email;
        }

        public Maestro(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        //sobrecarga de metodo
        //    public Maestro (string nombre, string apellido, string email, string direccion, string telefono) 
        //    {
        //       Nombre= nombre;
        //        Apellido= apellido; 
        //        Email= email;   
        //        Telefono= telefono; 
        //        Direccion= direccion;



        //    } 
    }
    
}
