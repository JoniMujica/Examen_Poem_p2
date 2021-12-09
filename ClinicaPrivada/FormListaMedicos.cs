using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaPrivada
{
    public partial class FormListaMedicos : Form
    {
        private Clinica clinica;
        public FormListaMedicos()
        {
            InitializeComponent();


        }
        public FormListaMedicos(Clinica clinica) : this()
        {
            this.clinica = clinica;
            RellenarTabla(this.clinica.CMLista);
        }

        public Clinica Clinica { get { return clinica; } } 

        public void RellenarTabla(List<Medico> medicos)
        {
            int i = 0;
            if (medicos != null)
            {
                foreach (Medico medic in medicos)
                {
                    DataGridViewRow row = (DataGridViewRow)tablaMedicos.Rows[i].Clone();
                    row.Cells[0].Value = medic.Nombre;
                    row.Cells[1].Value = medic.Apellido;
                    row.Cells[2].Value = medic.Dni;
                    row.Cells[3].Value = medic.Especialidad;
                    row.Cells[4].Value = (medic.EstaAtendiendo) ? "Ocupado" : "Disponible";
                    tablaMedicos.Rows.Add(row);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
