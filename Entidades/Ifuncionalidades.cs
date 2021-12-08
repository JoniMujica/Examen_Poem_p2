using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface Ifuncionalidades
    {
        public void AgregarPaciente(string nombre, string apellid, int dni, short edad, ObraSocial obra);
        public void AgregarMedico(string nombre, string apellid, int dni, short edad, Especialidades especialidad);
        public string MostrarPacientes();
        public string MostrarMedicosDisponibles();
    }
    public enum ObraSocial
    {
        NoTiene = -1,
        CoberturaBasica,
        CoberturaCompleta,
    }
}
