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
    public partial class Form1 : Form
    {

        Consulta consulta;
        ControladorPaciente ListaPacientes;
        ControladorMedicos ListaMedicos;
        Clinica clinica;
        FormuAgregarMedico agregadoMedico;
        FormListaMedicos formListaMedicos;
        
        public Form1()
        {
            InitializeComponent();
            consulta = new Consulta();
            ListaPacientes = new ControladorPaciente();
            ListaMedicos = new ControladorMedicos();
            clinica = new Clinica(ListaMedicos, ListaPacientes, consulta);
            /*
             z = clinica.AgregarMedico("Jonathan", "mujica", 6548611454, 19, Especialidades.Cardiologia);
            z = clinica.AgregarMedico("Jonathan", "mujica", 6548611454, 19, Especialidades.Cardiologia);

            z = clinica.AgregarMedico("Jonathan", "mujica", 6548611454, 19, Especialidades.Cardiologia); */

            
            
            //List<Medico> medico = clinica.CMLista;
            DisenioPersonal();
        }
        private void DisenioPersonal()
        {
            //oculo los subMenu
            panelMedicos.Visible = false;
            panelPacientes.Visible = false;
            panelTurnos.Visible = false;
        }
        private void OculparSubMenu()
        {
            
            if (panelMedicos.Visible == true)
            {
                panelMedicos.Visible = false;
            }
            if (panelPacientes.Visible == true)
            {
                panelPacientes.Visible = false;
            }
            if (panelTurnos.Visible == true)
            {
                panelTurnos.Visible = false;
            }
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void BTNMedicos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelMedicos);

        }

        private void BTNSMAgregarMedico_Click(object sender, EventArgs e)
        {
            //
            agregadoMedico = new FormuAgregarMedico(clinica);
            AbrirPanelHijo(agregadoMedico);
            OculparSubMenu();
        }

        private void BTNSMEliminarMedico_Click(object sender, EventArgs e)
        {
            
            OculparSubMenu();
        }

        private void BTNSMMostrarMedico_Click(object sender, EventArgs e)
        {
            formListaMedicos = new FormListaMedicos(clinica);
            
            AbrirPanelHijo(formListaMedicos);
            
            OculparSubMenu();
        }

        private void BTNPacientes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelPacientes);
        }

        private void BTNSMAgregarPaciente_Click(object sender, EventArgs e)
        {
            OculparSubMenu();
        }

        private void BTNSMMostrarPaciente_Click(object sender, EventArgs e)
        {
            OculparSubMenu();
        }

        private void BTNTurnos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelTurnos);
        }

        private void BTNTurnosEnCurso_Click(object sender, EventArgs e)
        {
            OculparSubMenu();
        }

        private void BTNHistorialTurnos_Click(object sender, EventArgs e)
        {
            OculparSubMenu();
        }

        private Form activeForm = null;

       // public Clinica Clinica { get { return clinica; } set { clinica = value; } }

        private void AbrirPanelHijo(Form formularioHijo)
        {
           
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            //activeForm.Close();
            activeForm = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelHijoFromu.Controls.Add(formularioHijo);
            panelHijoFromu.Tag = formularioHijo;
            //formularioHijo.BringToFront();
            formularioHijo.Show();
        }
    }
}
