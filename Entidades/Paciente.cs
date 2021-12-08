using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        private ObraSocial obraSocial;
        private Especialidades atencion;

        private Paciente(string nombre, string apellid, int dni, short edad) : base(nombre, apellid, dni, edad)
        {
        }
        public Paciente(string nombre, string apellid, int dni, short edad,ObraSocial obra,Especialidades atencion) : this(nombre, apellid, dni, edad)
        {
            this.obraSocial = obra;
            this.atencion = atencion;
        }

        /// <summary>
        ///  Valida que ambos objetos sea iguales dependiendo el DNI
        /// </summary>
        /// <param name="obj">Objeto paciente a comparar</param>
        /// <returns>Retorna true si son iguales o false si no lo son</returns>
        public override bool Equals(object obj)
        {
            return this.Dni == ((Paciente)obj).Dni;
        }
        public override int GetHashCode()
        {
            return (Dni).GetHashCode();
        }
       
    }
}
