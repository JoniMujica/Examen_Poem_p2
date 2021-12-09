using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Clinica : Ifuncionalidades
    {
        private ControladorMedicos controladorMedico;
        private ControladorPaciente controladorPaciente;
        private Consulta consulta;

        public List<Medico> CMLista 
        { 
            get
            {
                return controladorMedico.Medicos;
            } 
        }
        public Queue<Paciente> CMCola
        {
            get
            {
                return controladorPaciente.Paciente;
            }
        }

        public Clinica(ControladorMedicos controladorMedico, ControladorPaciente controladorPaciente, Consulta consulta)
        {
            this.controladorMedico = controladorMedico;
            this.controladorPaciente = controladorPaciente;
            this.consulta = consulta;
        }
        /*
        public Queue <Paciente> MostrarPacientes()
        {
            
            StringBuilder sb = new StringBuilder();
            int index = 1;
            foreach (Paciente paciente in this.controladorPaciente.Paciente)
            {
                sb.AppendLine($"Paciente n° {index} Nombre:{paciente.Nombre} Apellido: {paciente.Apellido} DNI:{paciente.Dni}");
                index++;
            }
            return sb.ToString();
            
            return controladorPaciente.Paciente;
        }

        public List<Medico> MostrarMedicos()
        {
            
            StringBuilder sb = new StringBuilder();
            foreach (Medico medico in this.controladorMedico.Medicos)
            {
                /*
                if (!medico.EstaAtendiendo)
                {
                    sb.AppendLine($"Nombre:{medico.Nombre} Apellido: {medico.Apellido} Especialidad: {medico.Especialidad} Estado: Disponible");
                }
                else
                {
                    sb.AppendLine($"Nombre:{medico.Nombre} Apellido: {medico.Apellido} Especialidad: {medico.Especialidad} Estado: Atendiendo");
                }

            }
            return sb.ToString();
            return controladorMedico.Medicos;
        }*/

        /// <summary>
        /// Agrega los pacientes a la cola de espera  a que se desocupen y verifica que estos no esten en la cola antes de agregarlos
        /// </summary>
        /// <param name="nombre">se le da el nombre al paciente</param>
        /// <param name="apellid">se le da el apellido al paciente</param>
        /// <param name="dni">se le da el DNI al paciente</param>
        /// <param name="edad">se le da la EDAD al paciente</param>
        /// <param name="obra">se le da el tipo de ObraSocial al paciente</param>
        /// <param name="atencion">se le da el tipo de Atencion al paciente</param>
        public bool AgregarPaciente(string nombre, string apellid, int dni, short edad, ObraSocial obra,Especialidades atencion)
        {
            Paciente paciente1 = new Paciente(nombre, apellid, dni, edad, obra,atencion);
            /*if (!controladorPaciente.Paciente.Contains(paciente1))
            {
                this.controladorPaciente.Paciente.Enqueue(paciente1);
            }*/
            if (controladorPaciente + paciente1)
            {
                return true;
                //return $"Se agrego correctamente al paciente {paciente1.Nombre} {paciente1.Apellido} DNI: {paciente1.Dni}";
            }
            return false;
            /*
            else
            {

                //return "No se pudo agregar al paciente solicitado, el paciente ya se encuentr en la lista de espera";
            }*/
        }

        public bool AgregarMedico(string nombre, string apellid, int dni, short edad, Especialidades especialidad)
        {
            Medico medico1 = new Medico(nombre, apellid, dni, edad, especialidad);
            /*
            if (controladorMedico + medico1 )
            {
                return $"Se agrego correctamente al Medico {medico1.Nombre} {medico1.Apellido} DNI: {medico1.Dni}";
            }
            else
            {
                return "No se pudo agregar al paciente solicitado, el paciente ya se encuentr en la lista de espera";
            }*/
            if (controladorMedico + medico1)
            {
                return true;
            }
            return false;
        }
        /*
        public void iniciarConsulta(Medico medico, Paciente paciente)
        {
            if (this.controladorPaciente.Paciente.Contains(paciente))
            {

            }
        }*/
    }
}
