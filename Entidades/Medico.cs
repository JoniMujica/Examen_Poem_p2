using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
        public enum Especialidades
        {
            Cardiologia,
            Dermatologia,
            Diabetologia,
            Laboratorio,
            Odontologia,
            Oncologia,
            Rehabilitacion,
            Hemoterapia
        }
{
    public class Medico : Persona
    {
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

    }
}
