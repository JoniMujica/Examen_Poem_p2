using System;

namespace Entidades
{
    public abstract class Persona //private
    {
        string nombre;
        string apellido;
        int dni;
        short edad;

        public Persona(string nombre, string apellid, int dni, short edad)
        {
            this.Nombre = nombre;
            this.Apellido = apellid;
            this.Dni = dni;
            this.Edad = edad;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido {
            get { return apellido; }
            set { apellido = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public short Edad {
            get { return edad; }
            set { edad = value; }
        }
    }
}
