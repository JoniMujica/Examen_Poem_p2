
namespace ClinicaPrivada
{
    partial class FormListaMedicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablaMedicos = new System.Windows.Forms.DataGridView();
            this.ColMedicoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMedicoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMedicoDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMedicoEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMedicoEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoMuestraMedicoList = new System.Windows.Forms.GroupBox();
            this.RBDisponible = new System.Windows.Forms.RadioButton();
            this.RBOcupados = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMedicos)).BeginInit();
            this.grupoMuestraMedicoList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaMedicos
            // 
            this.tablaMedicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMedicoNombre,
            this.ColMedicoApellido,
            this.ColMedicoDni,
            this.ColMedicoEspecialidad,
            this.ColMedicoEstado});
            this.tablaMedicos.Location = new System.Drawing.Point(12, 25);
            this.tablaMedicos.Name = "tablaMedicos";
            this.tablaMedicos.RowTemplate.Height = 25;
            this.tablaMedicos.Size = new System.Drawing.Size(543, 344);
            this.tablaMedicos.TabIndex = 0;
            this.tablaMedicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColMedicoNombre
            // 
            this.ColMedicoNombre.HeaderText = "Nombre";
            this.ColMedicoNombre.Name = "ColMedicoNombre";
            // 
            // ColMedicoApellido
            // 
            this.ColMedicoApellido.HeaderText = "Apellido";
            this.ColMedicoApellido.Name = "ColMedicoApellido";
            // 
            // ColMedicoDni
            // 
            this.ColMedicoDni.HeaderText = "DNI";
            this.ColMedicoDni.Name = "ColMedicoDni";
            // 
            // ColMedicoEspecialidad
            // 
            this.ColMedicoEspecialidad.HeaderText = "Especialidad";
            this.ColMedicoEspecialidad.Name = "ColMedicoEspecialidad";
            // 
            // ColMedicoEstado
            // 
            this.ColMedicoEstado.HeaderText = "Estado";
            this.ColMedicoEstado.Name = "ColMedicoEstado";
            // 
            // grupoMuestraMedicoList
            // 
            this.grupoMuestraMedicoList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grupoMuestraMedicoList.AutoSize = true;
            this.grupoMuestraMedicoList.Controls.Add(this.RBDisponible);
            this.grupoMuestraMedicoList.Controls.Add(this.RBOcupados);
            this.grupoMuestraMedicoList.Location = new System.Drawing.Point(571, 25);
            this.grupoMuestraMedicoList.Name = "grupoMuestraMedicoList";
            this.grupoMuestraMedicoList.Size = new System.Drawing.Size(101, 100);
            this.grupoMuestraMedicoList.TabIndex = 1;
            this.grupoMuestraMedicoList.TabStop = false;
            this.grupoMuestraMedicoList.Text = "Mostrar";
            // 
            // RBDisponible
            // 
            this.RBDisponible.AutoSize = true;
            this.RBDisponible.Location = new System.Drawing.Point(7, 49);
            this.RBDisponible.Name = "RBDisponible";
            this.RBDisponible.Size = new System.Drawing.Size(81, 19);
            this.RBDisponible.TabIndex = 1;
            this.RBDisponible.TabStop = true;
            this.RBDisponible.Text = "Disponible";
            this.RBDisponible.UseVisualStyleBackColor = true;
            // 
            // RBOcupados
            // 
            this.RBOcupados.AutoSize = true;
            this.RBOcupados.Location = new System.Drawing.Point(7, 22);
            this.RBOcupados.Name = "RBOcupados";
            this.RBOcupados.Size = new System.Drawing.Size(79, 19);
            this.RBOcupados.TabIndex = 0;
            this.RBOcupados.TabStop = true;
            this.RBOcupados.Text = "Ocupados";
            this.RBOcupados.UseVisualStyleBackColor = true;
            // 
            // FormListaMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 445);
            this.Controls.Add(this.grupoMuestraMedicoList);
            this.Controls.Add(this.tablaMedicos);
            this.Name = "FormListaMedicos";
            this.Text = "FormListaMedicos";
            ((System.ComponentModel.ISupportInitialize)(this.tablaMedicos)).EndInit();
            this.grupoMuestraMedicoList.ResumeLayout(false);
            this.grupoMuestraMedicoList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaMedicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMedicoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMedicoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMedicoDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMedicoEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMedicoEstado;
        private System.Windows.Forms.GroupBox grupoMuestraMedicoList;
        private System.Windows.Forms.RadioButton RBDisponible;
        private System.Windows.Forms.RadioButton RBOcupados;
    }
}