using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Clinica : Ifuncionalidades
    {
        private Queue<Paciente> pacientes;
        private List<Medico> medicos;


        private Clinica()
        {
            pacientes = new Queue<Paciente>();
            medicos = new List<Medico>();
        }
        public string MostrarPacientes()
        {
            StringBuilder sb = new StringBuilder();
            int index = 1;
            foreach (Paciente paciente in pacientes)
            {
                sb.AppendLine($"Paciente n° {index} Nombre:{paciente.Nombre} Apellido: {paciente.Apellido} DNI:{paciente.Dni}");
                index++;
            }
            return sb.ToString();
        }

        public string MostrarMedicosDisponibles()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Medico medico in medicos)
            {
                if (!medico.EstaAtendiendo)
                {
                    sb.AppendLine($"Nombre:{medico.Nombre} Apellido: {medico.Apellido} Especialidad: {medico.Especialidad}");

                }
            }
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            Paciente paciente = obj as Paciente;
            return paciente is not null && this.pacientes.Contains(paciente);
        }
        public override int GetHashCode()
        {
            return (pacientes).GetHashCode();
        }

        public void AgregarPaciente(string nombre, string apellid, int dni, short edad, ObraSocial obra)
        {
            Paciente paciente1 = new Paciente(nombre, apellid, dni, edad, obra);
            if (!this.Equals(paciente1))
            {
                this.pacientes.Enqueue(paciente1);
            }
        }

        public void AgregarMedico(string nombre, string apellid, int dni, short edad, Especialidades especialidad)
        {
            Medico medico1 = new Medico(nombre, apellid, dni, edad, especialidad);
        }

    }
}
