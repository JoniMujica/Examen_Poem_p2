using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Consulta
    {
        private bool estado;
        private Paciente paciente;
        private Medico medico;

        private Consulta()
        {
            this.estado = true;
        }
        public Consulta(Paciente paciente,Medico medico):this()
        {
            this.paciente = paciente;
            this.medico = medico;
        }

        public bool Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }
    }
}
