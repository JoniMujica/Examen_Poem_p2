using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace ClinicaPrivada
{
    
    public partial class FormuAgregarMedico : Form
    {
        private Clinica clinica;
        Especialidades esp_select;

        public Clinica Clinica
        {
            get
            {
                return clinica;
            }
        }

        public Clinica Clinic1 { get { return clinica; } }

        public FormuAgregarMedico(Clinica clinica):this()
        {
            this.clinica = clinica;
        }
        public FormuAgregarMedico()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormuAgregarMedico_Load(object sender, EventArgs e)
        {
            foreach (Especialidades esp in Enum.GetValues(typeof(Especialidades)))
            {
                CBboxEspecialidaMedic.Items.Add(esp);
            }
        }

        private void BTNAgregarMedico_Click(object sender, EventArgs e)
        {
            string nombre = TXTNombreMedic.Text;
            string apellido = TXTApellidoMedic.Text;
            int dni = Int32.Parse(TXTDniMedic.Text);
            short edad = short.Parse(TXTEdadMedic.Text);
            string esp_S = CBboxEspecialidaMedic.Text;
            esp_select = (Especialidades)Enum.Parse(typeof(Especialidades), CBboxEspecialidaMedic.Text);
            clinica.AgregarMedico(nombre, apellido, dni, edad, esp_select);
        }
    }
}
