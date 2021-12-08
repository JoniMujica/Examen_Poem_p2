using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades 
{ 
    
    public class Medico : Persona
    {
        private List<Medico> medicos;
        Especialidades especialidad;
        private bool estaAtendiendo;

        /// <summary>
        /// Aca cambiaria el estado del medico
        /// devolvera true si esta ocupado y false si esta disponible
        /// </summary>
        public bool EstaAtendiendo
        {
            get
            {
                return estaAtendiendo;
            }
            set
            {
                estaAtendiendo = value;
            }
        }

        public Especialidades Especialidad
        {
            get
            {
                return especialidad;
            }
            set
            {
                especialidad = value;
            }
        }

        private Medico(string nombre, string apellid, int dni, short edad) : base(nombre, apellid, dni, edad)
        {
        }

        public Medico(string nombre, string apellid, int dni, short edad,Especialidades especialidad) : this(nombre, apellid, dni, edad)
        {
            this.Especialidad = especialidad;
        }

        public override bool Equals(object obj)
        {
            return this.Dni == ((Medico)obj).Dni;
        }
        public override int GetHashCode()
        {
            return (Dni).GetHashCode();
        }

    }
}
