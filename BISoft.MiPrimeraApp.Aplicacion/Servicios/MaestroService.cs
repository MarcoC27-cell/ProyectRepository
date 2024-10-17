using MyPrimeraApp.Entidades;
using MyPrimeraApp.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.MiPrimeraApp.Aplicacion.Servicios
{
    public class MaestroService
    {
        private readonly IMaestroRepository _repo;

        public MaestroService(IMaestroRepository repo)
        {
            _repo = repo;
        }

        public Maestro CrearMaestro(string nombre, string apellido,
            string email, string Direccion, string Telefono)
        {
            var existeMaestro = _repo.Obtener().Any(x => x.Email == email);
            if (existeMaestro)
            {
                throw new Exception("El maestro ya existe");
            }

            var maestro = new Maestro(nombre, apellido, email, Direccion, Telefono);
            return maestro;
        }
    }
}
