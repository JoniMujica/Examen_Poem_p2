using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface Ifuncionalidades
    {
        //public void iniciarConsulta(Medico medico, Paciente paciente);
        public string AgregarPaciente(string nombre, string apellid, int dni, short edad, ObraSocial obra,Especialidades atencion);
        public string AgregarMedico(string nombre, string apellid, int dni, short edad, Especialidades especialidad);
        public string MostrarPacientes();
        public string MostrarMedicos();
    }
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
    public enum ObraSocial
    {
        NoTiene = -1,
        CoberturaBasica,
        CoberturaCompleta,
    }
}
