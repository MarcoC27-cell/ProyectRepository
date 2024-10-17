using MyPrimeraApp.Entidades;
using MyPrimeraApp.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.MiPrimeraApp.Infraestructura.Txt.Repositorio
{
    class MaestroTxtRepositoy : IMaestroRepository
    {
        public void Guardar(Maestro maestro)
        {
            

            using (StreamWriter sw = new StreamWriter("C:\\BaseDeDatos\\Maestros.txt", true))
            {
                sw.WriteLine(maestro.Nombre + "," + maestro.Apellido + "," + maestro.Email + ","
                    + maestro.Direccion + "," + maestro.Telefono);
            }
            


        }

        public Maestro Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public List<Maestro> Obtener()
        {
            throw new NotImplementedException();
        }
    }
}
