using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ControladorPaciente
    {
        private Queue<Paciente> paciente;
        public ControladorPaciente()
        {
            paciente = new Queue<Paciente>();
        }

        public Queue<Paciente> Paciente
        {
            get
            {
                return paciente;
            }
            set
            {
                paciente = value;
            }
        }

        public override bool Equals(object obj)
        {
            foreach (Paciente medico in this.paciente)
            {
                if (medico.Dni == ((Paciente)obj).Dni)
                {
                    return true;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (paciente).GetHashCode();
        }

        public static bool operator +(ControladorPaciente cm, Paciente p)
        {
            if (!cm.Equals(p))
            {
                cm.paciente.Enqueue(p);
                return true;
            }
            return false;
        }
        public static Paciente operator -(ControladorPaciente cm, Paciente p)
        {
            if (cm.paciente.Count > 0)
            {
                return cm.paciente.Dequeue();
            }
            return null;
        }
    }
}
