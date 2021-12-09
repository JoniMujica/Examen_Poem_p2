
namespace ClinicaPrivada
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.panelTurnos = new System.Windows.Forms.Panel();
            this.BTNHistorialTurnos = new System.Windows.Forms.Button();
            this.BTNTurnosEnCurso = new System.Windows.Forms.Button();
            this.BTNTurnos = new System.Windows.Forms.Button();
            this.panelPacientes = new System.Windows.Forms.Panel();
            this.BTNSMMostrarPaciente = new System.Windows.Forms.Button();
            this.BTNSMAgregarPaciente = new System.Windows.Forms.Button();
            this.BTNPacientes = new System.Windows.Forms.Button();
            this.panelMedicos = new System.Windows.Forms.Panel();
            this.BTNSMMostrarMedico = new System.Windows.Forms.Button();
            this.BTNSMEliminarMedico = new System.Windows.Forms.Button();
            this.BTNSMAgregarMedico = new System.Windows.Forms.Button();
            this.BTNMedicos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHijoFromu = new System.Windows.Forms.Panel();
            this.panelSubMenu.SuspendLayout();
            this.panelTurnos.SuspendLayout();
            this.panelPacientes.SuspendLayout();
            this.panelMedicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.AutoScroll = true;
            this.panelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelSubMenu.Controls.Add(this.panelTurnos);
            this.panelSubMenu.Controls.Add(this.BTNTurnos);
            this.panelSubMenu.Controls.Add(this.panelPacientes);
            this.panelSubMenu.Controls.Add(this.BTNPacientes);
            this.panelSubMenu.Controls.Add(this.panelMedicos);
            this.panelSubMenu.Controls.Add(this.BTNMedicos);
            this.panelSubMenu.Controls.Add(this.panelLogo);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(250, 561);
            this.panelSubMenu.TabIndex = 0;
            // 
            // panelTurnos
            // 
            this.panelTurnos.BackColor = System.Drawing.Color.Navy;
            this.panelTurnos.Controls.Add(this.BTNHistorialTurnos);
            this.panelTurnos.Controls.Add(this.BTNTurnosEnCurso);
            this.panelTurnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTurnos.Location = new System.Drawing.Point(0, 456);
            this.panelTurnos.Name = "panelTurnos";
            this.panelTurnos.Size = new System.Drawing.Size(250, 93);
            this.panelTurnos.TabIndex = 6;
            // 
            // BTNHistorialTurnos
            // 
            this.BTNHistorialTurnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNHistorialTurnos.FlatAppearance.BorderSize = 0;
            this.BTNHistorialTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNHistorialTurnos.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNHistorialTurnos.Location = new System.Drawing.Point(0, 40);
            this.BTNHistorialTurnos.Name = "BTNHistorialTurnos";
            this.BTNHistorialTurnos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BTNHistorialTurnos.Size = new System.Drawing.Size(250, 40);
            this.BTNHistorialTurnos.TabIndex = 1;
            this.BTNHistorialTurnos.Text = "Historial de turnos";
            this.BTNHistorialTurnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNHistorialTurnos.UseVisualStyleBackColor = true;
            this.BTNHistorialTurnos.Click += new System.EventHandler(this.BTNHistorialTurnos_Click);
            // 
            // BTNTurnosEnCurso
            // 
            this.BTNTurnosEnCurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNTurnosEnCurso.FlatAppearance.BorderSize = 0;
            this.BTNTurnosEnCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNTurnosEnCurso.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNTurnosEnCurso.Location = new System.Drawing.Point(0, 0);
            this.BTNTurnosEnCurso.Name = "BTNTurnosEnCurso";
            this.BTNTurnosEnCurso.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BTNTurnosEnCurso.Size = new System.Drawing.Size(250, 40);
            this.BTNTurnosEnCurso.TabIndex = 0;
            this.BTNTurnosEnCurso.Text = "Turnos en curso";
            this.BTNTurnosEnCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNTurnosEnCurso.UseVisualStyleBackColor = true;
            this.BTNTurnosEnCurso.Click += new System.EventHandler(this.BTNTurnosEnCurso_Click);
            // 
            // BTNTurnos
            // 
            this.BTNTurnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNTurnos.FlatAppearance.BorderSize = 0;
            this.BTNTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNTurnos.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNTurnos.Location = new System.Drawing.Point(0, 411);
            this.BTNTurnos.Name = "BTNTurnos";
            this.BTNTurnos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BTNTurnos.Size = new System.Drawing.Size(250, 45);
            this.BTNTurnos.TabIndex = 5;
            this.BTNTurnos.Text = "Turnos";
            this.BTNTurnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNTurnos.UseVisualStyleBackColor = true;
            this.BTNTurnos.Click += new System.EventHandler(this.BTNTurnos_Click);
            // 
            // panelPacientes
            // 
            this.panelPacientes.BackColor = System.Drawing.Color.Navy;
            this.panelPacientes.Controls.Add(this.BTNSMMostrarPaciente);
            this.panelPacientes.Controls.Add(this.BTNSMAgregarPaciente);
            this.panelPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPacientes.Location = new System.Drawing.Point(0, 322);
            this.panelPacientes.Name = "panelPacientes";
            this.panelPacientes.Size = new System.Drawing.Size(250, 89);
            this.panelPacientes.TabIndex = 4;
            // 
            // BTNSMMostrarPaciente
            // 
            this.BTNSMMostrarPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNSMMostrarPaciente.FlatAppearance.BorderSize = 0;
            this.BTNSMMostrarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSMMostrarPaciente.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNSMMostrarPaciente.Location = new System.Drawing.Point(0, 40);
            this.BTNSMMostrarPaciente.Name = "BTNSMMostrarPaciente";
            this.BTNSMMostrarPaciente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BTNSMMostrarPaciente.Size = new System.Drawing.Size(250, 40);
            this.BTNSMMostrarPaciente.TabIndex = 1;
            this.BTNSMMostrarPaciente.Text = "Mostrar Lista de Espera";
            this.BTNSMMostrarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNSMMostrarPaciente.UseVisualStyleBackColor = true;
            this.BTNSMMostrarPaciente.Click += new System.EventHandler(this.BTNSMMostrarPaciente_Click);
            // 
            // BTNSMAgregarPaciente
            // 
            this.BTNSMAgregarPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNSMAgregarPaciente.FlatAppearance.BorderSize = 0;
            this.BTNSMAgregarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSMAgregarPaciente.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNSMAgregarPaciente.Location = new System.Drawing.Point(0, 0);
            this.BTNSMAgregarPaciente.Name = "BTNSMAgregarPaciente";
            this.BTNSMAgregarPaciente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BTNSMAgregarPaciente.Size = new System.Drawing.Size(250, 40);
            this.BTNSMAgregarPaciente.TabIndex = 0;
            this.BTNSMAgregarPaciente.Text = "Agregar Paciente";
            this.BTNSMAgregarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNSMAgregarPaciente.UseVisualStyleBackColor = true;
            this.BTNSMAgregarPaciente.Click += new System.EventHandler(this.BTNSMAgregarPaciente_Click);
            // 
            // BTNPacientes
            // 
            this.BTNPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNPacientes.FlatAppearance.BorderSize = 0;
            this.BTNPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPacientes.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNPacientes.Location = new System.Drawing.Point(0, 277);
            this.BTNPacientes.Name = "BTNPacientes";
            this.BTNPacientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BTNPacientes.Size = new System.Drawing.Size(250, 45);
            this.BTNPacientes.TabIndex = 3;
            this.BTNPacientes.Text = "Pacientes";
            this.BTNPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPacientes.UseVisualStyleBackColor = true;
            this.BTNPacientes.Click += new System.EventHandler(this.BTNPacientes_Click);
            // 
            // panelMedicos
            // 
            this.panelMedicos.BackColor = System.Drawing.Color.Navy;
            this.panelMedicos.Controls.Add(this.BTNSMMostrarMedico);
            this.panelMedicos.Controls.Add(this.BTNSMEliminarMedico);
            this.panelMedicos.Controls.Add(this.BTNSMAgregarMedico);
            this.panelMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMedicos.Location = new System.Drawing.Point(0, 145);
            this.panelMedicos.Name = "panelMedicos";
            this.panelMedicos.Size = new System.Drawing.Size(250, 132);
            this.panelMedicos.TabIndex = 2;
            // 
            // BTNSMMostrarMedico
            // 
            this.BTNSMMostrarMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNSMMostrarMedico.FlatAppearance.BorderSize = 0;
            this.BTNSMMostrarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSMMostrarMedico.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNSMMostrarMedico.Location = new System.Drawing.Point(0, 80);
            this.BTNSMMostrarMedico.Name = "BTNSMMostrarMedico";
            this.BTNSMMostrarMedico.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BTNSMMostrarMedico.Size = new System.Drawing.Size(250, 40);
            this.BTNSMMostrarMedico.TabIndex = 2;
            this.BTNSMMostrarMedico.Text = "Mostrar Lista de Medicos";
            this.BTNSMMostrarMedico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNSMMostrarMedico.UseVisualStyleBackColor = true;
            this.BTNSMMostrarMedico.Click += new System.EventHandler(this.BTNSMMostrarMedico_Click);
            // 
            // BTNSMEliminarMedico
            // 
            this.BTNSMEliminarMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNSMEliminarMedico.FlatAppearance.BorderSize = 0;
            this.BTNSMEliminarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSMEliminarMedico.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNSMEliminarMedico.Location = new System.Drawing.Point(0, 40);
            this.BTNSMEliminarMedico.Name = "BTNSMEliminarMedico";
            this.BTNSMEliminarMedico.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BTNSMEliminarMedico.Size = new System.Drawing.Size(250, 40);
            this.BTNSMEliminarMedico.TabIndex = 1;
            this.BTNSMEliminarMedico.Text = "Eliminar Medico";
            this.BTNSMEliminarMedico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNSMEliminarMedico.UseVisualStyleBackColor = true;
            this.BTNSMEliminarMedico.Click += new System.EventHandler(this.BTNSMEliminarMedico_Click);
            // 
            // BTNSMAgregarMedico
            // 
            this.BTNSMAgregarMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNSMAgregarMedico.FlatAppearance.BorderSize = 0;
            this.BTNSMAgregarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSMAgregarMedico.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNSMAgregarMedico.Location = new System.Drawing.Point(0, 0);
            this.BTNSMAgregarMedico.Name = "BTNSMAgregarMedico";
            this.BTNSMAgregarMedico.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BTNSMAgregarMedico.Size = new System.Drawing.Size(250, 40);
            this.BTNSMAgregarMedico.TabIndex = 0;
            this.BTNSMAgregarMedico.Text = "Agregar Medico";
            this.BTNSMAgregarMedico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNSMAgregarMedico.UseVisualStyleBackColor = true;
            this.BTNSMAgregarMedico.Click += new System.EventHandler(this.BTNSMAgregarMedico_Click);
            // 
            // BTNMedicos
            // 
            this.BTNMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNMedicos.FlatAppearance.BorderSize = 0;
            this.BTNMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMedicos.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNMedicos.Location = new System.Drawing.Point(0, 100);
            this.BTNMedicos.Name = "BTNMedicos";
            this.BTNMedicos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BTNMedicos.Size = new System.Drawing.Size(250, 45);
            this.BTNMedicos.TabIndex = 1;
            this.BTNMedicos.Text = "Medicos";
            this.BTNMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNMedicos.UseVisualStyleBackColor = true;
            this.BTNMedicos.Click += new System.EventHandler(this.BTNMedicos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(250, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 105);
            this.panel1.TabIndex = 1;
            // 
            // panelHijoFromu
            // 
            this.panelHijoFromu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panelHijoFromu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHijoFromu.Location = new System.Drawing.Point(250, 0);
            this.panelHijoFromu.Name = "panelHijoFromu";
            this.panelHijoFromu.Size = new System.Drawing.Size(684, 456);
            this.panelHijoFromu.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelHijoFromu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSubMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSubMenu.ResumeLayout(false);
            this.panelTurnos.ResumeLayout(false);
            this.panelPacientes.ResumeLayout(false);
            this.panelMedicos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Panel panelTurnos;
        private System.Windows.Forms.Button BTNHistorialTurnos;
        private System.Windows.Forms.Button BTNTurnosEnCurso;
        private System.Windows.Forms.Button BTNTurnos;
        private System.Windows.Forms.Panel panelPacientes;
        private System.Windows.Forms.Button BTNSMMostrarPaciente;
        private System.Windows.Forms.Button BTNSMAgregarPaciente;
        private System.Windows.Forms.Button BTNPacientes;
        private System.Windows.Forms.Panel panelMedicos;
        private System.Windows.Forms.Button BTNSMMostrarMedico;
        private System.Windows.Forms.Button BTNSMEliminarMedico;
        private System.Windows.Forms.Button BTNSMAgregarMedico;
        private System.Windows.Forms.Button BTNMedicos;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHijoFromu;
    }
}

